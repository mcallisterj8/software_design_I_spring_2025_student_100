
List<int> numbers = 
    new List<int> { 2, 5, 6, 8 };

numbers.Add(9);

foreach(int elem in numbers){
    Console.WriteLine($"elem: {elem}");
    
}
