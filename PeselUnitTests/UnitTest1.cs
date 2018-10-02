using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeselConsole;

namespace PeselUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LosowyPeselNumerKontrolny()
        {
            Random r = new Random();      
            int a = r.Next(1, 9);
            int b = r.Next(0, 9);
            int c = r.Next(0, 9);
            int d = r.Next(0, 9);
            int e = r.Next(0, 9);
            int f = r.Next(0, 9);
            int g = r.Next(0, 9);
            int h = r.Next(0, 9);
            int i = r.Next(0, 9);
            int j = r.Next(0, 9);
            int k = r.Next(0, 9);

            string spesel = $"{a}{b}{c}{d}{e}{f}{g}{h}{i}{j}{k}";
            double pesel = Convert.ToDouble(spesel);

            double x = 9 * a + 7 * b + 3 * c + 1 * d + 9 * e + 7 * f + 3 * g + 1 * h + 9 * i + 7 * j;
            double expectedKontrolny = Char.GetNumericValue(spesel[10]);

            double kontrolny = x % 10;

            Assert.AreEqual(kontrolny, expectedKontrolny);

        }
    }
}
