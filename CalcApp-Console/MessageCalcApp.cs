using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp_Console
{
    class MessageCalcApp
    {
        const string askFirstNum = "Please Enter First Number:";
        const string askSecondNum = "Please Enter Second Number: ";
        const string decisionMsg = "What do you want to do with these numbers: ";
        const string displayReslt = "The result of your calculation is: ";
        const string errorMsg = "I do not understand what you want to do";
        const string thankYouMsg = "Thank you for using our calculator";


        public static void displayMsg(short? messageIndex = null, double? ans = null)
        {
            switch (messageIndex)
            {
                case 0:
                    Console.WriteLine(askFirstNum);
                    break;
                case 1:
                    Console.WriteLine(askSecondNum);
                    break;
                case 2:
                    Console.WriteLine(decisionMsg);
                    break;
                case 3:
                    Console.WriteLine(displayReslt + ans);
                    break;
                case 4:
                    Console.WriteLine(errorMsg);
                    break;
                case 5:
                    Console.WriteLine(thankYouMsg);
                    break;
            }

        }

    }
}
