using Demo.interfaceEx01;
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
        }
    }
}
