using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane
{
    class MaProgram
    {
        static void Main(string[] args)
        {
            //Introduction & user prompt for windspeed
            WriteLine("\n************************************ Saffir-Simpson Hurricane Scale ************************************\n\n");
            WriteLine ("PLEASE NOTE:");
            WriteLine("Our classifications are referenced using MPH(Miles Per Hour), please use MPH when you enter your wind speed.");
            Write("\n\nPlease enter the sustained wind speed to see it's category classification: ");
            double winSpeed = Convert.ToInt32(Console.ReadLine());//convert user input
            WriteLine("\n");
            WindSpeedCal(winSpeed);//Category argument
            WriteLine("\n\n\n");
            WriteLine("******************************* Thank-You for using our categorization tool. *******************************");//Thanks

            ReadKey();
        }

        //wind speed argument 
        static double WindSpeedCal(double winCat)
        {
            if (winCat >= 157)
                WriteLine("The sustained wind speed you entered indicates a category 5 hurricane.");
            else if (winCat < 157 && winCat >= 130)
                WriteLine("The sustained wind speed you entered indicates a category 4 hurricane.");
            else if (winCat < 130 && winCat >= 111)
                WriteLine("The sustained wind speed you entered indicates a category 3 hurricane.");
            else if (winCat < 111 && winCat >= 96)
                WriteLine("The sustained windspeed you entered indicates a category 2 hurricane.");
            else if (winCat < 96 && winCat >= 74)
                WriteLine("The sustained wind speed you entered indicates a category 1 hurricane.");
            else if (winCat < 74)
                WriteLine("Wind speed less than 74MPH are not considered to be of hurricane strength.");
            else
                WriteLine("Error. Please Enter a valid numeric value");

            return winCat;

        }   
    }
}
