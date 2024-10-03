using Dicta_Sanctorum.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Dicta_Sanctorum.Entity
{
    public class EntityContext:DbContext
    {
        public DbSet<SaintModel> Saints { get; set; }
        public DbSet<PhraseModel> Phrases { get; set; }
        public string DbPath { get; }

        public EntityContext(DbContextOptions<EntityContext> options):base(options)
        {
            var folder = Environment.Sp
            var path = Environment.GetFolderPath(folder);
            Console.WriteLine(path);
            DbPath = Path.Join(path,$"dicta_sanctorum.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaintModel>(md => {
            md.ToTable("Saints");
                md.HasKey(s => s.id);
                md.Property(s => s.id).ValueGeneratedOnAdd();
                md.Property(s => s.name).IsRequired();
                md.Property(s => s.bio).IsRequired();
                md.Property(s => s.feastDay).IsRequired();
                md.Property(s => s.birthYear);
                md.Property(s => s.deathYear);
                md.Property(s => s.canonizationYear);
                md.Property(s => s.image).IsRequired();
                md.Property(s => s.nationality).IsRequired();
                md.Property(s => s.prayer);
                
            });

            modelBuilder.Entity<PhraseModel>(md => {
                md.ToTable("Phrases");
                md.HasKey(p => p.id);
                md.Property(p => p.id).ValueGeneratedOnAdd();
                md.Property(p => p.idSaint).IsRequired();
                md.Property(p => p.phrase).IsRequired();
                md.HasOne(p => p.Saint)
                    .WithMany(s => s.Phrases)
                    .HasForeignKey(p => p.idSaint);
            });
        }

    }
}
