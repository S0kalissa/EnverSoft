using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using ConsoleApplication2;

namespace UnitTestAddressFrequency
{
    [TestClass]
    public class UnitTest1
    {
        
        private string inputFile;
        private string outputAddresses;
        private string outputFrequency;
        private string line;
        Program myClass = new Program();
        Dictionary<string, int> Frequency = new Dictionary<string, int>();
        Dictionary<string, string> Addresses = new Dictionary<string, string>();

        [TestMethod]
        public void PopulateFrequency_Addresses_Positive()
        {
            inputFile = @"C:\Users\LindokuhleB\Desktop\Developer\Enversoft _ Assessment for role Senior C# Software Developer\Data.csv";
            var expected = true;
            string[] Lines = File.ReadAllLines(inputFile);
            var result = myClass.PopulateFrequency_Addresses(myClass,Frequency, Addresses, Lines);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PopulateFrequency_Addresses_Negative()
        {
            var expected = false;
            var result =myClass.PopulateFrequency_Addresses(myClass,Frequency, Addresses, null);
            Assert.AreEqual(expected, result);
        }

    [TestMethod]
        public void AddFrequency_Positive()
        {
            var expected = "Clive,65 Ambling Way,123";
            line = "Brown,Clive,65 Ambling Way,123";
            var result = myClass.AddFrequency(Frequency, line);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddFrequency_Negative()
        {
            var expected = "";
            line = "Clive 65 Ambling Way 123";
            var result = myClass.AddFrequency(Frequency, line);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddAddress_Positive()
        {
            var expected = true;
            line = "65 Ambling Way,123";
            var result = myClass.AddAddress(Addresses, line);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddAddress_Negative()
        {
            var expected = false;
            line = "Clive 65 Ambling Way 123";
            var result = myClass.AddAddress(Addresses, line);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void addFrequencyText_Positive()
        {
            var expected = "Brown,1";
            Frequency.Add("Brown", 1);
            var outputFrequency = @"C:\Users\LindokuhleB\Desktop\Developer\Enversoft _ Assessment for role Senior C# Software Developer\frequency.txt";
            var result =  myClass.addFrequencyText(Frequency, outputFrequency);
            Assert.IsTrue(result.Contains(expected));
        }

        [TestMethod]
        public void addFrequencyText_Negative()
        {
            var expected = "Not Exist";
            outputFrequency = "tempLocation";
            var results = myClass.addFrequencyText(Frequency,outputFrequency);
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void addAddressText_Positive()
        {
            var expected = "65 Ambling Way";

            var outputAddresses = @"C:\Users\LindokuhleB\Desktop\Developer\Enversoft _ Assessment for role Senior C# Software Developer\addresses.txt";
            Addresses.Add("65 Ambling Way", "Ambling Way");
            var result = myClass.addAddressText(Addresses, outputAddresses);
            Assert.IsTrue(result.Contains(expected));
        }

        [TestMethod]
        public void addAddressText_Negative()
        {
            var expected = "";
            outputAddresses = "";
            var results = myClass.addAddressText(Addresses, outputAddresses);
            Assert.AreEqual(results,expected);
        }

       
    }
}
