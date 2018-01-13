using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO; //file
using static System.Console; //console
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Net.WebRequestMethods;

namespace DesigningPatterns
{
    //single responsibility principle in SOLID demo
    //eg: I want ot have a journal
    public class Journal
    {
        //readonly list of my entries
        private readonly List<string> entries = new List<string>();
        //keep account of all my elements
        private static int count = 0;

        /*** Journal resposbility of keeping the entries****/
        //method to add entries
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; //momento pattern
        }

        //method to remove entry
        public void RemoveRntry(int index)
        {
            entries.RemoveAt(index); //not a valid way to remove the entry by index 
        }

        //ToString implementation, outputing them to string
        public override string ToString()
        {
            //return base.ToString();
            //I will just join all the entries
            return string.Join(Environment.NewLine, entries);
        }

        /*** Voilation by putting additional resposbilities of managing the presistence****/
        //method to save eg. to a file
        //method to load our journal from a file
        //method to load from URI
    }


    /*** not voilating by adding new class to handle the presistence changes****/
    public class presistence
    {
        //method to save eg. to a file
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, j.ToString());
            }
        }
        //method to load our journal from a file
        //method to load from URI
    }

}
    //entry point in demo class
    //public class SPrinciple
    //{
        //static void Main(string[] args)
        //{
        //    //demo of our journal
        //    var j = new Journal();
        //    j.AddEntry("Single responsibility principle");
        //    j.AddEntry("only single reason to change sounds inefficient");
        //    j.AddEntry("lets see...");
        //    WriteLine(j);

        //    /***side-effect is that we dont have seperation of concern here***/
        //    var p = new presistence();
        //    var filename = @"C:\...\Design_Patterns\journal.txt";
        //    p.SaveToFile(j, filename, true);
        //    Process.Start(filename); //see if it works
        //}
    //}
//}
