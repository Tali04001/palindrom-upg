using System;

namespace sdfghjkl
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,r,s=0,temp; //eftersom de har samma värde slipper jag göra flera int.
            Console.WriteLine("skriv ett 2siffrigt tal som minst:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n>0){

                r=n%10;
                s=(s*10)+r;
                n=n/10;
            }
            if(temp==s)
             Console.WriteLine("ja det är ett palindrom");

            else
            Console.WriteLine("Nej det är inte ett palindrom");

        }
    }
}
