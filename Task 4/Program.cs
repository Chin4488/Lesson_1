// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int ThreeNumber = Convert.ToInt32(Console.ReadLine());
int Max = FirstNumber;
if (Max < SecondNumber) {
    Max = SecondNumber;
}
if (Max < ThreeNumber) {
    Max = ThreeNumber;
} 
Console.WriteLine($"Максимальное число = {Max}");