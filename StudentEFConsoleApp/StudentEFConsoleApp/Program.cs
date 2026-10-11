using StudentEFConsoleApp;

using var db = new StudentDbContext();

//ask the user to input first name
Console.Write("Enter first name: ");
string? firstName = Console.ReadLine();

//trim the input and check if it's null or whitespace
if (string.IsNullOrWhiteSpace(firstName))
{
    Console.WriteLine("First name is required.");
    return;
}

//ask the user to input last name
Console.Write("Enter last name: ");
string? lastName = Console.ReadLine();

//trim the input and check if it's null or whitespace
if (string.IsNullOrWhiteSpace(lastName))
{
    Console.WriteLine("Last name is required.");
    return;
}

//ask the user to input email
Console.Write("Enter email: ");
string? email = Console.ReadLine();

//ask the user to input age and check if it's a valid integer greater than 0
Console.Write("Enter age: ");
if (!int.TryParse(Console.ReadLine(), out int age) || age <= 0)
{
    Console.WriteLine("Please enter a valid age.");
    return;
}

var student = new Student
{
    Id = Guid.NewGuid(),
    FirstName = firstName.Trim(),
    LastName = lastName.Trim(),
    Email = email ?? string.Empty,
    Age = age
};

db.Students.Add(student);
db.SaveChanges();

Console.WriteLine("\nStudent added successfully!");
Console.WriteLine($"ID: {student.Id}");
Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
Console.WriteLine($"Email: {student.Email}");
Console.WriteLine($"Age: {student.Age}");