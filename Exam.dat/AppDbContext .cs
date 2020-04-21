using Microsoft.EntityFrameworkCore;


using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Exam.dat.DataModels;

namespace Exam.dat
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<DegreeTb> DegreeTb { get; set; }
        public virtual DbSet<Mistake> Mistake { get; set; }
        public virtual DbSet<Studentscore> Studentscore { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<TopicTypeTb> TopicTypeTb { get; set; }


        [System.Obsolete]
        public static readonly LoggerFactory MyLoggerFactory
            = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<DegreeTb>(entity =>
            {
                entity.HasIndex(e => e.Degree)
                    .HasName("IX_DegreeTb")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Degree)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Mistake>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer).HasMaxLength(1000);

                entity.Property(e => e.Calss).HasMaxLength(15);

                entity.Property(e => e.Misanswer).HasMaxLength(1000);

                entity.Property(e => e.Mistake1)
                    .HasColumnName("Mistake")
                    .HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(20);


            });

            modelBuilder.Entity<Studentscore>(entity =>
            {
                entity.ToTable("studentscore");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Class).HasMaxLength(15);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.ExamTime).HasMaxLength(200);


            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer1)
                    .IsRequired()
                    .HasColumnName("Answer1")
                    .HasMaxLength(1000);

                entity.Property(e => e.Answer2)
                    .IsRequired()
                    .HasColumnName("Answer2")
                    .HasMaxLength(1000);
                entity.Property(e => e.Answer3)
                    .IsRequired()
                    .HasColumnName("Answer3")
                    .HasMaxLength(1000);
                entity.Property(e => e.Answer4)
                    .IsRequired()
                    .HasColumnName("answer4")
                    .HasMaxLength(1000);

                entity.Property(e => e.Degree)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Kind)
                    .IsRequired()
                    .HasColumnName("kind")
                    .HasMaxLength(100);

                entity.Property(e => e.OptionFour)
                    .IsRequired()
                    .HasColumnName("optionFOUR")
                    .HasMaxLength(1000);

                entity.Property(e => e.OptionOne)
                    .IsRequired()
                    .HasColumnName("optionONE")
                    .HasMaxLength(1000);

                entity.Property(e => e.OptionThree)
                    .IsRequired()
                    .HasColumnName("optionTHREE")
                    .HasMaxLength(1000);

                entity.Property(e => e.OptionTow)
                    .IsRequired()
                    .HasColumnName("optionTOW")
                    .HasMaxLength(1000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(4000);

               
            });

            modelBuilder.Entity<TopicTypeTb>(entity =>
            {
                entity.HasIndex(e => e.TopicType)
                    .HasName("IX_TopicTypeTb")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TopicType)
                    .IsRequired()
                    .HasMaxLength(100);
            });


            modelBuilder.Entity<DegreeTb>().HasData(new DegreeTb { Id = 1, Degree = "初等" }, new DegreeTb { Id = 2, Degree = "中等" }, new DegreeTb { Id = 3, Degree = "高等" });
            modelBuilder.Entity<TopicTypeTb>().HasData(new TopicTypeTb { Id = 1, TopicType = "C#" }, new TopicTypeTb { Id = 2, TopicType = "JavaScreipt" }, new TopicTypeTb { Id = 3, TopicType = "ASP.NET" });
        }
    }
}
