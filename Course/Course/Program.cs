using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //SByte x = 100; //variável menor
            //Console.WriteLine(x);

            //quando voce usa um número maior que a varíavel, o valor retornado é o primeiro que ela suporta
            double n1 = 255.020323423423;

            n1++;
            Console.WriteLine(n1.ToString("f3"));//formatar casas decimais
            Console.WriteLine(n1.ToString("f2", CultureInfo.InvariantCulture)); //ignora os separadores de outros países e usa o "."

        }
    } 
}
