using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCLOGIN.DbEF
{
    public partial class ProjectDbContext : DbContext
    {
        public ProjectDbContext()
            : base("name=ProjectDbContext")
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentTag> ContentTags { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuType> MenuTypes { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderT> OrderTs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>()
                .Property(e => e.AboutMetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.AboutCreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.AboutModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.AboutMetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryMetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryCreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryMetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Content>()
                .Property(e => e.ContentMetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<ContentTag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Footer>()
                .Property(e => e.FooterID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderT>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.PromotionPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductMetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductCreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductMetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.ProductCategoryMetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.ProductCategoryCreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.ProductCategoryModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.ProductCategoryMetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.SlideCreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.SlideModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.SystemConfigID)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.TagName)
                .IsUnicode(false);
        }
    }
}
