//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
int Get(int num)
{
    int count=1;
    while (num>9)
    {
       // num=num/10;
        num/=10;
        count++;

    }
    return count;


}
int a=int.Parse(Console.ReadLine());
Console.WriteLine("количество элементов в числе :"+ Get(a));
