using System;
using System.Threading;

namespace Additional_Libraries_Date_And_Time_Continuous
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program to display the current time in the upper right corner of the screen, with the following format: 

            //12:52:03

            //it must pause for a second and display it again, in the same position.

            string time = DateTime.Now.ToLongTimeString();

            Console.SetCursorPosition(72, 1);
            Console.Write(time);
            Thread.Sleep(1000);

            Console.ReadLine();

        }
    }
}
