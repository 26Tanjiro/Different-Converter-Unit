using System.ComponentModel.DataAnnotations;

namespace ProojectinOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Different Converter Unit");
            Console.WriteLine("\n*******************************************");
            
            string[] choose= new string[] { "Time ",
                                         "Velocity ",
                                         "Measurement" };

            for (int c=0; c< choose.Length; c++)
            {
                Console.WriteLine($"{ c+1}.{ choose[c]}");
            }


            Console.WriteLine("\nChoose Convert you want to Convert:");
            int convert = Convert.ToInt16(Console.ReadLine());

            switch (convert)
            {
                case 1:
                    ChooseTimeConvert();
                    break;
                case 2:
                    ChooseVelocityConvert();
                    break;
                case 3:
                    ChooseMeasurementConvert();
                    break;



            }

        }
        public static void ChooseMeasurementConvert()
        {
            Console.WriteLine("Choose Measurment Converter:");
            string[] measurementc = new string[] { "m to cm ", 
                                                   "cm to m ", 
                                                   "cm to in ",
                                                   "ft to m ",
                                                   "yd to m ",
                                                   "m to yd ",
                                                   "mile to km ",
                                                   "km to mile ",
                                                   "n mile to m ",
                                                   "m to n mile "};
            
            for (int i = 0; i < measurementc.Length; i++)
            {
                
                Console.WriteLine($"{i + 1}. {measurementc[i]}");
            }

        }
        public static void ChooseTimeConvert()
        {
            Console.WriteLine("Choose Time Converter:");
            string[] timec = new string[] { "m to cm ",
                                                   "cm to m ",
                                                   "cm to in ",
                                                   "ft to m ",
                                                   "yd to m ",
                                                   "m to yd ",
                                                   "mile to km ",
                                                   "km to mile ",
                                                   "n mile to m ",
                                                   "m to n mile "};

            for (int i = 0; i < timec.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {timec[i]}");
            }
            Console.WriteLine("Enter youre choosen converter:");
            int timeconvert = Convert.ToInt16(Console.ReadLine());
        }
        public static void ChooseVelocityConvert()
        {
            Console.WriteLine("Choose Velocity Converter:");
            string[] velocityc = new string[] { "m to cm ",
                                                   "cm to m ",
                                                   "cm to in ",
                                                   "ft to m ",
                                                   "yd to m ",
                                                   "m to yd ",
                                                   "mile to km ",
                                                   "km to mile ",
                                                   "n mile to m ",
                                                   "m to n mile "};

            for (int i = 0; i < velocityc.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {velocityc[i]}");
            }
        }
     
        
    }
}
