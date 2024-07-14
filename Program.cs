namespace PROJECT_PUP_DIFF.CONVERT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome  to Diff Unit Converter");
            Console.WriteLine("***************************************************************************");



            //Menu for Different Converter & input the chossen convert to use//

            Console.WriteLine("How many attempts would you like to convert?");
            Console.WriteLine("Please enter the number of attempts:");
            int attemp = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < attemp; i++)
            {
                
                MenuCon.MenuConver();
            }
            //Evaluating branch of the choseen converter//

          
        }
    }
}
