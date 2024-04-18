string input;
do
{
    //using System.Collections;

    Console.WriteLine("kalkulatorga xush kelibsiz !");
    Console.WriteLine("1 -> +, -, *, /, ^ amallari bilan ishlash");
    Console.WriteLine("2 -> sonning logarifmini topish");
    Console.WriteLine("3 -> dasturni tugatish");

    input = Console.ReadLine();
    switch(input)
    {
        case "1":
        {
            Console.Write("ifodani kiriting : ");
            string ifoda = Console.ReadLine();
            string amal = "";
            if(ifoda.Contains("+"))
            {
                amal = "+";
            }
            else if(ifoda.Contains("-"))
            {
                amal = "-";
            }
            else if(ifoda.Contains("*"))
            {
                amal = "*";
            }
            else if(ifoda.Contains("/"))
            {
                amal = "/";
            }
            else if(ifoda.Contains("^"))
            {
                amal = "^";
            }
            string strNum1 = ifoda.Substring(0, ifoda.IndexOf(amal));
            string strNum2 = ifoda.Substring(ifoda.IndexOf(amal) + 1);
            double firstNumber = Convert.ToDouble(strNum1);
            double secondNumber = Convert.ToDouble(strNum2);
            double natija = amal switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "^" => Math.Pow(firstNumber, secondNumber),
            };
            Console.WriteLine($"{ifoda} = {natija}");
        }
        break;

        case "2":
        {
            //log5(25);
            Console.Write("ifodani kiriting [log5(25)]: ");
            string ifoda = Console.ReadLine();
            int index1 = ifoda.IndexOf("(");
            int index2 = ifoda.IndexOf(")");
            string strNum1 = ifoda.Substring(3, index1 - 2 - 1);
            string strNum2 = ifoda.Substring(index1 + 1, index2 - index1 - 1);
            double num1 = Convert.ToDouble(strNum1);
            double num2 = Convert.ToDouble(strNum2);
            float natija = (float)(Math.Log(num2) / Math.Log(num1));
            Console.WriteLine($"{ifoda} = {natija}");
        }
        break;
    }
}while(input != "3");