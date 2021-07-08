using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication
{
    public enum Options
    {
        BASIC = 1, INTERMEDIATE, ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Word Guess Game");

            string message = string.Format("Enter Your Choice {0}->Basic , {1}->Intermediate ,{2}->Advanced", Options.BASIC, Options.INTERMEDIATE, Options.ADVANCED);// 1->Basic,2->Intermediate
            //String Interpollation
            try 
            { 
            string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
            Console.WriteLine(displayMessage);
            Options _choice = (Options)Int32.Parse(Console.ReadLine());
               
                    switch (_choice)
                    {
                        case Options.BASIC:
                            Console.WriteLine("Basic Level");
                            //Use Reflection  
                            //Assembly Load
                            System.Reflection.Assembly basicLevelLib =
              System.Reflection.Assembly.LoadFile(@"C:\Users\manasa.v\source\repos\GameApplication\bin\LevelLibs\BasicLevelLib.dll");
                            // Search For Class - BasicLevelType
                            System.Type basicLevelTypeClassRef = basicLevelLib.GetType("BasicLevelLib.BasicLevelType");
                            if (basicLevelTypeClassRef != null)
                            {
                                if (basicLevelTypeClassRef.IsClass)
                                {
                                   
                                    Object objRef = System.Activator.CreateInstance(basicLevelTypeClassRef); //LateBinding Code
                                                                                                             //Discove Method
                                    System.Reflection.MethodInfo _methodRef = basicLevelTypeClassRef.GetMethod("Play");
                                    if (!_methodRef.IsStatic)
                                    {
                                        //Invoke NonStatic Method
                                        // string Play(string playerName, int earlierPoints){}
                                        //object result=  _methodRef.Invoke(objRef, new object[] {"Tom",20 });
                                        object result = _methodRef.Invoke(objRef, new object[] {  });
                                        Console.WriteLine(result.ToString());
                                    }

                                }


                            }

                            break;
                        case Options.INTERMEDIATE:
                            Console.WriteLine("Intermediate Level");
                            System.Reflection.Assembly IntermediateLevelLib =
             System.Reflection.Assembly.LoadFile(@"C:\Users\manasa.v\source\repos\GameApplication\bin\LevelLibs\IntermediateLevelLib.dll");
                            // Search For Class - IntermediateLevelType
                            System.Type IntermediateLevelTypeClassRef = IntermediateLevelLib.GetType("IntermediateLevelLib.BasicLevelType");
                            if (IntermediateLevelTypeClassRef != null)
                            {
                                if (IntermediateLevelTypeClassRef.IsClass)
                                {
                                    Object objRef = System.Activator.CreateInstance(IntermediateLevelTypeClassRef); //LateBinding Code
                                                                                                                    //Discove Method
                                    System.Reflection.MethodInfo _methodRef = IntermediateLevelTypeClassRef.GetMethod("Start");
                                    if (!_methodRef.IsStatic)
                                    {
                                       
                                       
                                        object result = _methodRef.Invoke(objRef, new object[] {  });
                                        Console.WriteLine(result.ToString());
                                    }

                                }

                            }
                            break;
                        case Options.ADVANCED:
                            Console.WriteLine("Advanced Level");
                            System.Reflection.Assembly AdvanceLevelLib =
            System.Reflection.Assembly.LoadFile(@"C:\Users\manasa.v\source\repos\GameApplication\bin\LevelLibs\AdvanceLevelLib.dll");
                            // Search For Class - AdvanceLevelType
                            System.Type AdvanceLevelTypeClassRef = AdvanceLevelLib.GetType("AdvanceLevelLib.AdvanceLevelType");
                            if (AdvanceLevelTypeClassRef != null)
                            {
                                if (AdvanceLevelTypeClassRef.IsClass)
                                {

                                    Object objRef = System.Activator.CreateInstance(AdvanceLevelTypeClassRef); //LateBinding Code
                                                                                                               //Discove Method
                                    System.Reflection.MethodInfo _methodRef = AdvanceLevelTypeClassRef.GetMethod("Begin");
                                    if (!_methodRef.IsStatic)
                                    {
                                       
                                        //object result=  _methodRef.Invoke(objRef, new object[] {});
                                        object result = _methodRef.Invoke(objRef, new object[] { "xyz", 300 });
                                        Console.WriteLine(result.ToString());
                                    }

                                }

                            }
                            break;

                    default:Console.WriteLine("invalid number");
                        this.count++;
                        if (this.count ==3)
                        {

                        }

                    }
                

            }
            catch (Exception ex)
            {
                throw new IndexOutOfRangeException("select the valid number " + ex);
            }
            finally { }

        }
    }
}
