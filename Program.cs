using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main()

    {
        //1-MASALA
        // Console.Write("Birinchi sonni kiriting: ");
        // double num1 = Convert.ToDouble(Console.ReadLine());

        // Console.Write("Amalni kiriting (+, -, *, /): ");
        // char t = Convert.ToChar(Console.ReadLine());

        // Console.Write("Ikkinchi sonni kiriting: ");
        // double num2 = Convert.ToDouble(Console.ReadLine());

        // double x = 0;

        // switch (t)
        // {
        //     case '+':   
        //         x = num1 + num2;
        //         break;
        //     case '-':
        //         x = num1 - num2;
        //         break;
        //     case '*':
        //         x = num1 * num2;
        //         break;
        //     case '/': 
        //         if (num2 != 0)
        //             x = num1 / num2;
        //         else
        //         {
        //             Console.WriteLine("Nolga bo‘lish mumkin emas!");
                
        //         }
        //         break;
        //     default:
        //         Console.WriteLine("Noto‘g‘ri amal kiritildi!");
        //         return;
        // }

        // Console.WriteLine($"Natija: {x}");
        //2-MASALA
        // Console.Write("N=");
        // int N=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine((1.0+N)/2*N);

        //3-masala
        System.Console.Write("sonni kiriting:>>");
        int x= Convert.ToInt32(Console.ReadLine());
        if(x%2==0){
            System.Console.WriteLine("juft");
        }
        else System.Console.WriteLine("toq");

    }
}
