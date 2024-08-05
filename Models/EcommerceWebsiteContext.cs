using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EcommerceWebsite.Models
{
    public partial class EcommerceWebsiteContext : DbContext
    {
        public EcommerceWebsiteContext()
        {
        }

        public EcommerceWebsiteContext(DbContextOptions<EcommerceWebsiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CartItem> CartItems { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Color> Colors { get; set; } = null!;
        public virtual DbSet<Discount> Discounts { get; set; } = null!;
        public virtual DbSet<Offer> Offers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderItem> OrderItems { get; set; } = null!;
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; } = null!;
        public virtual DbSet<Size> Sizes { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<SubCategory> SubCategories { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CartNavigation)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.Cart)
                    .HasConstraintName("FK__CartItems__Cart__72C60C4A");

                entity.HasOne(d => d.CartProductNavigation)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.CartProduct)
                    .HasConstraintName("FK__CartItems__CartP__73BA3083");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoryStatusNavigation)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.CategoryStatus)
                    .HasConstraintName("FK__Categorie__Categ__5165187F");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("colors");

                entity.Property(e => e.Color1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Color");

                entity.HasOne(d => d.ColorStatusNavigation)
                    .WithMany(p => p.Colors)
                    .HasForeignKey(d => d.ColorStatus)
                    .HasConstraintName("FK__colors__ColorSta__5812160E");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.DiscountCode).HasMaxLength(50);

                entity.Property(e => e.DiscountType).HasMaxLength(10);

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.DiscountStatusNavigation)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.DiscountStatus)
                    .HasConstraintName("FK__Discounts__Disco__66603565");
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.Property(e => e.Offer1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Offer");

                entity.Property(e => e.OfferEndDate).HasColumnType("date");

                entity.Property(e => e.OfferStartDate).HasColumnType("date");

                entity.HasOne(d => d.OfferStatusNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.OfferStatus)
                    .HasConstraintName("FK__Offers__OfferSta__628FA481");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Customer)
                    .HasConstraintName("FK__Orders__Customer__04E4BC85");

                entity.HasOne(d => d.OrderStatusNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatus)
                    .HasConstraintName("FK__Orders__OrderSta__06CD04F7");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderItem__Order__09A971A2");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.Product)
                    .HasConstraintName("FK__OrderItem__Produ__0A9D95DB");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.Property(e => e.OrderStatus1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OrderStatus");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductDescription).IsUnicode(false);

                entity.Property(e => e.ProductImage).IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductColorNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductColor)
                    .HasConstraintName("FK__Products__Produc__5EBF139D");

                entity.HasOne(d => d.ProductSizeNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductSize)
                    .HasConstraintName("FK__Products__Produc__5FB337D6");

                entity.HasOne(d => d.ProductStatusNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductStatus)
                    .HasConstraintName("FK__Products__Produc__5DCAEF64");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.Review1)
                    .IsUnicode(false)
                    .HasColumnName("Review");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.Customer)
                    .HasConstraintName("FK__Reviews__Custome__0E6E26BF");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.Product)
                    .HasConstraintName("FK__Reviews__Product__0D7A0286");
            });

            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK__Shopping__51BCD7B7FDC3C9A6");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CartUserNavigation)
                    .WithMany(p => p.ShoppingCarts)
                    .HasForeignKey(d => d.CartUser)
                    .HasConstraintName("FK__ShoppingC__CartU__6EF57B66");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.Property(e => e.Size1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Size");

                entity.HasOne(d => d.SizeStatusNavigation)
                    .WithMany(p => p.Sizes)
                    .HasForeignKey(d => d.SizeStatus)
                    .HasConstraintName("FK__Sizes__SizeStatu__5AEE82B9");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("statuses");

                entity.Property(e => e.Status1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Status");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.Property(e => e.SubCategoryName)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK__SubCatego__Categ__5441852A");

                entity.HasOne(d => d.SubCategoryStatusNavigation)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.SubCategoryStatus)
                    .HasConstraintName("FK__SubCatego__SubCa__5535A963");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.ProfileName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePic).IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRole)
                    .HasConstraintName("FK__Users__UserRole__4D94879B");

                entity.HasOne(d => d.UserStatusNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserStatus)
                    .HasConstraintName("FK__Users__UserStatu__4E88ABD4");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__UserRole__8AFACE1A01885F70");

                entity.Property(e => e.UserRole1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UserRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
