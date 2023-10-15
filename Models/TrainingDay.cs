public class TrainingDay
{
    public int Id { get; set; }

    public int TrainingProgramId { get; set; } // Foreign key to TrainingProgram

    public TrainingProgram? TrainingProgram { get; set; }

    public List<TrainingDayExercise>? TrainingDayExercises { get; set; }
}
