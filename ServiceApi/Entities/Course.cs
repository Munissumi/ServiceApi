namespace ServiceApi.Entities;

public class Course
{
    public Guid Id { get; set; }
    public string? CourseName { get; set; }
    public string? Description { get; set; }
    public string? StartDate { get; set;}
    public string? EndDate { get; set;}
    public List<CourseInfo>? CourseInfos { get; set; }
    public string? Price { get;}
    public int? Students { get; set; }

}
