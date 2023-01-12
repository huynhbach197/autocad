using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;


namespace AutoCadProgrammingDemo
{
    public class UpdateLayerUtil
    {
        [CommandMethod("AddCircleToFiles")]
        public void UpdateLayer()
        {
            LayerUpdateForm layerUpdateForm = new LayerUpdateForm();
            layerUpdateForm.Show();
        }

        public static void drawCircle(string path)
        {
            var document = Application.DocumentManager.Open(path);
            var database = document.Database;
            var editor = document.Editor;

            document.LockDocument();
            try
            {
                using (Transaction transaction = database.TransactionManager.StartTransaction())
                {
                    // Open the Block table for read
                    BlockTable blockTable;
                    blockTable = transaction.GetObject(database.BlockTableId,
                                                 OpenMode.ForRead) as BlockTable;
                    BlockTableRecord blockTableRecord;
                    blockTableRecord = transaction.GetObject(blockTable[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    Circle circle = new Circle();
                    circle.SetDatabaseDefaults();
                    circle.Center = new Point3d(2, 3, 0);
                    circle.Radius = 4.25;

                    // Add the new object to the block table record and the transaction
                    blockTableRecord.AppendEntity(circle);
                    transaction.AddNewlyCreatedDBObject(circle, true);

                    // Save the new object to the database
                    transaction.Commit();
                }
            }
            catch (Autodesk.AutoCAD.Runtime.Exception exception)
            {
                editor.WriteMessage(exception.ToString());
            }
        }


        public static void updateLayer(string path, string oldLayer, string newLayer)
        {
            var doc = Application.DocumentManager.Open(path);
            var db = doc.Database;
            var editor = doc.Editor;

            doc.LockDocument();
            try
            {
                using (var trans = db.TransactionManager.StartTransaction())
                {
                    TypedValue[] typedValue = new TypedValue[1];
                    typedValue.SetValue(new TypedValue((int)DxfCode.LayerName, oldLayer), 0);
                    SelectionFilter selectionFilter = new SelectionFilter(typedValue);
                    var selectResult = editor.SelectAll(selectionFilter);
                    if (selectResult.Status == PromptStatus.OK)
                    {
                        var listResult = selectResult.Value;
                        foreach (SelectedObject result in listResult)
                        {
                            if (result != null)
                            {
                                var entity = trans.GetObject(result.ObjectId, OpenMode.ForWrite) as Entity;
                                entity.Layer = newLayer;
                            }
                        }
                
                    }
                    else
                    {
                        editor.WriteMessage("There is no object selected");
                    }
                    trans.Commit();
                    db.SaveAs(newLayer, DwgVersion.Current);
                    doc.CloseAndDiscard();
                }
            } 
            catch (Autodesk.AutoCAD.Runtime.Exception exception)
            {
                editor.WriteMessage(exception.ToString());
            }
        }
    }
}
