namespace NHibernate.Test.SubclassFilterTest
{
    public class Office
    {
        private long id;

        public virtual long Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}