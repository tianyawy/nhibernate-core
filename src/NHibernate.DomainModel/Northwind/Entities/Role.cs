﻿
namespace NHibernate.DomainModel.Northwind.Entities
{
	public class Role
	{
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual bool IsActive { get; set; }
		public virtual AnotherEntity Entity { get; set; }
		public virtual Role ParentRole { get; set; }

	    public virtual dynamic ToDto()
	    {
	        return new
	        {
	            name = Name
	        };
	    }
	}
}
