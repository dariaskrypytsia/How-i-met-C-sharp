public class Student
{
    public string Name;
    public List<Course> Courses = [];

    public Student(string name)
    {
        Name = name;
    }
    public void Join(Course course)
{
    if (!Courses.Contains(course))
        {
             Courses.Add(course);
        course.Enroll(this);
        }
    
}
     public void Leave(Course course)
    {
        if (Courses.Contains(course))
        {
            Courses.Remove(course);
        course.Remove(this);
        }
    
    }

}