namespace GL.Servers.CoC.Files.CSV_Logic.Logic
{
	using GL.Servers.Files.CSV_Reader;
	using GL.Servers.CoC.Files.CSV_Helpers;

    internal class AchievementData : Data
    {
		/// <summary>
        /// Initializes a new instance of the <see cref="AchievementData"/> class.
        /// </summary>
        /// <param name="Row">The row.</param>
        /// <param name="DataTable">The data table.</param>
        public AchievementData(Row Row, DataTable DataTable) : base(Row, DataTable)
        {
            // AchievementData.
        }

        public int Level
        {
            get; set;
        }

        public int LevelCount
        {
            get; set;
        }

        public string TID
        {
            get; set;
        }

        public string InfoTID
        {
            get; set;
        }

        public string Action
        {
            get; set;
        }

        public int ActionCount
        {
            get; set;
        }

        public string ActionData
        {
            get; set;
        }

        public int ExpReward
        {
            get; set;
        }

        public int DiamondReward
        {
            get; set;
        }

        public string IconSWF
        {
            get; set;
        }

        public string IconExportName
        {
            get; set;
        }

        public string CompletedTID
        {
            get; set;
        }

        public bool ShowValue
        {
            get; set;
        }

        public string AndroidID
        {
            get; set;
        }

        public int UIGroup
        {
            get; set;
        }
    }
}
