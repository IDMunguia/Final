using System;

while (true)
{
    Console.WriteLine("Enter date:");
    string inputDate = Console.ReadLine();
    var todayDate = DateTime.Today;
    if (DateTime.TryParse(inputDate, out DateTime dateOfBirth))
    {
        var age = todayDate - dateOfBirth;
        Console.WriteLine($"You are {age} days old.");  
    }
    else
    {
        Console.WriteLine("Bad date. Please enter it MM/DD/YYYY format.");
    }
}
