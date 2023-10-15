public class TrainingDayExercise
{
    public int Id { get; set; }

    public int TrainingDayId { get; set; } // Foreign key to TrainingDay

    public TrainingDay? TrainingDay { get; set; }

    public int ExerciseId { get; set; } // Foreign key to Exercise

    public Exercise? Exercise { get; set; }

    public int Sets { get; set; }

    public int Reps { get; set; }

    public int RestInSeconds { get; set; }
}
