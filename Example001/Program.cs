Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
int n=a;
for (int i=1;i<b;i++)
{
    n = n*a;
}
 Console.WriteLine(n);

