using System;

namespace StoryForgeEngine
{
    public static class SFEngine
    {
        public static void PrintError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"SFEngine ERROR: {text}");
            Console.ResetColor();
        }
    }
}