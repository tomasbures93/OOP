using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphie___Versandservice.Models;

namespace Polymorphie___Versandservice
{
    internal class Program
    {
        static Packstation packstation = new Packstation("Bochum 44805");
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n\tInteraktive Mailbox system DR.Heuer");
                Console.WriteLine($"\n\tPackstation: {packstation.GetName()}\n");
                Console.WriteLine("\tMenu\n");
                Console.WriteLine("\t1 - Send Letter");
                Console.WriteLine("\t2 - Send Package");
                Console.WriteLine("\t3 - Track Package");
                Console.WriteLine("\t4 - Mailbox info");
                Console.WriteLine("\t5 - RoyalMail service portal");
                Console.WriteLine("\t6 - Exit");
                DrawPost();
                string input = Console.ReadLine().ToLower();
                if (string.IsNullOrEmpty(input)) input = "0";
                switch (input[0])
                {
                    case '1':
                        SendLetter();
                        break;
                    case '2':
                        SendPackage();
                        break;
                    case '3':
                        TrackPackage();
                        break;
                    case '4':
                        ShowInfo();
                        break;
                    case '5':
                        RoyalMail();
                        Console.ReadKey();
                        break;
                    case '6':
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\tThanks for using our System.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tWrong input, try again.\n\tPress Enter to Continue");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                }
            } while (true);

        }
        public static void TrackPackage()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n\tPlease insert package ID you want to track");
                if(int.TryParse(Console.ReadLine(), out int ID))
                {
                    packstation.PaketVerfolgung(ID);
                    Console.ReadKey();
                    break;
                } else
                {
                    Console.WriteLine("\n\tWrong input");
                    Console.ReadKey();
                    break;
                }
            } while (true);
        }


        public static void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("\n\tInfo Portal\n");
            packstation.PackstationPublicInfo();
            DrawPost();
            Console.ReadKey();
        }

        public static void SendPackage()
        {
            string input = "";
            double gewicht;
            bool versicherung = false;
            bool tracking = false;
            string[] vorname = new string[2];
            string[] nachname = new string[2];
            string[] strhaus = new string[2];
            string[] plzort = new string[2];
            string[] land = new string[2];
            do
            {
                Console.Clear();
                Console.WriteLine("\n\tHow to send a package\n");
                Console.WriteLine("\t1) Insert weight\n\t2) Insurance ( y / n )\n\t3) Type Sender\n\t4) Package tracking ( y / n )\n\t5) Type in Reciever\n\t6) Control your order\n\t7) Send or Change your order\n");
                Console.WriteLine("\tPress Enter to start.");
                DrawPost();
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n\tHow heavy is the package (kg) ?");
                    if(double.TryParse(Console.ReadLine(), out gewicht))
                    {
                        Console.WriteLine($"\n\tPackage: {gewicht} kg");
                        Console.ReadKey();
                        break;
                    } else
                    {
                        Console.WriteLine("\n\tWrong input, please try it again.");
                        Console.WriteLine("\tPress Enter to continue");
                        Console.ReadKey();
                    }
                } while (true);
                Console.Clear();
                Console.WriteLine("\n\tWould you like to insure your package ( y / n )");
                input = Console.ReadLine().ToLower();
                if (input[0] == 'y')
                {
                    versicherung = true;
                    Console.WriteLine("\n\tYour Package will be insured!");
                } else
                {
                    versicherung = false;
                    Console.WriteLine("\n\tYour Package will not be insured!");
                }
                Console.WriteLine("\tPress Enter to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\n\tWould you like to track your package ( y / n )?");
                input = Console.ReadLine().ToLower();
                if (input[0] == 'y')
                {
                    tracking = true;
                    Console.WriteLine("\n\tYour Package will be tracked!");
                }
                else
                {
                    tracking = false;
                    Console.WriteLine("\n\tYour Package will not be tracked!");
                }
                Console.ReadKey();
                Console.Clear();
                do
                {
                    Console.WriteLine($"\n\tPlease Insert Sender");
                    Console.Write($"\tFirst Name: ");
                    vorname[0] = Console.ReadLine();
                    Console.Write($"\tLast Name: ");
                    nachname[0] = Console.ReadLine();
                    Console.Write($"\tStreet + House number: ");
                    strhaus[0] = Console.ReadLine();
                    Console.Write($"\tCity Code + City: ");
                    plzort[0] = Console.ReadLine();
                    Console.Write($"\tCountry: ");
                    land[0] = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine($"\n\tPlease Insert Reciever");
                    Console.Write($"\tFirst Name: ");
                    vorname[1] = Console.ReadLine();
                    Console.Write($"\tLast Name: ");
                    nachname[1] = Console.ReadLine();
                    Console.Write($"\tStreet + House number: ");
                    strhaus[1] = Console.ReadLine();
                    Console.Write($"\tCity Code + City: ");
                    plzort[1] = Console.ReadLine();
                    Console.Write($"\tCountry: ");
                    land[1] = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine($"\n\tPackage Info");
                    Console.WriteLine($"\n\tWeight: {gewicht}");
                    Console.WriteLine($"\tInsurance: {versicherung}\n");
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {
                            Console.WriteLine($"\tSender Information");
                        }
                        else
                        {
                            Console.WriteLine($"\n\tReciever Information");
                        }
                        Console.WriteLine($"\tName: {vorname[i]} {nachname[i]}");
                        Console.WriteLine($"\tStreet: {strhaus[i]}");
                        Console.WriteLine($"\tCity: {plzort[i]}");
                        Console.WriteLine($"\tLand: {land[i]}");
                    }
                    Console.WriteLine("\n\tAre those information Correct ( y / n )?");
                    input = Console.ReadLine().ToLower();
                    if (input[0] == 'y')
                    {
                        Console.WriteLine("\n\tYour package will be send shortly.");
                        packstation.NeuePaket(
                                new Adresse(nachname[0], vorname[0], strhaus[0], plzort[0], land[0]),
                                new Adresse(nachname[1], vorname[1], strhaus[1], plzort[1], land[1]),
                                gewicht,
                                versicherung,
                                tracking);
                        int id = packstation.GetLastID();
                        if (tracking == true)
                        {
                            Console.WriteLine($"\n\tYou can track your package with ID {id}");
                        }
                            break;
                    }
                    else if (input[0] == 'n')
                    {
                        Console.WriteLine("\n\tOkay, lets go thru again.");
                        Console.WriteLine("\tPress enter to Continue");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\n\tWrong input - lets go thru again.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (true);
                Console.ReadKey();
                break;
            } while (true);
        }

        public static void SendLetter()
        {
            string input = "";
            BriefTyp briefTyp;
            string[] vorname = new string[2];
            string[] nachname = new string[2];
            string[] strhaus = new string[2];
            string[] plzort = new string[2];
            string[] land = new string[2];
            do
            {
                Console.Clear();
                Console.WriteLine("\n\tHow to send a letter\n");
                Console.WriteLine("\t1) Choose a type of Letter\n\t2) Type in Sender\n\t3) Type in Reciever\n\t4) Control your order\n\t5) Send or Change your order\n");
                Console.WriteLine("\tPress Enter to start.");
                DrawPost();
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n\tWhich type of Letter would you like to send?\n");
                    Console.WriteLine("\t1 - Standart");
                    Console.WriteLine("\t2 - Eilbrief");
                    Console.WriteLine("\t3 - Einschreiben");
                    input = Console.ReadLine();
                    switch (input[0])
                    {
                        case '1':
                            briefTyp = BriefTyp.Standartbrief;
                            Console.WriteLine($"\n\tLetter type set to: {briefTyp.ToString()}");
                            break;
                        case '2':
                            briefTyp = BriefTyp.Eilbrief;
                            Console.WriteLine($"\n\tLetter type set to: {briefTyp.ToString()}");
                            break;
                        case '3':
                            briefTyp = BriefTyp.Einschreiben;
                            Console.WriteLine($"\n\tLetter type set to: {briefTyp.ToString()}");
                            break;
                        default:
                            briefTyp = BriefTyp.Standartbrief;
                            Console.WriteLine($"Wrong input. Letter type set to: {briefTyp.ToString()}");
                            break;
                    }
                    Console.ReadKey();
                    break;
                } while (true);
                Console.Clear();
                Console.WriteLine($"\n\tYour order\n\tLetter type: {briefTyp.ToString()}");
                do
                {
                    Console.WriteLine($"\n\tPlease Insert Sender");
                    Console.Write($"\tFirst Name: ");
                    vorname[0] = Console.ReadLine();
                    Console.Write($"\tLast Name: ");
                    nachname[0] = Console.ReadLine();
                    Console.Write($"\tStreet + House number: ");
                    strhaus[0] = Console.ReadLine();
                    Console.Write($"\tCity Code + City: ");
                    plzort[0] = Console.ReadLine();
                    Console.Write($"\tCountry: ");
                    land[0] = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine($"\n\tPlease Insert Reciever");
                    Console.Write($"\tFirst Name: ");
                    vorname[1] = Console.ReadLine();
                    Console.Write($"\tLast Name: ");
                    nachname[1] = Console.ReadLine();
                    Console.Write($"\tStreet + House number: ");
                    strhaus[1] = Console.ReadLine();
                    Console.Write($"\tCity Code + City: ");
                    plzort[1] = Console.ReadLine();
                    Console.Write($"\tCountry: ");
                    land[1] = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine($"\n\tLetter type: {briefTyp.ToString()}\n");
                    for (int i = 0; i < 2; i++)
                    {
                        if(i == 0)
                        {
                            Console.WriteLine($"\tSender Information");
                        } else
                        {
                            Console.WriteLine($"\n\tReciever Information");
                        }
                        Console.WriteLine($"\tName: {vorname[i]} {nachname[i]}");
                        Console.WriteLine($"\tStreet: {strhaus[i]}");
                        Console.WriteLine($"\tCity: {plzort[i]}");
                        Console.WriteLine($"\tLand: {land[i]}");
                    }
                    Console.WriteLine("\n\tAre those information Correct ( y / n )?");
                    input = Console.ReadLine().ToLower();
                    if (input[0] == 'y')
                    {
                        Console.WriteLine("\n\tYour letter will be send shortly.");
                        packstation.NeueBrief(
                                new Adresse(nachname[0], vorname[0], strhaus[0], plzort[0], land[0]),
                                new Adresse(nachname[1], vorname[1], strhaus[1], plzort[1], land[1]),
                                briefTyp);
                        break;
                    } else if (input[0] == 'n')
                    {
                        Console.WriteLine("\n\tOkay, lets go thru again.");
                        Console.WriteLine("\tPress enter to Continue");
                        Console.ReadKey();
                        Console.Clear();
                    } else
                    {
                        Console.WriteLine("\n\tWrong input - lets go thru again.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (true);
                Console.ReadKey();
                break;
            } while (true);
        }

        public static void RoyalMail()
        {
            int counter = 1;
            string input = "";
            do
            {
                Console.Clear();
                Console.WriteLine($"\n\tPlease Log in | Attempt: {counter} / 3\n");
                Console.Write("\tLogin: ");
                string name = Console.ReadLine();
                if(name == "exit")
                {
                    break;
                }
                Console.Write("\tPassword: ");
                string password = Console.ReadLine();
                if(name == "Tomas" && password == "Tomas")
                {
                    bool getout = false;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tWelcome User in Package Management system.\n");
                        Console.WriteLine($"\tName: {packstation.GetName()}");
                        Console.WriteLine($"\tOccupancy: {packstation.GetOccupancy()} / XXX");
                        Console.WriteLine("\n\tMenu");
                        Console.WriteLine("\t1 - Show all Letters");
                        Console.WriteLine("\t2 - Show all Packages");
                        Console.WriteLine("\t3 - Show everything");
                        Console.WriteLine("\t4 - Check Adresses and send.");
                        Console.WriteLine("\t5 - Move Package with tracking.");
                        Console.WriteLine("\t6 - Exit\n");
                        input = Console.ReadLine().ToLower();
                        if (string.IsNullOrEmpty(input)) input = "6";
                        switch (input[0])
                        {
                            case '1':
                                Console.Clear();
                                packstation.PackstationBriefInfo();
                                Console.ReadKey();
                                break;
                            case '2':
                                Console.Clear();
                                packstation.PackstationPaketInfo();
                                Console.ReadKey();
                                break;
                            case '3':
                                Console.Clear();
                                ShowPackstationInfo();
                                Console.ReadKey();
                                break;
                            case '4':
                                Console.Clear();
                                packstation.Ausliefern();
                                Console.ReadKey();
                                break;
                            case '5':
                                Console.Clear();
                                MovePackage();
                                Console.ReadKey();
                                break;
                            case '6':
                                getout = true;
                                break;
                            default:
                                Console.WriteLine("\tWrong input - try again");
                                Console.WriteLine("\tPress Enter to try again");
                                Console.ReadKey();
                                break;
                        }
                        
                    } while (getout == false);
                    Console.WriteLine("I am out");
                    Console.ReadKey();
                } else
                {
                    if (counter == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tWrong Login or Password.\n\tThat was your third attemt.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tWrong Login or Password.\n\tPress Enter to try again");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    counter++;
                }
                Console.ReadKey();
                
            } while (true);
        }

        public static void MovePackage()
        {
            Console.Clear();
            packstation.PackstationVerPaketInfo();
            do
            {
                Console.WriteLine("\n\tPlease insert package ID you want to move");
                if (int.TryParse(Console.ReadLine(), out int ID))
                {
                    Console.WriteLine("\n\tPlease insert new Adress");
                    string input = Console.ReadLine();
                    packstation.MovePackage(ID, input);
                    Console.WriteLine("Package was moved.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("\n\tWrong input");
                    Console.ReadKey();
                    break;
                }
            } while (true);
        }

        public static void ShowPackstationInfo()
        {
            Console.Clear();
            Console.WriteLine($"\tOccupancy: {packstation.GetOccupancy()} / 200\n");
            packstation.PackstationPrivateInfo();
        }

        public static void DrawPost()
        {
            Console.SetCursorPosition(50, 1);
            Console.WriteLine("       _________");
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("     .`.        `.");
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("    /   \\ .======.\\ ");
            Console.SetCursorPosition(50, 4);
            Console.WriteLine("    |   | | _____||");
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("    |   |   _____ | ");
            Console.SetCursorPosition(50, 6);
            Console.WriteLine("    |   |  /    / | ");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("    |   | /____/  | ");
            Console.SetCursorPosition(50, 8);
            Console.WriteLine("    | _ |         | ");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine("    |/ \\|.-\"```\"-.| ");
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("    `` |||      ||| ");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("       `\"`      `\" ");
        }
    }
}
