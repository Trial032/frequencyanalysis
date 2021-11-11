using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FrequencyAnalysis fa = new FrequencyAnalysis();
            fa.Load("frekvencnianalyza.txt");
        }
    }

    public class FrequencyAnalysis
    {
        Dictionary<string, double> _frequency = new Dictionary<string, double>();
        public void Load(string filepath)
        {
            if (!File.Exists(filepath))
            {
                Console.WriteLine("Soubor neexistuje");
                Console.ReadKey();
                return;
            }
            string[] file = File.ReadAllLines(filepath);
            foreach (var item in file)
            {
                string[] letter = item.Split(";");
                _frequency.Add(letter[0], Convert.ToDouble(letter[1]));
            }
            
        }

        public void Analysis(string cipher)
        {

        }
    }
}
