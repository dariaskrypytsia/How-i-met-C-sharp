Course familyBusinessManagment = new Course("Family business managment", 2);

Student michael = new Student("Michael Carleone");
Student sonny = new Student("Sonny Carleone");
Student fredo = new Student("Fredo Carleone");

familyBusinessManagment.Enroll(michael);
familyBusinessManagment.Enroll(sonny);
familyBusinessManagment.Enroll(fredo); // no place left for Fredo

familyBusinessManagment.Enroll(michael); //already in

Console.WriteLine($":Michael's courses count: {michael.Courses.Count}"); 
Console.WriteLine($"Family business students count: {familyBusinessManagment.Students.Count}"); 
