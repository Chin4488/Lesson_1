// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
int Max;
if (FirstNumber > SecondNumber) {
    Max = FirstNumber;
} else {
    Max = SecondNumber;
}
Console.WriteLine($"Максимальное число равно {Max}");