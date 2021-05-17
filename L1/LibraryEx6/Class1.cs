using System;

namespace LibraryEx6
{
    public class Class1
    {
        static void message(string a, string b, string c)
        {
            string d = a + " " + b + " " + c;
            int centerX = (Console.WindowWidth / 2) - (d.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(d);
        }
}
