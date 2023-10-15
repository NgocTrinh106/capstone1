using MVCLOGIN.DbEF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using PagedList;

namespace MVCLOGIN.Models
{
    public partial class Model1 : DbContext
    {
        ProjectDbContext db = null;
        public Model1()
            : base("name=Model1")
        {
            db = new ProjectDbContext();
        }

        public Customer GetName(string name)
        {
            return db.Customers.SingleOrDefault(x=>x.CustomerFirstName == name);
        }
        public IEnumerable<Customer> ListAllPaging(int page, int PageSize) 
        {
            return db.Customers.OrderBy(x=>x.CustomerID).ToPagedList(page,PageSize);
        }
        public Customer GetID(int id)
        {
            return db.Customers.Find(id);
        }
        public virtual DbSet<User> Users { get; set; }
        public bool UpdateCustomer(Customer entity)
        {
            try
            {
                var customer = db.Customers.Find(entity.CustomerID);
                customer.CustomerFirstName = entity.CustomerFirstName;
                customer.CustomerLastName = entity.CustomerLastName;
                customer.CustomerSex = entity.CustomerSex;
                customer.MetaTitle = entity.MetaTitle;
                customer.CustomerParentID = entity.CustomerParentID;
                customer.DisplayOrder = entity.DisplayOrder;
                customer.SeoTitle = entity.SeoTitle;
                customer.CreateDate = entity.CreateDate;
                customer.Phone = entity.Phone;
                customer.Email = entity.Email;
                customer.Password = entity.Password;
                customer.Address = entity.Address;
                customer.Salutation = entity.Salutation;
                customer.City = entity.City;
                customer.Region = entity.Region;
                db.SaveChanges();
                return true;
            }catch(Exception)
            {
                return false;
            }

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
