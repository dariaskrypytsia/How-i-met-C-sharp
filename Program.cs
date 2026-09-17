Course familyBusinessManagment = new Course("Family business managment", 2);

Student michael = new Student("Michael Carleone");
Student sonny = new Student("Sonny Carleone");
Student fredo = new Student("Fredo Carleone");

familyBusinessManagment.Enroll(michael);
familyBusinessManagment.Enroll(sonny);
familyBusinessManagment.Enroll(fredo); // no place left for Fredo

familyBusinessManagment.Enroll(michael); //already in

Console.WriteLine($":Michael's courses count: {michael.Courses.Count}"); 
Console.WriteLine($"Family business managment students count: {familyBusinessManagment.Students.Count}"); 

familyBusinessManagment.Remove(sonny);
Console.WriteLine($"Sonny's courses after leaving: {sonny.Courses.Count}");

familyBusinessManagment.Remove(sonny); 

// now there's room, so Fredo can join
familyBusinessManagment.Enroll(fredo);
Console.WriteLine($"Family business managment students count after Fredo joined: {familyBusinessManagment.Students.Count}");


familyBusinessManagment.RollCall();
fredo.Schedule();
Console.WriteLine(familyBusinessManagment);
Console.WriteLine(fredo); 

Console.WriteLine("\n--- Testing Join from the student's side ---");
Course weddingPlanning = new Course("Wedding Planning", 1);
Student vito = new Student("Vito Corleone");

vito.Join(weddingPlanning); // enrolling FROM the student's side this time

weddingPlanning.RollCall(); 
vito.Schedule();  