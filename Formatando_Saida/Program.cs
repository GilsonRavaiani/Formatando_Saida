using System;

namespace Formatando_Saida
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

             n1 = 10; n2 = 20; n3 = 30;
            //var um = n1;
            //var dois = 20;
            //var tres = 30;

            //Console.WriteLine({0}, {1}, {2});
            Console.WriteLine("n1={0}\nn2={1}\nn3={2}", n1,n2,n3);
            //Console.Write(n1 + " " + n2 + " " + n3);
            //Console.WriteLine("n1={0}, n2={1}, n3={2}", n1,n2,n3);
            //Console.WriteLine(um, dois, tres);  //???
            Console.ReadLine();
        }
    }
}
