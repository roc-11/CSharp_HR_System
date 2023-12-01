using HRSystem;

Console.WriteLine("HR System \n");

Console.WriteLine("============Teachers List================");

// Polymorphism - 2 different objects behave as if they're the same
// It works if there's a common interface

List<ITeacher> teachers = new List<ITeacher>
{ 
    new Trainer("Eve", "Evans", "E33333"),
    new Tutor("Fred", "Flintstone", "E45672"),
    new Trainer("Ger", "Fogarty", "E54982"),
};

foreach(ITeacher teacher in teachers)
{
    teacher.Teach();

    // convert the Teacher to a Person Object, and call the Display() method
    ((Person)teacher).Display();
}

Console.WriteLine("===============Teachers==============");

Trainer trainer = new Trainer("Eve", "Evans", "E33333");
trainer.Teach();

Tutor tutor = new Tutor("Fred", "Flintstone", "E45672");
tutor.Teach();

Console.WriteLine("===============Person Class 1================");

Person p = new Person("Alice", "Adams");
p.Display();

Employee e = new Employee("Bob", "Byrne", "E12345");
e.Display();

Contractor c = new Contractor("John", "Keane", "Deloitte");
c.Display();

Manager m = new Manager("Danielle", "Doyle", "E67892", 52);
m.Display();

Console.WriteLine("===============Person Array================");

// Create an array of Person Objects
// They have a common base class so, inheritance allows this Person loop to run
Person[] team =
{
    new Person("Donnacha", "McDonagh"),
    new Employee("Robert", "Jones", "E67897"),
    new Contractor("Dave", "Madden", "PWC"),
    new Manager("Dan", "Cummins", "E56432", 52)
};

foreach(Person person in team)
{
    person.Display();
}


Console.WriteLine("==============Person List===============");

List<Person> teamList = new List<Person>
{
    new Person("Donnacha", "McDonagh"),
    new Employee("Robert", "Jones", "E67897"),
    new Contractor("Dave", "Madden", "PWC"),
    new Manager("Dan", "Cummins", "E56432", 52)
};

foreach (Person person in teamList)
{
    person.Display();
}

