﻿using System;

namespace PunchGeon_01
{
    internal class Program
    {



        static void Main(string[] args)
        {
            
            int PS = 0;
            int AT = 0;
            int CurationsNum = 0;
            bool BloodLost = false;
            bool Defense = false;
            bool Curation = false;



            Console.WriteLine("Choose a character");

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\ta - Catcher = 100 PS, 56 attack, +2 30 PS potions");

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\tb - Warior = 120 PS, 45 attack, 33,3% defense");

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\tc - Blood King = 100 PS, 56 attack, 20% bloodLose -20 ");

            Console.ResetColor();
            Console.WriteLine("Escribe a, b or c to select the character");


            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("PS +100, +56 attack");
                    PS = PS + 100;
                    AT = AT + 56;
                    Curation = true;
                    CurationsNum = CurationsNum + 2;
                    break;

                case "b":
                    Console.WriteLine("PS +120, +45 attack");
                    PS = PS + 120;
                    AT = AT + 45;
                    Defense = true;
                    break;

                case "c":
                    Console.WriteLine("PS +100, +56 attack, + ");

                    PS = PS + 100;
                    AT = AT + 56;
                    BloodLost = true;

                    break;

            }
            ChatCleaner();


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            

            int PSE = 120;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("When you saw that you have less than 0 PS/enemy-PS attacks or skip to finish the battle. Thank you:)");
            Console.ResetColor();
            Console.WriteLine("Ohhh, you has across with an enemy");
            Console.WriteLine("The enemy attasc's you first");

            while (PSE >= 1 | PS >= 1)
            {

                Random r = new Random();
                int damage = r.Next(10, 48);
                if (damage < 4)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Miss");
                    damage = 0;
                    Console.ResetColor();
                }
                if (damage > 40)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Critial!");
                    Console.ResetColor();
                }


                //Damage Defense Confing

                if (Defense == true)
                {
                    damage = damage - damage / 3;
                    Console.WriteLine("Damage sussefuly defensed");
                }
                //End Defense Confing
                PS = PS - damage;

                //Normal Attack

                if (Curation == false)
                {
                    Console.WriteLine($"-{damage}");
                    Console.WriteLine($"You have {PS}");

                    Console.WriteLine("Your turn");
                    Console.WriteLine("\ta - Attack");

                    Console.WriteLine("\tc - Skip");

                    switch (Console.ReadLine())
                    {
                        case "a":
                            int ydamage = r.Next(10, AT);
                            if (ydamage < 4)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Miss");
                                ydamage = 0;
                                Console.ResetColor();
                            }
                            if (ydamage > 50)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Critial!");
                                Console.ResetColor();
                            }


                            //Blood Lost Confing


                            if (BloodLost == true)
                            {
                                Random BL = new Random();
                                int BloodL = BL.Next(1, 15);

                                if (BloodL == 12)
                                {
                                    PSE = PSE - 20;
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("BLOODLOST!, -20 PS ENEMY");
                                    Console.ResetColor();
                                }

                            }



                            Console.WriteLine($"You have did {ydamage}");
                            Console.WriteLine($"The enemy have {PSE}");
                            PSE = PSE - ydamage;
                            break;

                        case "c":
                            break;
                    }
                }

                //Catcher Attack
                
                if (Curation == true)
                {
                    Console.WriteLine($"-{damage}");
                    Console.WriteLine($"You have {PS}");

                    Console.WriteLine("Your turn");
                    Console.WriteLine("\ta - Attack");
                    if (CurationsNum != 0)
                    {
                        Console.WriteLine($"\tl - {CurationsNum} Potions 20 PS");
                    }
                    Console.WriteLine("\tc - Skip");

                    switch (Console.ReadLine())
                    {
                        case "a":
                            int ydamage = r.Next(10, AT);
                            if (ydamage < 4)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Miss");
                                ydamage = 0;
                                Console.ResetColor();
                            }
                       

                            if (ydamage > 50)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Critial!");
                                Console.ResetColor();
                            }


                          



                            Console.WriteLine($"You have did {ydamage}");
                            Console.WriteLine($"The enemy have {PSE}");
                            PSE = PSE - ydamage;
                            break;

                        case "l":
                            if (CurationsNum == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("You don't have any potions");
                                Console.ResetColor();

                                Console.WriteLine("Your turn");
                                Console.WriteLine("\ta - Attack");

                                Console.WriteLine("\tc - Skip");

                                switch (Console.ReadLine())
                                {
                                    case "a":
                                        int ydamage2 = r.Next(10, AT);
                                        if (ydamage2 < 4)
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                                            Console.WriteLine("Miss");
                                            ydamage2 = 0;
                                            Console.ResetColor();
                                        }
                                        if (ydamage2 > 50)
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Critial!");
                                            Console.ResetColor();
                                        }
                                        break;

                                    case "c":
                                        break;
                                }



                            }

                            if (CurationsNum != 0)
                            {

                                PS = PS + 30;
                                CurationsNum = CurationsNum - 1;
                                Console.WriteLine($"+20 PS, oyu have {PS}");
                            }
                           
                            
                            break;


                        case "c":
                            break;
                    }
                }





            }
            if (PS < 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You die:(");
                Console.ResetColor();
                Console.WriteLine("You want to exit the game? Yes - \ty No - \tn");
                switch (Console.ReadLine())
                {
                    case "y":
                        Environment.Exit(0);
                        break;

                    case "n":
                        Environment.Exit(1);
                        break;
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////77
            if (PSE < 1)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You beat the enemy!!! GG");
                Console.ResetColor();
                
                Console.WriteLine("you want to exit or stay here?");
                Console.WriteLine("Exit - \te");
                Console.WriteLine("Stay here - \ts");

                switch (Console.ReadLine())
                {
                    case "e":
                        Environment.Exit(2);
                        break;

                    case "s":
                        break;

                }
            }


            ChatCleaner();
            Console.ReadLine();


        }





        public static void ChatCleaner()
        {
            Console.WriteLine("You want to clean chat?");
            Console.WriteLine("If you want TYPE \ty");
            Console.WriteLine("If you want to conserve the chat TYPE \tn");

            switch (Console.ReadLine())
            {
                case "y":
                    Console.Clear();
                    Console.WriteLine("Chat susefully cleaned");
                    break;
                case "n":

                    Console.WriteLine("Chat susefully not cleaned");
                    break;

            }
        }

    }
}
