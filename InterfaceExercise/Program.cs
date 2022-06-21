using System;
using System.Collections.Generic;
namespace InterfaceExercise
{
    class Program
    {

        public static int AskForInt(string msg = "please enter a number for your selection...")
        {
            bool gotInt = false;
            bool intGood = false;
            int userSelection;
            do
            {
                //Console.Clear();
                Console.Write(msg);
                gotInt = int.TryParse(Console.ReadLine(), out userSelection);
                intGood = (gotInt && 0 < userSelection && userSelection <= 4) ? true : false;
            } while (!intGood);
            return userSelection;
        }

        public static void UserConfirm()
        {
            Console.WriteLine("\npress enter to continue...\n");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayBasics(Car c)
        {
            Console.WriteLine($"{c.GetType().Name}: {c.Name}, {c.Color}, ${c.PriceTag}");
        }

        public static void DisplayBasics(Truck t)
        {
            Console.WriteLine($"{t.GetType().Name}: {t.Name}, {t.Color}, ${t.PriceTag}");
        }

        public static void DisplayBasics(SUV s)
        {
            Console.WriteLine($"{s.GetType().Name}: {s.Name}, {s.Color}, ${s.PriceTag}");
        }

        public static void DisplayCompanyInfo(ICompany c)
        {
            Console.WriteLine($"\nCompany Info: \n\tName: {c.Name}, Motto: \"{c.Motto}\", Eco Rating: {c.EcoRating}");
        }

        public static void DisplayVehicleInfo(IVehicle v)
        {
            Console.WriteLine($"Vehicle Info: \n\tColor: {v.Color}, Electric Engine: {v.Electric}, Price: ${v.PriceTag}");
        }

        public static void DisplayDetails(Car c)
        {
            DisplayCompanyInfo(c);
            DisplayVehicleInfo(c);
            Console.WriteLine($"unique features:\n\tHatchback: {c.Hatchback}, Sunroof: {c.HasSunroof}");
            UserConfirm();
        }

        public static void DisplayDetails(Truck t)
        {
            DisplayCompanyInfo(t);
            DisplayVehicleInfo(t);
            Console.WriteLine($"unique features:\n\t Covered Bed: {t.CoveredBed}, You Can Tow: {t.CanTow}");
            UserConfirm();
        }

        public static void DisplayDetails(SUV s)
        {
            DisplayCompanyInfo(s);
            DisplayVehicleInfo(s);
            Console.WriteLine($"unique features:\n\t Max Passengers: {s.NumPassengers}, Offroad Capable: {s.OffRoadCapable}");
            UserConfirm();
        }

        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
            //Create 2 Interfaces called IVehicle & ICompany
            //Create 3 classes called Car , Truck , & SUV
            //In your IVehicle
            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
            //In ICompany
            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */
            //In each of your car, truck, and suv classes
            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            bool userActive = true;
            var focus = new Car(8000, "blue", false, "Ford", "Go Further", 80, true, true);
            var R1T = new Truck(70000, "yellow", true, "Rivian", "Trying to keep the world adventurour", 95, false, true);
            var runner = new SUV(80000, "grey", false, "Toyota", "We are cool and expensive!", 80, 4, true);
            while (userActive)
            {
                Console.WriteLine("welcome to truecoders car dealership where today you can become a true driver!" +
                    "\ncheck out our list of vehicles.\nselect the option to see more details!\n");
                Console.Write("1: ");
                DisplayBasics(focus);
                Console.Write("2: ");
                DisplayBasics(R1T);
                Console.Write("3: ");
                DisplayBasics(runner);
                Console.WriteLine("4: Exit\n");
                switch (AskForInt("please select an option for more details: "))
                {
                    case 1:
                        DisplayDetails(focus);
                        break;
                    case 2:
                        DisplayDetails(R1T);
                        break;
                    case 3:
                        DisplayDetails(runner);
                        break;
                    case 4:
                        userActive = false;
                        Console.WriteLine("\npress enter to exit...\n");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("whoops");
                        break;
                }
            }
        }
    }
}
