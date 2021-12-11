namespace Supercell.Laser.Server.Files.Tables
{
using Supercell.Laser.Server.Files.CsvReader;
using Supercell.Laser.Server.Files.CsvHelpers;
    public class LogicItemData : CsvData
    {
        public LogicItemData(Row row, DataTable datatable) : base(row, datatable)
        {
            LoadData(this, GetType(), row);
        }

        public string Name { get; set; }

        public string ParentItemForSkin { get; set; }

        public string FileName { get; set; }

        public string ExportName { get; set; }

        public string ExportNameEnemy { get; set; }

        public string ShadowExportName { get; set; }

        public string GroundGlowExportName { get; set; }

        public string LoopingEffect { get; set; }

        public int Value { get; set; }

        public int Value2 { get; set; }

        public int TriggerRangeSubTiles { get; set; }

        public string TriggerAreaEffect { get; set; }

        public bool CanBePickedUp { get; set; }

        public string SpawnEffect { get; set; }

        public string ActivateEffect { get; set; }

        public string SCW { get; set; }

        public string SCWEnemy { get; set; }

        public string Layer { get; set; }
    }
}
