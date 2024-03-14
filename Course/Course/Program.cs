using System;
using System.Data.SqlTypes;
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

            int a = 3;

            a *= 4;
                Console.WriteLine(a);

            string s = "ABC";

            s += "deef";
            Console.WriteLine(s);

            //definição de casting: quando um tirpo de variável recebe o valor de uma varivel de tipo maior ex:

            double l;
            float r;

            //r = l;
            //l = 2.66;

            //this case we need define a "casting" for a variable, is "float"
            l = 2.66;
            r = (float)l;

            Console.WriteLine(r);

            //exemplo com contas

            int z=5;
            int x=2;
            //this situacion in count don't show a broken number, why the INT not accept broken numbers
            double resultado = z / x;
            Console.WriteLine(resultado);
            //vamos usar o casting

            double resultado1 = (double)z / x;
            Console.WriteLine(resultado1);


            //inputs of date with "Console.Readline()"


            //string frase = Console.ReadLine();

           // Console.WriteLine(frase);


            //Separing defined string with "Split"

            

            string[] vet=Console.ReadLine().Split(' '); //defined a vetor and getting variable 's' for function active "Split"

            string p1, p2, p3;

            p1 = vet[0];
            p2 = vet[1];
            p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            //==========================================================================

            //converting string for number with int.Parse

            int n01= int.Parse(Console.ReadLine());

            Console.WriteLine("Você Digitou: "+ (n01+=3));


            //======================================================================

            string[] vetorDate  = Console.ReadLine().Split(' ');

            string nome = vetorDate[0];
            char sexo = char.Parse(vetorDate[1]); // definindo o sexo para char porque o console.readline gera um string
            int idade = int.Parse(vetorDate[2]);
            double altura = double.Parse(vetorDate[3]);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);











        }
    } 
}
