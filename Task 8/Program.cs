// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите целое число больше 1");
int Number = Convert.ToInt32(Console.ReadLine());
int EvenNumber = 2;
while (EvenNumber <= Number) {
    Console.Write($"{EvenNumber}   ");
    EvenNumber = EvenNumber + 2;
}
