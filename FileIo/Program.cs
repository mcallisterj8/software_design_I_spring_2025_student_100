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
string pathToFile = "./hello.txt";
string content = "Hello, World!";
File.WriteAllText(pathToFile, content);

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
Console.WriteLine($"Company:\n\n{JsonSerializer.Serialize(companyA)}");
Console.WriteLine("\n");








