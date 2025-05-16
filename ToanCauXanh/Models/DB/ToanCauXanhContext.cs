using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToanCauXanh.Models.DB;

public partial class ToanCauXanhContext : DbContext
{
    public ToanCauXanhContext()
    {
    }

    public ToanCauXanhContext(DbContextOptions<ToanCauXanhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<CategoryCourse> CategoryCourses { get; set; }

    public virtual DbSet<CategoryNews> CategoryNews { get; set; }

    public virtual DbSet<ClientsSay> ClientsSays { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Content> Contents { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseDetail> CourseDetails { get; set; }

    public virtual DbSet<Faq> Faqs { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<Newsletter> Newsletters { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SlideShow> SlideShows { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=103.173.155.13,1433;Database=ToanCauXanh;User Id=toancauxanh;Password=toancauxanh@2025;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Fullname).HasMaxLength(200);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.Role).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Account_Role");
        });


        modelBuilder.Entity<CategoryCourse>(entity =>
        {
            entity.ToTable("CategoryCourse");

            entity.Property(e => e.CategoryCourseId).ValueGeneratedNever();
            entity.Property(e => e.CategoryCode).HasMaxLength(50);
            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Decription).HasMaxLength(1000);
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Keywords).HasMaxLength(500);
            entity.Property(e => e.Language).HasMaxLength(5);
            entity.Property(e => e.ThumbImage).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CategoryNews>(entity =>
        {
            entity.Property(e => e.CategoryCode).HasMaxLength(50);
            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Decription).HasMaxLength(1000);
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Keywords).HasMaxLength(500);
            entity.Property(e => e.Language).HasMaxLength(5);
            entity.Property(e => e.ThumbImage).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClientsSay>(entity =>
        {
            entity.HasKey(e => e.ClientSayId);

            entity.ToTable("ClientsSay");

            entity.Property(e => e.ContentImage)
                .HasMaxLength(500)
                .HasComment("HÌnh ảnh khách hàng đánh giá");
            entity.Property(e => e.Contents).HasMaxLength(1000);
            entity.Property(e => e.Fullname).HasMaxLength(100);
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Language).HasMaxLength(5);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasComment("Chức vụ");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("Contact");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Fullname).HasMaxLength(200);
            entity.Property(e => e.Message).HasMaxLength(2000);
            entity.Property(e => e.Project).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(1000);
        });

        modelBuilder.Entity<Content>(entity =>
        {
            entity.ToTable("Content");

            entity.Property(e => e.ContentCode).HasMaxLength(50);
            entity.Property(e => e.ContentName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Keyword).HasMaxLength(500);
            entity.Property(e => e.Language).HasMaxLength(5);
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");

            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.DateStart).HasColumnType("datetime");
            entity.Property(e => e.Decription).HasMaxLength(1000);
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.IsPrice).HasComment("Khóa học có tiền hay hiện nút tùy tâm");
            entity.Property(e => e.Keywords).HasMaxLength(500);
            entity.Property(e => e.Language).HasMaxLength(5);
            entity.Property(e => e.PricePromotion).HasComment("Hiển thị giá ảo");
            entity.Property(e => e.Tags).HasMaxLength(500);
            entity.Property(e => e.ThumbImage).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.Url).HasMaxLength(1000);

            entity.HasOne(d => d.CategoryCourse).WithMany(p => p.Courses)
                .HasForeignKey(d => d.CategoryCourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Course_CategoryCourse");
        });

        modelBuilder.Entity<CourseDetail>(entity =>
        {
            entity.ToTable("CourseDetail");

            entity.Property(e => e.Address).HasMaxLength(1000);
            entity.Property(e => e.DateRegister).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Fullname).HasMaxLength(500);
            entity.Property(e => e.Telephone).HasMaxLength(50);

            entity.HasOne(d => d.Course).WithMany(p => p.CourseDetails)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CourseDetail_Course");
        });


        modelBuilder.Entity<Faq>(entity =>
        {
            entity.ToTable("FAQ");

            entity.Property(e => e.Answer).HasMaxLength(2000);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Language).HasMaxLength(5);
            entity.Property(e => e.Question).HasMaxLength(2000);
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Decription).HasMaxLength(1000);
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Keywords).HasMaxLength(500);
            entity.Property(e => e.Language).HasMaxLength(5);
            entity.Property(e => e.PublicDate).HasColumnType("datetime");
            entity.Property(e => e.Tags).HasMaxLength(500);
            entity.Property(e => e.ThumbImage).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Url).HasMaxLength(1000);

            entity.HasOne(d => d.CategoryNews).WithMany(p => p.News)
                .HasForeignKey(d => d.CategoryNewsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_News_CategoryNews");
        });

        modelBuilder.Entity<Newsletter>(entity =>
        {
            entity.ToTable("Newsletter");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_Roles");

            entity.ToTable("Role");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.RoleValue).HasMaxLength(50);
        });

        modelBuilder.Entity<SlideShow>(entity =>
        {
            entity.HasKey(e => e.SildeId);

            entity.ToTable("SlideShow");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTo).HasColumnType("datetime");
            entity.Property(e => e.Image).HasMaxLength(1000);
            entity.Property(e => e.Language).HasMaxLength(5);
            entity.Property(e => e.SlideName).HasMaxLength(500);
            entity.Property(e => e.Target).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Url).HasMaxLength(1000);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
