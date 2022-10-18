using System;
using ATMApp.UI;

namespace ATMApp.App
{
    public class Entry
    {
        static void Main(string[] args)
        {

            ATMApp atmApp = new ATMApp();
            atmApp.InitializeData();
            atmApp.Run();


            Utility.PressEnterToContinue();
        }
    }
}
