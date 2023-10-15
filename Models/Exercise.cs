using System.ComponentModel.DataAnnotations;

public class Exercise
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
}
