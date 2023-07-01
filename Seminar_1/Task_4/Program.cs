// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите первое число: ");
string? numberOne = Console.ReadLine();
int number1 = Convert.ToInt32(numberOne);
Console.Write("Введите второе число: ");
string? numberTwo = Console.ReadLine();
int number2 = Convert.ToInt32(numberTwo);
Console.Write("Введите третье число: ");
string? numberThree = Console.ReadLine();
int number3 = Convert.ToInt32(numberThree);
if (number1 > number2)
    {
       if (number1 > number3)
            {
                Console.Write("Максимальное число: ");
                Console.WriteLine(number1);
            }
    }   
else       
    if (number3 > number2)
       {
            Console.Write("Максимальное число: ");
            Console.WriteLine(number3);
       }  
    else
       {
            Console.Write("Максимальное число: ");
            Console.WriteLine(number2);
       }  
if (number1 == number2)
    {
        if (number2 == number3)
            {
                Console.WriteLine("Все числа равны между собой");
            }    
    }
