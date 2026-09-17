Course familyBusinessManagment = new Course("Family business managmentk", 2);

Student michael = new Student("Michael Carleone");
Student sonny = new Student("Sonny Carleone");
Student fredo = new Student("Fredo Carleone");

familyBusinessManagment.Enroll(michael);
familyBusinessManagment.Enroll(sonny);
familyBusinessManagment.Enroll(fredo); // no place left for Fredo

familyBusinessManagment.Enroll(michael); //already in

Console.WriteLine($"Anna's courses count: {michael.Courses.Count}"); 
Console.WriteLine($"Math students count: {familyBusinessManagment.Students.Count}"); 
