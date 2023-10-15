using System.ComponentModel.DataAnnotations;

public class TrainingProgram
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public List<TrainingDay>? TrainingDays { get; set; }
}

