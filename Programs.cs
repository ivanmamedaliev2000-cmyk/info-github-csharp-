class Program 
{ 
static void Main() 
{ 
Console.Write("Как тебя зовут? "); 
string name = Console.ReadLine() ?? ""; 
if (string.IsNullOrWhiteSpace(name)) 
{ 
Console.WriteLine("Имя не введено."); 
} 
else 
{ 
Console.WriteLine("Привет, " + name + "!"); 
} 
} 
} 
