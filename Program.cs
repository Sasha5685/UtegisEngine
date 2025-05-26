using System;

namespace UtegisEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EngineWindow EngineWindow = new EngineWindow())
            {
                EngineWindow.Run();
            }
        }
    }
}