namespace GL.Servers.HD.Files.CSV_Logic.Data
{
	using GL.Servers.Files.CSV_Reader;
	using GL.Servers.HD.Files.CSV_Helpers;

    internal class FruitData : Data
    {
		/// <summary>
        /// Initializes a new instance of the <see cref="FruitData"/> class.
        /// </summary>
        /// <param name="Row">The row.</param>
        /// <param name="DataTable">The data table.</param>
        public FruitData(Row Row, DataTable DataTable) : base(Row, DataTable)
        {
            Data.Load(this, this.GetType(), Row);
        }

        public string ToolIconExportName
        {
            get; set;
        }

        public string TID
        {
            get; set;
        }

        public string ProcessingBuilding
        {
            get; set;
        }

        public int OrderPrice
        {
            get; set;
        }

        public int OrderExp
        {
            get; set;
        }

        public int ExpCollect
        {
            get; set;
        }

        public int DumbValue
        {
            get; set;
        }

        public int OrderValue
        {
            get; set;
        }

        public int BoatOrderValue
        {
            get; set;
        }

        public int UnlockLevel
        {
            get; set;
        }

        public string DescriptionTID
        {
            get; set;
        }

        public int Difficulty
        {
            get; set;
        }
    }
}
