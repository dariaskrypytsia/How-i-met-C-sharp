public class Course
{
    public string Name;
    public int MaxSeats;
    public List<Student> Students = [];

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }
   public void Enroll(Student student)
{
    // dont add the same student twice
    if (Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} is already in {Name}");
        return; 
        }

    if (Students.Count >= MaxSeats)
        {
             Console.WriteLine($"{Name} is full");
        return;
        }

    Students.Add(student);
    student.Join(this); 
}
public void Remove(Student student)
{
    if (!Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} is not enrolled in {Name}");
        return;
        }
    

    Students.Remove(student);
    student.Leave(this);
}
}
