using System.Collections.Generic;

namespace NHibernate.Test.SubclassFilterTest
{
    public class User
    {
        private long id;

        public virtual long Id
        {
            get { return id; }
            set { id = value; }
        }

        private Staff staff;

        public virtual Staff Staff
        {
            get { return staff; }
            set { staff = value; }
        }
    }
}