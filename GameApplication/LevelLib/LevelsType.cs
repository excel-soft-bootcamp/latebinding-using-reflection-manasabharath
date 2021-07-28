using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LevelLib
{
    public class LevelsType
    {
        public static void GameLevel(string getPath, string getType, string getMethod)
        {
            Assembly executingAssembly = Assembly.LoadFile(getPath);
            Type _levelsTypeClassRef = executingAssembly.GetType(getType);
            if (_levelsTypeClassRef != null && _levelsTypeClassRef.IsClass)
            {
                Object _levelsTypeObjRef = Activator.CreateInstance(_levelsTypeClassRef);

                MethodInfo _getMethodRef = _levelsTypeClassRef.GetMethod(getMethod);
                if (!_getMethodRef.IsStatic)
                {
                    if (getMethod == "Play")
                    {
                        Object[] _parameters = new Object[0];
                        string play = (string)_getMethodRef.Invoke(_levelsTypeObjRef, _parameters);
                        Console.WriteLine($"{play} started");
                        Console.ReadKey();
                    }
                    if (getMethod == "Start")
                    {
                        Object[] _parameters = new Object[1];
                        _parameters[0] = "abc";
                        string start = (string)_getMethodRef.Invoke(_levelsTypeObjRef, _parameters);
                        Console.WriteLine($"{start} started");
                        Console.ReadKey();
                    }
                    if (getMethod == "Begin")
                    {
                        Object[] _parameters = new Object[2];
                        _parameters[0] = "abc";
                        _parameters[1] = 100;
                        string begin = (string)_getMethodRef.Invoke(_levelsTypeObjRef, _parameters);
                        Console.WriteLine($"{begin} started ");
                        Console.ReadKey();
                    }

                }

            }

        }
    }
}
