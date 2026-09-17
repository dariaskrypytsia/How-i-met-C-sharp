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
public void Schedule()
    {
        Console.WriteLine($"{Name}'s courses:");
    foreach (Course course in Courses)
        {
            Console.WriteLine($"- {course.Name}");
        }
    
    }


public override string ToString()
    {
        return Name;
    }


}