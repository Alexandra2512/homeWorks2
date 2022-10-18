// Задание 1.Напишите программу, которая на вход принимает число и выдает его квадрат(число умноженное само на себя).

//**Например:**

//4 -> 16
//-3 -> 9
//-7 -> 49
/*
Console.WriteLine($"Input number")C;
int num = Convert.ToInt32(Console.ReadLine());
int result =num * num;
Console.WriteLine($"Quad of num {num} is -> {result}");
*/


// Задание 1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.WriteLine($"Введите первое число:");
 int a =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе число");

int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
 Console.WriteLine($"первое число"+ a +"больше чем второе"+ b);   
}
else
{
Console.WriteLine($"второе число"+ b +"больше чем первое"+ a);   
} 

Console.WriteLine( a>b ? "первое число больше второго":"Второе число больше первого");
  


  ///Задание 2.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine($"Вести 3 числа:");
int num_1= Convert.ToInt32(Console.ReadLine());
int num_2 =Convert.ToInt32(Console.ReadLine());
int num_3 =Convert.ToInt32(Console.ReadLine());

int max= num_1; 
{
if(num_2 > max)

 max= num_2;
}
if (num_3 > max)
{
    max= num_3;
}
Console.WriteLine($"Наибольшее из введенных чисел ->"+ max);


//Задание 3.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine($"Вести число:");
 int num = Convert.ToInt32(Console.ReadLine());
if ( num %2 ==1 )
{
Console.WriteLine($"Число"+ num + "нечетное число");
}
else
{
  Console.WriteLine($"Число"+ num + "  четное число");
}


//8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

 
 Console.WriteLine($"Вести число:");
 int i = 1;
bool not = true;
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа от 1 до"+ num);
while (i <= num)
{
    if ( i % 2 !=1)
    {
Console.WriteLine( i + "число" );
not = false;
    }
    i++;
}
if (not)
{
  Console.WriteLine($"Четных чисел нет");
}















