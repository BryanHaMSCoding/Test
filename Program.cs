using System;
using System.Reflection.Metadata;

namespace Test {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Test");
            Console.WriteLine("Test 2");
            Console.WriteLine("Test 3");

        }//end main
        #region PROMPT FUNCTIONS
        static double PrompTryDouble(string dataRequest) {
            //Variable
            double userInput = 0;
            bool isValid = false;

            //INPUT VALIDATION LOOP

            while (isValid == false) {
                Console.WriteLine(dataRequest);
                isValid = double.TryParse(Console.ReadLine(), out userInput);
            }//end while loop

            return userInput;
        }//end function

        static int PromptTryParse(string dataRequest) {
            //VARIABLE
            int userInput = 0;
            bool isValid = false;

            //INPUT VALIDATION LOOP
            do {
                Console.Write(dataRequest);
                isValid = int.TryParse(Console.ReadLine(), out userInput);
            } while (isValid == false);//end do while
            return userInput;
        }//end function

        static void Header(string text) {
            Console.WriteLine("================================================================");
            Console.WriteLine(text);
            Console.WriteLine("=================================================================");
        }//end function
        static string Prompt(string data) {
            //Variable:
            string userInput = "";

            //Request info from user
            Console.Write(data);

            //Recieve Response
            userInput = Console.ReadLine();

            return userInput;
        }//end function
        static int PromptInt(string data) {
            //Variable
            int userInput = 0;

            //Request and Receive info
            userInput = int.Parse(Prompt(data));

            return userInput;
        }//end function
        static double PromptDouble(string data) {
            //Variable
            double userInput = 0.0;

            //Request and Recieve info
            userInput = double.Parse(Prompt(data));

            return userInput;
        }//end function
        #endregion
    }//end class
}//end namespace
