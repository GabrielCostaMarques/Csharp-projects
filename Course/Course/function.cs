using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace Course
{
    class StudyFunction
    {
        static void Main(string[] args)
        {
          string[] x =  Console.ReadLine().Split(" ");

           int n1= int.Parse(x[0]);
           int n2= int.Parse(x[1]);
           int n3= int.Parse(x[2]);


            int resultado = Maior(n1, n2, n3);


            Console.WriteLine($"Maior = {resultado}");

        }

        static int Maior(int n1, int n2, int n3)
        {
            int m;

            if( n1>n2 && n1>n3 )
            {
                m = n1;
            }else if( n2>n3 ) {
            
            m= n2;


            }
            else { m = n3;}
            return m;
        }
    } 
}
