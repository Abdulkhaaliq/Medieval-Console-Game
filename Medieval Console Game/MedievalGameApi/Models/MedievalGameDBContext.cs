using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MedievalGameApi.Models
{
    public partial class MedievalGameDBContext : DbContext
    {
        public MedievalGameDBContext()
        {
        }

        public MedievalGameDBContext(DbContextOptions<MedievalGameDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Enemy> Enemies { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Player1> Player1s { get; set; }
        public virtual DbSet<PlayerEnemy> PlayerEnemies { get; set; }
        public virtual DbSet<PlayerItem> PlayerItems { get; set; }
        public virtual DbSet<PlayerJob> PlayerJobs { get; set; }
        public virtual DbSet<PlayerSkill> PlayerSkills { get; set; }
        public virtual DbSet<PlayerWallet> PlayerWallets { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-R5TUG1FC\\SQLEXPRESS;Database=MedievalGameDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Enemy>(entity =>
            {
                entity.Property(e => e.EnemyDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnemyName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.DateJoined).HasColumnType("datetime");

                entity.Property(e => e.DateTerminated).HasColumnType("datetime");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Player1>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("Player1");

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerEnemy>(entity =>
            {
                entity.HasKey(e => e.LinkPlayerEnemy);

                entity.ToTable("PlayerEnemy");

                entity.HasOne(d => d.Enemy)
                    .WithMany(p => p.PlayerEnemies)
                    .HasForeignKey(d => d.EnemyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayerEnemy_Enemies");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerEnemies)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayerEnemy_Player1");
            });

            modelBuilder.Entity<PlayerItem>(entity =>
            {
                entity.HasKey(e => e.LinkPlayerItemId);

                entity.ToTable("PlayerItem");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PlayerItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayerItem_Items");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerItems)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayerItem_Player1");
            });

            modelBuilder.Entity<PlayerJob>(entity =>
            {
                entity.HasKey(e => e.LinkPlayerJobId);

                entity.ToTable("PlayerJob");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.PlayerJobs)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayerJob_Jobs");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerJobs)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayerJob_Player1");
            });

            modelBuilder.Entity<PlayerSkill>(entity =>
            {
                entity.HasKey(e => e.LinkPlayerSkillId);

                entity.ToTable("PlayerSkill");

                entity.Property(e => e.LinkPlayerSkillId).HasColumnName("LinkPlayerSkill_Id");

                entity.Property(e => e.SkillId).HasColumnName("Skill_Id");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerSkills)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayerSkill_Player1");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.PlayerSkills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayerSkill_Skills");
            });

            modelBuilder.Entity<PlayerWallet>(entity =>
            {
                entity.HasKey(e => e.WalletId);

                entity.ToTable("PlayerWallet");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerWallets)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayerWallet_Player1");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.SkillId).HasColumnName("Skill_Id");

                entity.Property(e => e.SkillDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
