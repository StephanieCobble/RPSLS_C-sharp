using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class human : player
    {
        public human()
        {
            this.name = name;
            this.gestureSelected = gestureSelected;
            this.gestureList = gestureList;
            this.wins = wins;
        }
        public void setName()
        {
            Console.WriteLine("Enter your name: ");
            this.name = Console.ReadLine();
        }
        public void chooseGesture()
        {
            bool gestureConfirmed = false;
            Console.WriteLine($"Enter in '0' for {this.gestureList[0]}");
            Console.WriteLine($"Enter in '1' for {this.gestureList[1]}");
            Console.WriteLine($"Enter in '2' for {this.gestureList[2]}");
            Console.WriteLine($"Enter in '3' for {this.gestureList[3]}");
            Console.WriteLine($"Enter in '4' for {this.gestureList[4]}");

            while (gestureConfirmed == false)

                Console.WriteLine("Enter the number for the gesture to use: ");
                int selectedGesture = int.Parse(Console.ReadLine());
                if (selectedGesture >= 0 && selectedGesture <= 4)
            {
                if (selectedGesture == 0)
                {
                    this.gestureSelected = this.gestureList[0];
                    Console.WriteLine("Gesture confirmed!");
                    gestureConfirmed = true;
                }
                else if (selectedGesture == 1)
                {
                    this.gestureSelected = this.gestureList[1];
                    Console.WriteLine("Gesture confirmed!");
                    gestureConfirmed = true;
                }
                else if (selectedGesture == 2)
                {
                    this.gestureSelected = this.gestureList[2];
                    Console.WriteLine("Gesture confirmed!");
                    gestureConfirmed = true;
                }
                else if (selectedGesture == 3)
                {
                    this.gestureSelected = this.gestureList[3];
                    Console.WriteLine("Gesture confirmed!");
                    gestureConfirmed = true;
                }
                else if (selectedGesture == 4)
                {
                    this.gestureSelected = this.gestureList[4];
                    Console.WriteLine("Gesture confirmed!");
                    gestureConfirmed = true;
                }

            }
            else
            {
                Console.WriteLine("Invalid Entry! Tray again!");
                Console.WriteLine("Enter a valid number between 0 and 4. See above rules for guidance.");
            }
        }
    }
}
