using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace GameApplication
{
    //Named Constants
    //Constant Value is - int
    public enum Options
    {
        BASIC = 1, INTERMEDIATE, ADVANCED
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Word Guess Game");
            int count = 3;
            do
            {
                // Options _choice1 = default(Options);
                string message = string.Format("Enter Your Choice {0}->Basic , {1}->Intermediate ,{2}->Advanced", Options.BASIC, Options.INTERMEDIATE, Options.ADVANCED);// 1->Basic,2->Intermediate
                                                                                                                                                                         //String Interpollation 
                string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
                Console.WriteLine(displayMessage);

                try
                {
                    Options _choice = (Options)Int32.Parse(Console.ReadLine());
                    if (_choice < (Options)1 || _choice > (Options)3)
                    {
                        Console.WriteLine("invalid options");
                    }
                    else
                    {
                        switch (_choice)
                        {

                            case Options.BASIC:

                                Console.WriteLine("Basic Level");

                                LevelLib.LevelsType.GameLevel(@"C:\Users\manasa.v\source\repos\GameApplication\LevelLib\bin\Debug\BasicLevelLib.dll", "BasicLevelLib.BasicLevelType.GameLevel", "Play");
                                break;

                            case Options.INTERMEDIATE:

                                Console.WriteLine("INTERMEDIATELevel");

                                LevelLib.LevelsType.GameLevel(@"C:\Users\manasa.v\source\repos\GameApplication\LevelLib\bin\Debug\IntermediateLevelLib.dll", "IntermediateLevelLib.IntermediateLevelType.GameLevel", "Start");
                                break;

                            case Options.ADVANCED:

                                Console.WriteLine("ADVANCED Level");

                                LevelLib.LevelsType.GameLevel(@"C:\Users\manasa.v\source\repos\GameApplication\LevelLib\bin\Debug\AdvancedLevelLib.dll", "AdvancedLevelLib.AdvancedLevelType", "Begin");
                                break;


                        }
                        break;
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("choosed options must be number" + ex);
                }
                --count;

            } while (count > 0);

        }
    }

  
}
