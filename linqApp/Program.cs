
static void printQuery(string title, List<Person> persons)
{
    Console.WriteLine($"\n{title}");
    foreach (var person in persons)
    {
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Salary: {person.Salary}");
    }
    Console.WriteLine();
}

List<Person> persons = new List<Person>();

while (true){
    bool is_age_valid = false, is_salary_valid = false;
    int age = 0;
    decimal salary = 0;
    Console.WriteLine("\nEnter person details or type 'exit' to finish:");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    if (name.ToLower() == "exit") break;

    while(!is_age_valid)
    {
        Console.Write($"Enter {name}'s age (integer): ");
        string s_age = Console.ReadLine();
        if(s_age.ToLower() == "exit") break;
        try
        {
            age = int.Parse(s_age);
            is_age_valid = true;
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid age. Please enter a valid number (integer).");
        }
    }
    
    while(!is_salary_valid)
    {
        Console.Write($"Enter {name}'s annual salary (decimal): ");
        string s_salary = Console.ReadLine();
        if(s_salary.ToLower() == "exit") break;
        try{
            salary = decimal.Parse(s_salary);
            is_salary_valid = true;
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid salary. Please enter a valid number (decimal).");
        }
    }
    
    persons.Add(new Person(name, age, salary));
}

// Perform LINQ queries on the collection
Console.WriteLine("\nLINQ Queries:");

// Query 1: Filter based on age greater than 30
var filter1 = persons.Where(p => p.Age > 30).ToList();
printQuery("Persons with age greater than 30:", filter1);

// Query 2: Filter based on age less than 30
var filter2 = persons.Where(p => p.Age <= 30).ToList();
printQuery("Persons with age less than 30:", filter2);

// Query 3: Sort by name
var sorted_persons = persons.OrderBy(p => p.Name).ToList();
printQuery("List of persons arranged by Name in alphabetic order:", sorted_persons);

// Query 4: Sort by Age
var sorted_persons2 = persons.OrderBy(p => p.Age).ToList();
printQuery("List of persons arranged by Age:", sorted_persons2);

//Query 5: Sort by Salary (DESC)
var sorted_persons3 = persons.OrderByDescending(p => p.Salary).ToList();
printQuery("List of persons arranged by Salary(DESC):", sorted_persons3);

// Query 6: Calculate Total Salary
var total_salary = persons.Sum(p => p.Salary);
Console.WriteLine($"Total Salary: {total_salary}");

// Query 7: Calculate average salary
var mean_salary = persons.Average(p => p.Salary);
Console.WriteLine($"Average Salary: {mean_salary:C}");

// Query 8: Calculate total age
var total_age = persons.Sum(p => p.Age);
Console.WriteLine($"Total age: {total_age}");

//Query 9: Average age
var mean_age = persons.Average(p => p.Age);
Console.WriteLine($"Average Age {mean_age}");
