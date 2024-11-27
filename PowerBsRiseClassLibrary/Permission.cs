namespace PowerBsRiseClassLibrary
{
	/// <summary>
	/// this permission class is has nothing to do with broadsign permissions or users ! this is independant and only for this tool
	/// </summary>
    internal class Permission
    {
		private int _id;
		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
