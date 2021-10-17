using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsolePasswordGenerator;
using System;
using System.IO;

namespace PasswordGeneratorTests
{
    [TestClass]
    public class GeneratorTests
    {
        [TestMethod]
        [DataRow(20, true, true, false, true)]
        [DataRow(2419824, false, false, false, true)]
        [DataRow(2, true, true, true, true)]
        [DataRow(10, true, false, false, true)]
        public void GenerateCorrectPassword(int lenght, bool numbers, bool symbols, bool lower, bool upper)
        {

            //arrange
            PasswordDetails password = new PasswordDetails((uint)lenght, numbers, symbols, lower, upper);

            //act
            var generatedPassword = PasswordGenerator.GeneratePassword(password);

            //assert
            Assert.AreEqual(lenght, generatedPassword.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), "Cannot make password of lenght == 0")]
        public void TryToGeneratePasswordWith0Lenght()
        {
            //arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader("0");
            Console.SetIn(stringReader);

            //act
            DataReciver.GetLenght();
        }

        [TestMethod]
        [DataRow(0.6)]
        [DataRow(200.9999)]
        [DataRow(-123.5)]
        [DataRow(-0.0000001)]
        [ExpectedException(typeof(ArgumentException), "Cannot convert input value.")]
        public void TryToGenerateWhenInputIsNotInt(int lenght)
        {
            //arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(lenght.ToString());
            Console.SetIn(stringReader);

            //act
            DataReciver.GetLenght();
        }
    }
}
