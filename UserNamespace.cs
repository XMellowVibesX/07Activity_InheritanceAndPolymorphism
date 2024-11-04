namespace UserNamespace
{
    public abstract class User
    {
        protected string userID;
        protected string userPassword;

        public User(string userID, string userPassword)
        {
            this.userID = userID;
            this.userPassword = userPassword;
        }

        public bool verifyLogin(string id, string pass)
        {
            return this.userID == id && this.userPassword == pass;
        }

        public abstract void updatePassword(string newPass);

    }

    public class Administrator : User
    {
        private string adminName;

        public Administrator(string userID, string userPassword, string adminName) : base(userID, userPassword)
        {
            this.adminName = adminName;
        }

        public void updateAdminName(string newName)
        {
            this.adminName = newName;
        }

        public override void updatePassword(string newPass)
        {
            this.userPassword = newPass;
        }

        public string getUsername()
        {
            return this.adminName;
        }

        public string getPassword()
        {
            return this.userPassword;
        }
    }
}