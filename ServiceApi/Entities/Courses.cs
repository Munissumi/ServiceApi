namespace ServiceApi.Entities;

public class Courses
{
    public virtual ICollection<Course> MyCourses { get; set; }
}
