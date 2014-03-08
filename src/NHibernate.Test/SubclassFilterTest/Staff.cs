using System.Collections.Generic;

namespace NHibernate.Test.SubclassFilterTest
{
    public class Staff
    {
        private string name;
        private long id;

        public virtual long Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
 
    }


    public class OfficeStaff : Staff
    {
        private Office office;

        public virtual Office Office
        {
            get { return office; }
            set { office = value; }
        }
    }

    public class UserStaff : Staff
    {
        private IList<User> users;

        public virtual IList<User> Users
        {
            get { return users; }
            set { users = value; }
        }
    }
}