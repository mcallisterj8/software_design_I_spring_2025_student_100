using System.Text.Json;

/**************************************
    READING FROM TEXT FILE
**************************************/
string filePath = "./lorem_ipsum.txt";
string fileContents = File.ReadAllText(filePath);

// Console.WriteLine("\n");
// Console.WriteLine($"File Contents:\n\n{fileContents}");
// Console.WriteLine("\n");

/**************************************
    WRITING TO TEXT FILE
**************************************/
string pathToFile = $"{Directory.GetCurrentDirectory()}/hello.txt";
string content = "Hello, World!";
File.WriteAllText(pathToFile, content);

// Console.WriteLine("\n\n");
// Console.WriteLine($"{Directory.GetCurrentDirectory()}");
// Console.WriteLine("\n\n");

string moreContent = "\nThe sun is out!";
File.AppendAllText(pathToFile, moreContent);

/**************************************
    FORMAT WRITING TO TEXT FILE
**************************************/
string pathToFormatFile = "./format.txt";
string title = "Example Title";
int number = 80;

string formatContent = 
        @$"{title}
=================
Non-indented sentence.
    Indented sentence with the number {number}!";

File.WriteAllText(pathToFormatFile, formatContent);


/**************************************
    READING FROM JSON
**************************************/
string jsonFilePath = "./company_info.json";
string json = File.ReadAllText(jsonFilePath);

// JSON.parse();
Company? companyA 
    = JsonSerializer.Deserialize<Company>(json);

Employee singleEmployee = companyA.Employees[0];

Console.WriteLine("\n");
Console.WriteLine($"Single Employee BEFORE:\n\n{singleEmployee.FullName} | Position: {singleEmployee.Position.Description}");
Console.WriteLine("\n");

singleEmployee.Position.Description = "Software Engineer";

Console.WriteLine("\n");
Console.WriteLine($"Single Employee AFTER:\n\n{singleEmployee.FullName} | Position: {singleEmployee.Position.Description}");
Console.WriteLine("\n");

// Options to format the JSON file
var options = new JsonSerializerOptions { WriteIndented = true };

// Serialize / stringify the company object back to JSON
string updatedJson = JsonSerializer.Serialize(companyA, options);

// Write the JSON back out to the file
File.WriteAllText(jsonFilePath, updatedJson);







