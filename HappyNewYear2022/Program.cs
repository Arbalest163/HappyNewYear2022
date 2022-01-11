using System;

namespace HappyNewYear2022
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Print.Phrase("ПОЗДРАВЛЯЮ");
                Print.Delay(0.1);
                Print.Phrase("С");
                Print.Delay(0.1);
                Print.Phrase("НОВЫМ");
                Print.Delay(0.1);
                Print.Phrase("ГОДОМ!!!");
                Print.Delay(0.5);
                Print.Clear();
            }
        }
    }
}
