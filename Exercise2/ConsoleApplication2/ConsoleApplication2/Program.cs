using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = @"C:\Users\LindokuhleB\Desktop\Developer\Enversoft _ Assessment for role Senior C# Software Developer\Data.csv";
            var outputFrequency = @"C:\Users\LindokuhleB\Desktop\Developer\Enversoft _ Assessment for role Senior C# Software Developer\frequency.txt";
            var outputAddresses = @"C:\Users\LindokuhleB\Desktop\Developer\Enversoft _ Assessment for role Senior C# Software Developer\addresses.txt";
            if (!File.Exists(inputFile))
            {
                Console.WriteLine("File not Exists!");
                return;
            }

            string[] Lines = File.ReadAllLines(inputFile);
             var Frequency = new Dictionary<string, int>();
             var Addresses = new Dictionary<string, string>();
            if (Lines.Length > 0)
            {
                for (var i = 1; i < Lines.Length; i++)
                {
                    if (Lines[i].Length > 0 && Lines[i].IndexOf(',') > 0)
                    {
                        var line = Lines[i];
                        var firstName = line.Substring(0, line.IndexOf(','));
                        line = line.Substring(line.IndexOf(',')+1);
                        var lastName = line.Substring(0, line.IndexOf(','));
                        line = line.Substring(line.IndexOf(',')+1);
                        var address = line.Substring(0, line.IndexOf(','));
                        Addresses.Add(address, address.Substring(address.IndexOf(' ')));
                        AddName(Frequency, firstName);
                        AddName(Frequency, lastName);
                    }
                }

                StringBuilder frequencyContent = new StringBuilder();
                var sortFrequency = Frequency.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                foreach (var fr in sortFrequency) {
                    frequencyContent.AppendLine(fr.Key + "," + fr.Value);
                }

                StringBuilder addressContent = new StringBuilder();
                var sortAddresses = Addresses.OrderBy(x => x.Value);

                foreach (var address in sortAddresses)
                {
                    addressContent.AppendLine(address.Key);
                }
                File.WriteAllText(outputFrequency, frequencyContent.ToString());
                File.WriteAllText(outputAddresses, addressContent.ToString());
                Console.WriteLine("Press <ENTER> to continue");
                Console.ReadKey();
            }
        }
        public static void AddName(Dictionary<string,int> Frequency, string name)
        {

            if (Frequency.ContainsKey(name))
            {
                Frequency[name]++;
            }
            else
            {
                Frequency.Add(name, 1);
            }
        }
    }
}
