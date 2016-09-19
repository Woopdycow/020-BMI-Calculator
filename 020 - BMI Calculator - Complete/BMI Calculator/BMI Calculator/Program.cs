using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator {
    class Program {
        const string WELCOME = "Welcome to the BMI calculator.";
        const string GOODBYE = "Thanks for using the BMI Calculator!\nPress any key to exit...";
        const string QUERY_HEIGHT = "How tall are you? (cm): ";
        const string QUERY_WEIGHT = "How much do you weigh? (kg): ";
        const string DISPLAY_BMI = "Your BMI is: {0}";
        const string INVALID = "\nInvalid Input - Try again: ";
        const int MINIMUM = 1;


        static void Main(string[] args) {
            int height;
            int weight;
            double bmi;

            welcome();

            height = getHeight();
            weight = getWeight();

            bmi = calculateBMI(height, weight);

            displayBMI(bmi);

            goodbye();


        }

        static void welcome() {
            Console.WriteLine(WELCOME);
        }

        static int getHeight() {
            int output = 0;
            bool isValid = false;

            Console.Write(QUERY_HEIGHT);
            while (!isValid) {
                if (int.TryParse(Console.ReadLine(), out output) && output >= MINIMUM) {
                    isValid = true;
                } else {
                    Console.Write(INVALID);
                }
            }
            return output;
        }

        static int getWeight() {
            int output = 0;
            bool isValid = false;

            Console.Write(QUERY_WEIGHT);
            while (!isValid) {
                if (int.TryParse(Console.ReadLine(), out output) && output >= MINIMUM) {
                    isValid = true;
                } else {
                    Console.Write(INVALID);
                }
            }
            return output;
        }

        static double calculateBMI(int height, int weight) {
            double output = 0;
            output = weight / Math.Pow(height / 100.0, 2);
            output = Math.Round(output, 2);
            return output;
        }

        static void displayBMI(double bmi) {
            Console.WriteLine(DISPLAY_BMI, bmi);
        }

        static void goodbye() {
            Console.WriteLine(GOODBYE);
            Console.ReadKey();
        }

    }
}
