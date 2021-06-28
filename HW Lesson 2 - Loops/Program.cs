using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_2___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region q1

            //for (int i = 2; i < 21; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            #endregion

            #region q2

            //int sum = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Please enter number no. {0}", i);
            //    sum += int.Parse(Console.ReadLine());
            //}
            //float avg = sum / 5f;
            //Console.WriteLine("Average: " + avg);

            #endregion

            #region q3

            //do
            //{
            //    Console.WriteLine("Enter the first number");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the second number");
            //    int num2 = int.Parse(Console.ReadLine());

            //    if (num1 == 0 || num2 == 0)
            //    {
            //        continue;
            //    }

            //    if (num1 < 0 || num2 < 0)
            //    {
            //        break;
            //    }

            //    Console.WriteLine("Summary: " + (num1 + num2));
            //    Console.WriteLine("Product: " + (num1 * num2));

            //} while (true);

            #endregion

            #region q4

            //for (int i = 9; i > 0; i--)
            //{
            //    for (int k = i; k >= 0; k--)
            //    {
            //        Console.WriteLine(k);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region q5

            //for (int i = 1; i < 11; i++)
            //{
            //    for (int k = 1; k < 11; k++)
            //    {
            //        if (i * k < 10)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write(" " + i * k);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region exercise-while-1+2

            //Console.WriteLine("please enter number");
            //int x = int.Parse(Console.ReadLine());
            //int counter = 0;
            //while (x < 20)
            //{
            //    if (x % 2 == 0 && x > 14)
            //    {
            //        int i = x / 2;
            //        while (i > 0)
            //        {
            //            Console.WriteLine("inner loop: " + i);
            //            i--;
            //        }
            //    }
            //    x++;
            //    counter++;
            //}
            //Console.WriteLine(counter);

            #endregion

            #region exercise-for-1+con-break-1

            //Console.WriteLine("enter a number bigger than 3");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < num * 2; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    if (i > 10)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //    if (i == num * 2 - 1)
            //    {
            //        Console.WriteLine("END");
            //    }
            //}

            #endregion

            #region exercise-for-2+3

            //for (int i = 0, j = 10; i <= 10; i++, j--)
            //{
            //    Console.WriteLine("i + j = " + (i + j));
            //}

            #endregion

            #region exercise-con-break-2

            //int counter = 0;

            //while (true)
            //{
            //    Console.WriteLine("please enter number");
            //    int num = int.Parse(Console.ReadLine());
            //    counter++;

            //    if (num == 23)
            //    {
            //        Console.WriteLine("Are you sure you want to quit? (if you are press 'y'))");
            //        string choice = Console.ReadLine();
            //        if (choice == "Y" || choice == "y")
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("The loop contines");
            //        }
            //    }
            //}

            //Console.WriteLine("The loop ran {0} times", counter);

            #endregion

            #region hw2-q1

            //bool prime = false;
            //while (prime == false)
            //{
            //    prime = true;
            //    Console.WriteLine("please enter number");
            //    int num = int.Parse(Console.ReadLine());

            //    for (int i = 2; i < num / 2; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            prime = false;
            //            break;
            //        }
            //    }

            //    if (prime)
            //    {
            //        Console.WriteLine("The number is a prime number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is not a prime number");
            //    }
            //}

            #endregion

            #region hw2-q2

            //Console.WriteLine("How many students have arrived?");
            //int students = int.Parse(Console.ReadLine());
            //int class100 = students / 100;
            //int class30 = students % 100 / 30;
            //int class10 = students % 100 % 30 / 10;
            //int noClass = students % 100 % 30 % 10;

            //if (class100 > 0)
            //{
            //    Console.WriteLine(class100 + " classes of 100 students");
            //}
            //if (class30 > 0)
            //{
            //    Console.WriteLine(class30 + " classes of 30 students");
            //}
            //if (class10 > 0)
            //{
            //    Console.WriteLine(class10 + " classes of 10 students");
            //}
            //Console.WriteLine(noClass + " students will have to go home");

            #endregion

            #region hw2-q3

            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            ////for (int i = num - 1; i > 0; i--)
            ////{    //    נדמה לי שזה מה שהמורה התכוון לבקש אך הוא טעה בניסוח השאלה
            ////    for (int j = i; j > 0; j--)
            ////    {
            ////        Console.Write(j);
            ////    }
            ////    Console.WriteLine();
            ////}

            //for (int i = num - 1; i > 0; i--)
            //{ // זה מה שהמורה ביקש לפי ניסוח השאלה המקורי
            //    for (int j = i; j > 0; j--)
            //    {
            //        Console.Write(i - j + 1);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region hw2-q4-Pyramid

            //Console.WriteLine("enter number");

            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % 2 == 1)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            continue;
            //        }
            //        for (int j = i; j < num; j += 2)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = 0; j < i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        if (i % 2 == 1)
            //        {
            //            continue;
            //        }
            //        for (int j = i; j < num; j += 2)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = 0; j < i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            #endregion

        }
    }
}
