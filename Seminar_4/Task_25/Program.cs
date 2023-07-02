// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A 
//            в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt()
{
Console.Write("Введите число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

int AvStepenyB(int A, int B)
{
int stepen = 1;    
for (int i=0; i < B; i++)
{
stepen *= A;
}
return stepen;
}

bool Proverka(int B)
{
    if (B<1)
    {
    Console.Write($"Число {B} должно быть больше нуля");
    return false;
    }
return true;
}

int A = ReadInt();
int B = ReadInt();
if (Proverka(B))
{
Console.Write($"Число {A} в степени {B} равно: {AvStepenyB(A, B)}");
}

