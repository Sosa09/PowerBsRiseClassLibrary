namespace PowerBsRiseClassLibrary
{
    /// <summary>
    /// a person can be a assigned the group viewer but exceptionnaly some individual permissions can be granted temporarly 
    /// </summary>
    internal class Person
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
        private Role _pRole;
        public Role PRole
        {
            get { return _pRole; }
            set { _pRole = value; }
        }
        private List<UserGroup> _userGroups;
        public List<UserGroup> UserGroups
        {
            get { return _userGroups; }
            set { _userGroups = value; }
        }
        private List<Permission> _permissions;
        public List<Permission> Permissions
        {
            get { return _permissions; }
            set { _permissions = value; }
        }
    }
}
