// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*int AmountOfNumbersAboveZero (int amountOfNumbers) {
    var random = new Random();
    var numbersAboveZero = 0;

    Console.Write("Generated numbers are: ");
    for (var i = 1; i <= amountOfNumbers; i++) {
        var number = random.Next(-1000, 1000);
        if (number > 0) numbersAboveZero++;

        if (i == amountOfNumbers) Console.Write(number);
        else Console.Write($"{number}, ");
    }

    Console.WriteLine();

    return numbersAboveZero;
}

Console.Write("Write how many numbers you want to generate. Needs to be a positive number: ");
var input = Console.ReadLine();

if (Int32.TryParse(input, out var parsedInput) && parsedInput > 0) {
    var numbersAboveZero = AmountOfNumbersAboveZero(parsedInput);

    Console.WriteLine($"{numbersAboveZero} numbers is above 0");
}

else Console.WriteLine("Error! Input is not valid");
*/

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
string GetIntersectionpoint (int b1, int k1, int b2, int k2) {
    var leftSide = (double) (k2 - k1);
    var rightSide = (double) (b1 - b2);

    var x = rightSide / leftSide;
    var y = (double) (k2 * x + b2);

    return $"{x}, {y}";
}

Console.WriteLine("Get intersectionpoint of two rights: ");
Console.Write("Write b1: ");
var inputB1 = Console.ReadLine();
Console.Write("Write k1: ");
var inputK1 = Console.ReadLine();
Console.Write("Write b2: ");
var inputB2 = Console.ReadLine();
Console.Write("Write k2: ");
var inputK2 = Console.ReadLine();

if (Int32.TryParse(inputB1, out var parsedB1) && Int32.TryParse(inputK1, out var parsedK1) && Int32.TryParse(inputB2, out var parsedB2) && Int32.TryParse(inputK2, out var parsedK2)) {
    Console.WriteLine($"Intersection point is: {GetIntersectionpoint(parsedB1, parsedK1, parsedB2, parsedK2)}");
}