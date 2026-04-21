using Microsoft.EntityFrameworkCore;
using SOBUFigure.Models;

namespace SOBUFigure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Figure> Figures { get; set; }
    
    public DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Dinh nghia cac attr trong model tuong ung cot nao trong db
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("category");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.ToTable("admin");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("brand");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Country).HasColumnName("country");
        });
        
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("customer");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Address).HasColumnName("address");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("orders");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<Figure>(entity =>
        {
            entity.ToTable("figure");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Scale).HasColumnName("scale");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.ToTable("order_detail");
            entity.HasKey(e => new { e.OrderId, e.FigureId });
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.FigureId).HasColumnName("figure_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity"); 
            entity.Property(e => e.UnitPrice).HasColumnName("Unit_price");
        });
    }
}