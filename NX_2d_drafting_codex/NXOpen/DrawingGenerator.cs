using System;
using System.IO;
using NX_2d_drafting_codex.Helpers;

namespace NX_2d_drafting_codex.NXOpen
{
    internal sealed class DrawingGenerator
    {
        private const string MetricA4Template =
            @"C:\Program Files\Siemens\NX 12.0\DRAFTING\templates\Drawing-A4-Size2D-template.prt";

        private readonly PdfExporter pdfExporter;

        public DrawingGenerator()
        {
            pdfExporter = new PdfExporter();
        }

        public PartProcessResult GenerateDrawing(DrawingGenerationRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            Report(request, "Opening Part...");

            global::NXOpen.Session session = global::NXOpen.Session.GetSession();
            global::NXOpen.PartLoadStatus loadStatus;
            global::NXOpen.BasePart openedPart = session.Parts.OpenBaseDisplay(request.PartFilePath, out loadStatus);

            global::NXOpen.Part workPart = openedPart as global::NXOpen.Part;
            if (workPart == null)
            {
                throw new InvalidOperationException("The selected file could not be opened as an NX part.");
            }

            try
            {
                session.Parts.SetWork(workPart);
                session.Parts.SetDisplay(workPart, false, false, out loadStatus);

                if (IsAssembly(workPart))
                {
                    Report(request, "Assembly detected - skipping.");
                    return PartProcessResult.SkippedAssembly;
                }

                Report(request, "Entering Drafting...");
                session.ApplicationSwitchImmediate("UG_APP_DRAFTING");
                workPart.Drafting.EnterDraftingApplication();

                Report(request, "Creating Sheet...");
                global::NXOpen.Drawings.DraftingDrawingSheet sheet = CreateSheet(session, workPart);
                sheet.Open();

                Report(request, "Creating Views...");
                CreateStandardViews(workPart);

                if (request.SaveDrawing)
                {
                    Report(request, "Saving Drawing...");
                    SavePart(workPart);
                }

                if (request.ExportPdf)
                {
                    Report(request, "Exporting PDF...");
                    string pdfPath = FileHelper.BuildOutputPath(request.OutputFolderPath, request.PartFilePath, ".pdf");
                    pdfExporter.Export(workPart, sheet, pdfPath);
                }

                Report(request, "Completed Successfully.");
                return PartProcessResult.DrawingGenerated;
            }
            finally
            {
                // Close the part so the next file in the folder starts clean,
                // regardless of whether it was an assembly, succeeded, or failed.
                ClosePartQuietly(workPart);
            }
        }

        /// <summary>
        /// A part is an assembly if it has a root component in its
        /// ComponentAssembly. Piece parts have no root component (Nothing/null).
        /// </summary>
        private static bool IsAssembly(global::NXOpen.Part workPart)
        {
            try
            {
                global::NXOpen.Assemblies.Component root = workPart.ComponentAssembly.RootComponent;
                return root != null;
            }
            catch (global::NXOpen.NXException)
            {
                // If the assembly state can't be queried (e.g. partially loaded),
                // err on the side of caution and treat it as an assembly so it
                // gets skipped rather than mis-processed.
                return true;
            }
        }

        private static void ClosePartQuietly(global::NXOpen.Part workPart)
        {
            try
            {
                if (workPart != null)
                {
                    workPart.Close(
                        global::NXOpen.BasePart.CloseWholeTree.False,
                        global::NXOpen.BasePart.CloseModified.CloseModified,
                        null);
                }
            }
            catch (global::NXOpen.NXException)
            {
                // Best-effort cleanup; do not let a close failure mask the real result.
            }
        }

        private static global::NXOpen.Drawings.DraftingDrawingSheet CreateSheet(
            global::NXOpen.Session session,
            global::NXOpen.Part workPart)
        {
            global::NXOpen.Drawings.DraftingDrawingSheetBuilder sheetBuilder =
                workPart.DraftingDrawingSheets.CreateDraftingDrawingSheetBuilder(null);

            try
            {
                sheetBuilder.AutoStartViewCreation = true;
                sheetBuilder.MetricSheetTemplateLocation = MetricA4Template;
                sheetBuilder.Height = 841.0;
                sheetBuilder.Length = 1189.0;
                sheetBuilder.StandardMetricScale = global::NXOpen.Drawings.DrawingSheetBuilder.SheetStandardMetricScale.S11;
                sheetBuilder.StandardEnglishScale = global::NXOpen.Drawings.DrawingSheetBuilder.SheetStandardEnglishScale.S11;
                sheetBuilder.ScaleNumerator = 1.0;
                sheetBuilder.ScaleDenominator = 1.0;
                sheetBuilder.Units = global::NXOpen.Drawings.DrawingSheetBuilder.SheetUnits.Metric;
                sheetBuilder.ProjectionAngle = global::NXOpen.Drawings.DrawingSheetBuilder.SheetProjectionAngle.Third;
                sheetBuilder.Number = "1";
                sheetBuilder.SecondaryNumber = string.Empty;
                sheetBuilder.Revision = "A";

                global::NXOpen.NXObject sheetObject = sheetBuilder.Commit();
                return (global::NXOpen.Drawings.DraftingDrawingSheet)sheetObject;
            }
            finally
            {
                sheetBuilder.Destroy();
            }
        }

        private static void CreateStandardViews(global::NXOpen.Part workPart)
        {
            global::NXOpen.Drawings.BaseView baseView = CreateBaseView(
                workPart,
                "Front",
                new global::NXOpen.Point3d(59.719844357976669, 160.97616731517508, 0.0));

            CreateProjectedView(workPart, baseView, new global::NXOpen.Point3d(159.66731517509726, 160.97616731517508, 0.0));
            CreateProjectedView(workPart, baseView, new global::NXOpen.Point3d(59.719844357976669, 95.368190661478593, 0.0));
            CreateProjectedView(workPart, baseView, new global::NXOpen.Point3d(161.06322957198444, 101.23103112840467, 0.0));
        }

        private static global::NXOpen.Drawings.BaseView CreateBaseView(
            global::NXOpen.Part workPart,
            string modelViewName,
            global::NXOpen.Point3d placement)
        {
            global::NXOpen.Drawings.BaseViewBuilder baseViewBuilder =
                workPart.DraftingViews.CreateBaseViewBuilder(null);

            try
            {
                global::NXOpen.ModelingView modelView =
                    (global::NXOpen.ModelingView)workPart.ModelingViews.FindObject(modelViewName);

                baseViewBuilder.Placement.Associative = true;
                baseViewBuilder.SelectModelView.SelectedView = modelView;
                baseViewBuilder.SecondaryComponents.ObjectType =
                    global::NXOpen.Drawings.DraftingComponentSelectionBuilder.Geometry.PrimaryGeometry;
                baseViewBuilder.Style.ViewStyleBase.Part = workPart;
                baseViewBuilder.Style.ViewStyleBase.PartName = workPart.FullPath;
                baseViewBuilder.Placement.Placement.SetValue(null, workPart.Views.WorkView, placement);

                return (global::NXOpen.Drawings.BaseView)baseViewBuilder.Commit();
            }
            finally
            {
                baseViewBuilder.Destroy();
            }
        }

        private static void CreateProjectedView(
            global::NXOpen.Part workPart,
            global::NXOpen.Drawings.BaseView parentView,
            global::NXOpen.Point3d placement)
        {
            global::NXOpen.Drawings.ProjectedViewBuilder projectedViewBuilder =
                workPart.DraftingViews.CreateProjectedViewBuilder(null);

            try
            {
                projectedViewBuilder.Placement.Associative = true;
                projectedViewBuilder.Placement.AlignmentMethod =
                    global::NXOpen.Drawings.ViewPlacementBuilder.Method.PerpendicularToHingeLine;
                projectedViewBuilder.Placement.AlignmentOption =
                    global::NXOpen.Drawings.ViewPlacementBuilder.Option.ModelPoint;
                projectedViewBuilder.Parent.View.Value = parentView;
                projectedViewBuilder.SecondaryComponents.ObjectType =
                    global::NXOpen.Drawings.DraftingComponentSelectionBuilder.Geometry.PrimaryGeometry;
                projectedViewBuilder.Style.ViewStyleBase.PartName = workPart.FullPath;
                projectedViewBuilder.Style.ViewStyleDetail.Orient = false;
                projectedViewBuilder.Style.ViewStyleGeneral.ExtractedEdges =
                    global::NXOpen.Preferences.GeneralExtractedEdgesOption.Associative;
                projectedViewBuilder.Style.ViewStyleProjected.Scale = false;
                projectedViewBuilder.Style.ViewStyleProjected.Align = false;
                projectedViewBuilder.Style.ViewStyleSectionConstraints.Scale = false;
                projectedViewBuilder.Style.ViewStyleSectionConstraints.Align = false;
                projectedViewBuilder.Placement.AlignmentView.Value = parentView;
                projectedViewBuilder.Placement.Placement.SetValue(null, workPart.Views.WorkView, placement);

                projectedViewBuilder.Commit();
            }
            finally
            {
                projectedViewBuilder.Destroy();
            }
        }

        private static void SavePart(global::NXOpen.Part workPart)
        {
            global::NXOpen.PartSaveStatus saveStatus = workPart.Save(
                global::NXOpen.BasePart.SaveComponents.True,
                global::NXOpen.BasePart.CloseAfterSave.False);
        }

        private static void Report(DrawingGenerationRequest request, string message)
        {
            if (request.ReportProgress != null)
            {
                request.ReportProgress(message);
            }
        }
    }
}
