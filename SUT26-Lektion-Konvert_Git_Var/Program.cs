namespace SUT26_Lektion_Konvert_Git_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Implicit
            //int valueInt = 50;
            //double valueDoubel = valueInt;


            //Console.WriteLine(valueDoubel.GetType());



            //Explicit

            //decimal FNumber = 57893453.20m;

            //int InNumber = (int)FNumber;  // Type Casting
            //int InNumber2 = Convert.ToInt32(FNumber); // Convert Class


            //Console.WriteLine(InNumber);
            //Console.WriteLine(InNumber2);




            //Parse() && TryParse 

            int Result = 0;
            string stringValue = "12377777";
            ////int ConResult =  int.Parse(stringValue);
            ////Console.WriteLine(ConResult.GetType());


           bool IsConverted = int.TryParse(stringValue,out Result);

            if (IsConverted)
            {
                Console.WriteLine("Result is : {0}",Result);
            }
            else
            {
                Console.WriteLine("Please Enter a valid number");
            }


            Console.ReadKey();

        }
    }


    class User
    {

    }
    class Student
    {

    }
}
