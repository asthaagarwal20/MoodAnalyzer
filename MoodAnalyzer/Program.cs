using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Program
    {

        public string Test(string mood)
        {
            bool found = false;
            string temp = null;
            mood = mood + " ";
            for(int i=0;i<mood.Length;i++)
            {
                if (mood[i] != ' ')
                    temp=temp + mood[i];
                else
                {
                    if (temp == "sad")
                    {
                        found = true;
                        break;
                    }
                    temp = "";
                }
            }
            if (found)
                return "sad";
            else
                return "happy";
        }
        static void Main(string[] args)
        {
        }
    }
}
