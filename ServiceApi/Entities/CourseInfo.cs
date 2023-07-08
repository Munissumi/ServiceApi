namespace ServiceApi.Entities;

public class CourseInfo
{
    public Guid Id { get; set; }
    public string? CourseId { get; set; }
    public string? Title { get; set; }
    public string? ImagePath { get; set; }
    public string? Description { get; set; }
}
