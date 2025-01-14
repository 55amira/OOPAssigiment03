﻿using Demo.interfaceEx01;
using Demo.interfaceEx02;
using Demo.interfaceEx03;

namespace Demo
{
    internal class Program
    {
        //static void Print10Number(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Number(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Number(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        static void Print10Number(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current} ");
                series.Next();
            }
            Console.WriteLine();
            series.Reset();
        }
        static void Main(string[] args)
        {
            #region interfaceEx01
            //MyType myType= new MyType();
            //myType.Fun();
            //myType.salary = 12000;
            //Console.WriteLine(myType.salary);

            //IMyType myType;
            //myType = new MyType();
            //myType.Print();
            //myType.Fun();
            //myType.salary = 12000;
            //Console.WriteLine(myType.salary); 
            #endregion

            #region interfaceEx02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10Number(seriesByTwo);
            //
            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10Number(seriesByThree);
            //
            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10Number(seriesByFour);

            #endregion

            #region interfaceEx03
            /////Car car = new Car();
            /////car.Spead = 120;
            /////car.Forword();


            // Airplan airplan = new Airplan();
            // IFlyable flyable = airplan;
            // flyable.Backword();

            // IMoveable moveable = airplan;
            // moveable.Backword(); 
            #endregion

            #region Shallow Copy And Deep Copy
            ////int[] Arr01 = { 1, 2, 3 };
            ////int[] Arr02 = { 4, 5, 6 };

            ////Console.WriteLine(Arr01.GetHashCode());
            ////Console.WriteLine(Arr02.GetHashCode());

            ////Console.WriteLine();

            ////Arr02 = Arr01;//Shallow Copy
            ////Console.WriteLine(Arr01.GetHashCode());
            ////Console.WriteLine(Arr02.GetHashCode());

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Console.WriteLine();

            //Arr02 =(int[]) Arr01.Clone();//Deep Copy
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode()); 
            #endregion

            #region built-in-interface IClonable
            //Employee E01 = new Employee() { id = 1, name = "Ahmed", age = 20, salary = 12000 };

            //Employee E02 = new Employee() { id = 2, name = "Ali", age = 22, salary = 15000 };

            ////E02=E01;
            //E02 =(Employee) E01.Clone();

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //Console.WriteLine(E01);
            //Console.WriteLine(E02); 
            #endregion

            #region built-in-interface ICompareable

            //Employee[] employee = new Employee[3] 
            //{
            //     new Employee() { id = 1, name = "Ahmed", age = 20, salary = 12000 },
            //     new Employee() { id = 2, name = "Ali", age = 22, salary = 15000 },
            //     new Employee() { id = 3, name = "Mohamed", age = 19, salary = 11000 }
            //};

            // //int x= employee[0].CompareTo(employee[1]);
            // // Console.WriteLine(x);

            //Array.Sort(employee);

            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine(emp);
            //} 
            #endregion

            #region built-in-interface IComparer
            // Employee[] employee = new Employee[3]
            //{
            //      new Employee() { id = 1, name = "Ahmed", age = 20, salary = 12000 },
            //      new Employee() { id = 2, name = "Ali", age = 22, salary = 15000 },
            //      new Employee() { id = 3, name = "Mohamed", age = 19, salary = 11000 }
            //};

            // //int x= employee[0].CompareTo(employee[1]);
            // // Console.WriteLine(x);

            // Array.Sort(employee,new EmpioyeeComparerSalary());

            // foreach (Employee emp in employee)
            // {
            //     Console.WriteLine(emp);
            // } 
            #endregion


        }
    }
}
