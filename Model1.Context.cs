//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalonApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbsalonEntities : DbContext
    {
        static dbsalonEntities _context;
        public static dbsalonEntities GetContext()
        { return (_context == null) ? _context = new dbsalonEntities() : _context; }
        public dbsalonEntities() : base("name=dbsalonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { throw new UnintentionalCodeFirstException(); }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Reception> Receptions { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
