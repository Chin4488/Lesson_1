// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number%2 > 0) {
    Console.WriteLine("Введенное число нечетное");
}   else Console.WriteLine("Введенное число четное");