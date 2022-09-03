// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. (для получения цифр числа операцию приведения числа к строке не использовать)
// 452 -> 6
// 82 -> 2
// 9012 -> 3
// 23 -> 0
Console.WriteLine("Введите число num:");
int num = Convert.ToInt32(Console.ReadLine());
int tmp=num;
int count=0;
//нашли количество цифр в числе
while (tmp != 0)
{
    tmp = tmp/10;
    count++;
}
// создали массив 
int[] a= new int[count];
// нашли чему равно каждое число
tmp=num;
int sum=0;
for (int i=0;i<tmp;i++)
{    
    a[i]=tmp%10;
    if (a[i]!=0) 
      {if (num%a[i]==0)
       {
       sum=sum+(a[i]);
    } }
    tmp = tmp/10;   
}
Console.WriteLine(sum);