using System;

namespace CalcApp_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, ans;
            string decisionMaker;

            MessageCalcApp.displayMsg(0);
            num1 = Convert.ToDouble(Console.ReadLine());
            MessageCalcApp.displayMsg(1);
            num2 = Convert.ToDouble(Console.ReadLine());

            MathsCalcApp ans1 = new();
            ans1.num1 = num1;
            ans1.num2 = num2;

            do
            {
                MessageCalcApp.displayMsg(2);
                decisionMaker =Console.ReadLine();
                switch (decisionMaker.ToLower())
                {
                    case "add":
                        ans = ans1.Add();
                        MessageCalcApp.displayMsg(3, ans);
                        break;
                    case "sub":
                        ans = ans1.Sub();
                        MessageCalcApp.displayMsg(3, ans);
                        break;
                    case "mult":
                        ans = ans1.Multiply();
                        MessageCalcApp.displayMsg(3, ans);
                        break;
                    case "divide":
                        ans = ans1.Divide();
                        MessageCalcApp.displayMsg(3, ans);
                        break;

                } 

            } while (decisionMaker == null);







        }

    }
}
