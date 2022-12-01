using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputFile = @"C:\Users\LindokuhleB\Documents\EnverSoft\Data.csv";
            var outputFrequency = @"C:\Users\LindokuhleB\Documents\EnverSoft\frequency.txt";
            var outputAddresses = @"C:\Users\LindokuhleB\Documents\EnverSoft\addresses.txt";
            if (!File.Exists(inputFile))
            {
                Console.WriteLine("File not Exists!");
                return;
            }


            string[] Lines = File.ReadAllLines(inputFile);
            if (Lines.Length > 0)
            {
                var Frequency = new Dictionary<string, int>();
                var Addresses = new Dictionary<string, string>();
                var myClass = new Program();
                if (myClass.PopulateFrequency_Addresses(myClass, Frequency, Addresses, Lines))
                {
                    var FrequencyText = myClass.addFrequencyText(Frequency, outputFrequency);
                    var AddressText = myClass.addAddressText(Addresses, outputAddresses);
                }

                Console.WriteLine("Press <ENTER> to continue");
                Console.ReadKey();
            }
        }

        public bool PopulateFrequency_Addresses(Program myClass, Dictionary<string, int> Frequency, Dictionary<string, string> Addresses, string[] Lines)
        {
            if (Lines != null)
            {
                for (var i = 1; i < Lines.Length; i++)
                {
                    if (Lines[i].Length > 0)
                    {
                        var line = Lines[i];
                        line = myClass.AddFrequency(Frequency, line);
                        line = myClass.AddFrequency(Frequency, line);

                        myClass.AddAddress(Addresses, line);

                    }
                }
                return true;
            }
            return false;
        }

        public string AddFrequency(Dictionary<string, int> Frequency, string line)
        {
            if (line.IndexOf(',') > 0)
            {
                var name = line.Substring(0, line.IndexOf(','));
                if (Frequency.ContainsKey(name))
                {
                    Frequency[name]++;
                }
                else
                {
                    Frequency.Add(name, 1);
                }
                return line.Substring(line.IndexOf(',') + 1);
            }
            return "";
        }

        public bool AddAddress(Dictionary<string, string> Addresses, string line)
        {
            if (line.IndexOf(',') > 0)
            {
                var address = line.Substring(0, line.IndexOf(','));
                if (!Addresses.ContainsKey(address) && address.IndexOf(' ') > 0)
                {
                    Addresses.Add(address, address.Substring(address.IndexOf(' ')));
                    return true;
                }
            }
            return false;
        }

        public string addFrequencyText(Dictionary<string, int> Frequency, string location)
        {
            if (Frequency != null && location != "")
            {
                if (location.LastIndexOf('\\') > 0 && Directory.Exists(location.Substring(0, location.LastIndexOf('\\'))))
                {


                    StringBuilder frequencyContent = new StringBuilder();
                    var sortFrequency = Frequency.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                    foreach (var fr in sortFrequency)
                    {
                        frequencyContent.AppendLine(fr.Key + "," + fr.Value);
                    }
                    File.WriteAllText(location, frequencyContent.ToString());
                    return frequencyContent.ToString();

                }

                return "Not Exist";
            }
            return "";
        }

        public string addAddressText(Dictionary<string, string> Addresses, string location)
        {
            if (Addresses != null && location != "")
            {
                if (location.LastIndexOf('\\') > 0 && Directory.Exists(location.Substring(0, location.LastIndexOf('\\'))))
                {

                    StringBuilder addressContent = new StringBuilder();
                    var sortAddresses = Addresses.OrderBy(x => x.Value);

                    foreach (var address in sortAddresses)
                    {
                        addressContent.AppendLine(address.Key);
                    }
                    File.WriteAllText(location, addressContent.ToString());
                    return addressContent.ToString();
                }
                return "Not Exist";
            }
            return "";
        }

    }
}
