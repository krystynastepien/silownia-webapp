using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppSilownia.Models
{
    public partial class ClassFitBit : DbContext
    {
        public ClassFitBit()
        {
        }

        public ClassFitBit(DbContextOptions<DB_FitBitContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=laptop-phb962he\\onpro;Database=DB_FitBit;Trusted_Connection=True;");
        //            }
        //        }
        // ZAMIENIAM TO NA FRAGMENT PONIŻEJ
        public partial class DB_FitBitContext : DbContext
        {
            public DB_FitBitContext(DbContextOptions<DB_FitBitContext> options)
                : base(options)
            { }
        }
        /// //// ///////////////////////////////////////////////////////////////
           
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("PK__USERS__B502103256A3DE5A");

                entity.ToTable("USERS");

                entity.Property(e => e.UId).HasColumnName("u_Id");

                entity.Property(e => e.UEmail)
                    .IsRequired()
                    .HasColumnName("u_Email")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ULastName)
                    .IsRequired()
                    .HasColumnName("u_LastName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UName)
                    .IsRequired()
                    .HasColumnName("u_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .IsRequired()
                    .HasColumnName("u_Password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UUsername)
                    .IsRequired()
                    .HasColumnName("u_Username")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
