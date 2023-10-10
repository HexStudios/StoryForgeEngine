using System;

namespace StoryForgeEngine
{
    public static class SFEngine
    {
        public static void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"SFEngine: {text}");
            Console.ResetColor();
        }
        public static void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"SFEngine: {text}");
            Console.ResetColor();
        }
        public static void PrintError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"SFEngine ERROR: {text}");
            Console.ResetColor();
        }
        public static void PrintWarning(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"SFEngine WARNING: {text}");
            Console.ResetColor();
        }
        
    }
}