Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("---- Um Dois Três Pim ----");
Console.ResetColor();

for (int n = 1; n <= 40; n++)
 if ( n % 4 == 0)
 {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("pim\n");
    Console.ResetColor();
 }

 else
 {
    Console.ForegroundColor = ConsoleColor.White;
    System.Console.Write($"{n,2} ");
    Console.ResetColor();
 }