using Microsoft.EntityFrameworkCore;

public class TrainingDB : DbContext
{
    public TrainingDB(DbContextOptions options) : base(options) { }

    public DbSet<TrainingProgram> TrainingPrograms { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<TrainingDay> TrainingDays { get; set; }
    public DbSet<TrainingDayExercise> TrainingDayExercises { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TrainingDayExercise>()
            .HasOne(tde => tde.Exercise)
            ;

        modelBuilder.Entity<TrainingDayExercise>()
            .HasOne(tde => tde.TrainingDay)
            .WithMany(td => td.TrainingDayExercises);

        // Additional configuration as needed.

        base.OnModelCreating(modelBuilder);
    }
}
