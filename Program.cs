using System.ComponentModel.DataAnnotations;

namespace ProojectinOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Different Converter Unit");
            Console.WriteLine("\n*******************************************");
            
            string[] choose= new string[] {"Time Converter","Speed Converter ","Length Convert ","Currency Converter","Power Converter","Volume Converter","Mass Converter","Temperature Conveter","Energy Converter", "Area Converter", };

            for (int c=0; c< choose.Length; c++)
            {
                Console.WriteLine($"{ c+1}.{ choose[c]}");
            }

            Console.WriteLine("\nSelect the number you want to use in Converting unit:");
            int convert = Convert.ToInt16(Console.ReadLine());

            switch (convert)
            {
                case 1:
                    ChooseTimeConvert();
                    break;
                case 2:
                    ChooseSpeedConvert();
                    break;
                case 3:
                    ChooseLengthConvert();
                    break;
                case 4:
                    ChooseCurrencyConvert();
                    break;
                case 5:
                    ChoosePowerConvert();
                    break;
                case 6:
                    ChooseVolumeConvert();
                    break;
                case 7:
                    ChooseMassConvert();
                    break;
                case 8:
                    ChooseTemperatureConvert();
                    break;
                case 9:
                    ChooseEnergyConvert();
                    break;
                case 10:
                    ChooseAreaConvert();
                   break;
                default:
                    Console.WriteLine("Invalid Input.......");
                    return;




            }
            EnteringInputnumbertoConvert();

        }
        public static void ChooseLengthConvert()
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
        public static void ChooseSpeedConvert()
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
        public static void ChooseCurrencyConvert()
        {

        }
        public static void ChoosePowerConvert()
        {

        }
        public static void ChooseVolumeConvert()
        {

        }
        public static void ChooseMassConvert()
        {

        }
        public static void ChooseTemperatureConvert()
        {

        }
        public static void ChooseEnergyConvert()
        {

        }
        public static void ChooseAreaConvert()
        {

        }
        public static void EnteringInputnumbertoConvert()
        {

        }




    }
}
