namespace PowerBsRiseClassLibrary
{
    /// <summary>
    /// this group will contain group names such as viewer, admin, super user based on that some permission will be granted and some won't
    /// </summary>
    internal class UserGroup
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
        private List<Permission> _permissions;
        public List<Permission> Permissions
        {
            get { return _permissions; }
            set { _permissions = value; }
        }
    }
}
