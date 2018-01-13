using System;
using static System.Console;

namespace DesigningPatterns
{
    public class Demo
    {
        //static method that returns area
        static public int Area(Rectangle rc) => rc.Height * rc.Width;
        //main method
        static void Main(string[] args)
        {
            /***SPrinciple entrypoint***/
            //var j = new Journal();
            //j.AddEntry("Single responsibility principle");
            //j.AddEntry("only single reason to change sounds inefficient");
            //j.AddEntry("lets see...");
            //WriteLine(j);

            ///***side-effect is that we dont have seperation of concern here***/
            //var p = new presistence();
            //var filename = @"C:\...\Design_Patterns\journal.txt";
            //p.SaveToFile(j, filename, true);
            //Process.Start(filename); //see if it works
            
            /***LSPrinciple entrypoint***/
            Rectangle r = new Rectangle(2, 4);
            //WriteLine(r);
            WriteLine($"({r}) has area{r.Area(r)}");
            //should be able to substitute a base type for a subtye
            //eg: have a square reference to rectangle
            Rectangle s = new Square();
            s.Height = 2;
            WriteLine($"({s}) has area {s.Area(s)}");
        }
    }
}
