// List<int> numbers = new List<int>();


List<int> numbers = 
    new List<int> { 2, 5, 6, 8 };

foreach(int elem in numbers){
    Console.WriteLine($"elem: {elem}");
}


numbers.Add(9);