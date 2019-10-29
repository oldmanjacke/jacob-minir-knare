using System;

namespace jacob_miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;                   
            string operation;
            int answer;

            Console.WriteLine("Welcome!");
            Console.WriteLine("press Enter to start or -1 to exit");
            Console.ReadLine();

            Console.Write("Enter the first number in your basic equation: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            //
            Console.Write("Ok now enter your operation ( x , / , +, -) ");
            operation = Console.ReadLine();
            Console.Write("Now enter your second number in the basic equation: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            //fixa en loop här!!
            
            bool keepAlive = true;
            while (keepAlive)
            {

                try
                {


            if (operation == "x")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            //
            else if (operation == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry that is not correct format! Please restart!");     //
                Console.ReadLine();
            }
            if (keepAlive == false "-1");
                
                }

            }


        }
    }
}
