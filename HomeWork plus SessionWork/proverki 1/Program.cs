using System;

namespace proverki_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cena = 0;
            double groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int groupMembers = int.Parse(Console.ReadLine());

            if (season == "Spring")
            {
                cena = 3000;
                if (groupMembers >= 4 && groupMembers <= 6)
                {
                    
                    cena *= 0.9;
                    if (groupMembers % 2 == 0)
                    {
                        cena *= 0.95;
                    }
                }
                else if (groupMembers >= 7 && groupMembers <= 11)
                {

                    cena *= 0.85;
                    if (groupMembers % 2 == 0)
                    {
                        cena *= 0.95;
                    }
                }
                else if (groupMembers >= 12)
                {

                    cena *= 0.75;
                    if (groupMembers % 2 == 0)
                    {
                        cena *= 0.95;
                    }
                }
            }

            if (season == "Summer")
            {
                cena = 4200;
                if (groupMembers >= 4 && groupMembers <= 6)
                {

                    cena *= 0.9;
                    if (groupMembers % 2 == 0)
                    {
                        cena *= 0.95;
                    }
                }
                else if (groupMembers >= 7 && groupMembers <= 11)
                {

                    cena *= 0.85;
                    if (groupMembers % 2 == 0)
                    {
                        cena *= 0.95;
                    }
                }
                else if (groupMembers >= 12)
                {

                    cena *= 0.75;
                    if (groupMembers % 2 == 0)
                    {
                        cena *= 0.95;
                    }
                }
            }

            if (season == "Autumn")
            {
                cena = 4200;
                if (groupMembers >= 4 && groupMembers <= 6)
                {

                    cena *= 0.9;

                }
                else if (groupMembers >= 7 && groupMembers <= 11)
                {

                    cena *= 0.85;

                }
                else if (groupMembers >= 12)
                {

                    cena *= 0.75;

                }
            }

            if (season == "Winter")
            {
                cena = 2600;
                if (groupMembers >= 4 && groupMembers <= 6)
                {

                    cena *= 0.9;
                    if (groupMembers % 2 == 0)
                    {
                        cena *= 0.95;
                    }
                }
                else if (groupMembers >= 7 && groupMembers <= 11)
                {

                    cena *= 0.85;
                    if (groupMembers % 2 == 0)
                    {
                        cena *= 0.95;
                    }
                }
                else if (groupMembers >= 12)
                {

                    cena *= 0.75;
                    if (groupMembers % 2 == 0)
                    {
                        cena *= 0.95;
                    }
                }
            }

            if (groupBudget - cena < 0)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(groupBudget - cena):f2} leva.");
            }
            else if (groupBudget - cena < 0)
            {
                Console.WriteLine($"Yes! You have {(groupBudget - cena):f2} money left.");
            }

        }
    }
}
