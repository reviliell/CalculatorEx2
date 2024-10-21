
using System.ComponentModel.Design;

class MyClass
{
    static void Main(string[] myArrInts)
    {
        int exit = 0;
        do
        {
            
            Console.Write("Введите операцию (сложение-1,вычитание-2,умножение-3,деление-4):");
            int OperationNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            //Если номер 1-6 или 8, то выполнить ввод еще одного числа b
            
            //object[] nums1 = {1, 2, 3, 4, 5, 6, 8};
            if ((OperationNumber = 1|2|3|4|5|6|7|8) != 0) 
            {
                Console.Write("Введите число 2:");
                int b = Convert.ToInt32(Console.ReadLine());
            }
            else if ((OperationNumber = 9|10) != 0)
            {
                Console.Write("Введите число 3:");
                int b = Convert.ToInt32(Console.ReadLine());
            }
            
            var object1 = new Operation1();

            switch (OperationNumber)
            {
                case 1:
                    //сложение
                    int[] myArr1 = new int [2];
                    int[] result1 = object1.myArrv(myArr1);
                    int result3 = myArr1[0] + myArr1[1];
                    Console.WriteLine(result3);
                    break;
                case 2:
                    //вычитание
                    int[] myArr2 = new int [2];
                    int[] result2 = object1.myArrv(myArr2);
                    int result4 = myArr2[0] - myArr2[1];
                    Console.WriteLine(result4);
                    break;
                case 3:
                    //умножение
                    int[] myArr3 = new int [2];
                    int[] result = object1.myArrv(myArr3);
                    int result5 = myArr3[0] * myArr3[1];
                    Console.WriteLine(result5);
                    break;
                case 4:
                    //деление
                    int[] myArr4 = new int [2];
                    int[] result7 = object1.myArrv(myArr4);
                    int result8 = 0;
                    if (myArr4[1] == 0)
                        Console.WriteLine("На ноль делить нельзя!!!");
                    else
                        result8 = myArr4[0] / myArr4[1];
                    Console.WriteLine(result8);
                    break;
                case 5:
                    //возведение в степень
                    int Number;
                    int degree;
                    int result10;
                    Console.Write("Введите число:");
                    Number = Convert.ToInt32((Console.ReadLine()));
                    Console.Write("Введите степень:");
                    degree = Convert.ToInt32((Console.ReadLine()));
                    result10 = (int)Math.Pow(Number, degree);
                    Console.WriteLine($"Результат числа: {Number}  степень: {degree} = " + result10);
                    break;
                case 6:
                    //остаток от деления
                    int[] myArr5 = new int [2];
                    int[] result11 = object1.myArrv(myArr5);
                    int result12 = 0;
                    if (myArr5[1] == 0)
                        Console.WriteLine("На ноль делить нельзя!!!");
                    else
                        result12 = myArr5[0] % myArr5[1];
                    Console.WriteLine(result12);
                    break;
                case 7:
                    // операция расчет фактариала
                    Console.Write("Введите число :");
                    int number12 = 0;
                    if (number12 > 10)
                    {
                        Console.Write("Вы ввели число больше 10");
                    }
                    else
                    {
                        number12 = Convert.ToInt32((Console.ReadLine()));
                        int factarial = 1;
                        for (int number = 1; number <= number12; number++)
                        {
                            factarial *= number;
                        }
                        Console.WriteLine(factarial);
                    }
                    break;
                case 8:
                    // операция операция прибавляет к числу N число M количество раз, равное числу P
                    int digit;
                    double digit1;
                    Console.Write("Введите число 1:");
                    int digit2 = Convert.ToInt32((Console.ReadLine()));
                    digit1 = digit2;
                    Console.Write("Введите число 2:");
                    int digit3 = Convert.ToInt32((Console.ReadLine()));
                    Console.Write("Введите сколько раз число 2 + 1:");
                    digit = Convert.ToInt32((Console.ReadLine()));
                    for (int i = 0; i < digit; i++)
                    {
                        digit1 = digit1 + digit3;
                    }
                    Console.Write("Результат:");
                    Console.WriteLine(digit1);
                    break;
                case 9:
                    // операция операция прибавляет к числу N число M количество раз, равное числу P
                    int digit4 = 0;
                    double digit5;
                    Console.Write("Введите число 1:");
                    int digit6 = Convert.ToInt32((Console.ReadLine()));
                    digit5 = digit6;
                    Console.Write("Введите число 2:");
                    int digit7 = Convert.ToInt32((Console.ReadLine()));
                    Console.Write("Введите сколько раз число 1 - 2:");
                    digit4 = Convert.ToInt32((Console.ReadLine()));
                    for (int i = 0; i < digit4; i++)
                    {
                        digit6 = digit6 - digit7;
                    }
                    Console.Write("Результат:");
                    Console.WriteLine(digit6);
                    break;
                case 10:
                    //Сложить все остатки от деления числа B на все числа от 0 до N
                    int digit10 = 0;
                    Console.Write("Введите число 1:");//B
                    digit10 = Convert.ToInt32((Console.ReadLine()));
                    Console.Write("Введите число 2:");//от 0 до N
                    int digit11 = Convert.ToInt32((Console.ReadLine()));
                    int result6 = 0;
                    int digit13 = 0;
                    for (int i = 2; i <= digit11; i++)
                    {
                        
                        digit13 = digit10 % i;
                        result6 =+  digit13;
                    }
                    Console.Write("Результат:");
                    Console.WriteLine(result6);
                    break;
            }

            Console.Write("Хотите дальше продолжить?(0-продолжить;1-завершить):");
            exit = Convert.ToInt32(Console.ReadLine());
            
        } while (exit == 0);
    }
} 
//SimpleMathFunctions
public class SimpleMathFunctions
{
    
}
//AdditionalMathFunctions
public class AdditionalMathFunctions
{

}
//CustomFunctions
public class CustomFunctions
{
    
}
//void SayHello() { Console.WriteLine("Hello"); } Обозначение метода
//SayHello(); Вызов метода
// Условия 
    public class Operation1
{
    //Ввод массива
    public int[] myArrv(int[] s)
    {
        int o;
        for (o = 0; o < s.Length; o++)
        {
            Console.Write("Введите число:");
            s[o] = Convert.ToInt32(Console.ReadLine());
        }

        return s;
    }

//Вывод массива
    public int[] myArrv2(int[] myArrInts)
    {
        int o;
        for (o = 0; o < myArrInts.Length; o++)
        {
            Console.WriteLine(myArrInts[o]);
        }

        return myArrInts;
    }
}