﻿namespace AcademyApp.Helper
{
    public class Helper
    {
        public static void ChangeColor(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
