// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputN(string message)
{
System.Console.Write($"{message}> ");
int value;
if (int.TryParse(Console.ReadLine(), out value))
{
return value;
}
System.Console.WriteLine("Вы ввели не число");
Environment.Exit(1);
return 0;

}

int x1 = InputN ("Введите координату X первой точки A");
int y1 = InputN ("Введите координату Y первой точки A");
int z1 = InputN ("Введите координату Z первой точки A");
int x2 = InputN ("Введите координату X второй точки B");
int y2 = InputN ("Введите координату Y второй точки B");
int z2 = InputN ("Введите координату Z второй точки B");

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int deltax = x2 — x1;
int deltay = y2 — y1;
int deltaz = z2 — z1;
return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
}
System.Console.Write($"Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2} ");