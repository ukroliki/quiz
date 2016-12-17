using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using quiz;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Exist()
        {
            // тест на существование файлов
            int expected = 0;
            int test = Program.Input();
            Assert.AreEqual(expected, test);
        }
        
        [TestMethod]
        public void Win()
        {
            // тест на выйгрыш 
            Program.queezNum = 20;
            int expected = 8;
            int test = Program.Game(Program.queezNum);
            Assert.AreEqual(expected, test);
        }

        [TestMethod]
        public void Right()
        {
            // тест на правильность ответа
            int expected = 0;
            Program.queezNum = 0;
            Console.SetIn(new StreamReader("test.txt"));
            int test = Program.Game(Program.queezNum);
            Assert.AreEqual(expected, test);
        }

        [TestMethod]
        public void Wrong()
        {
            // тест на неправильность ответа
            int expected = 4;
            Program.queezNum = 16;
            Console.SetIn(new StreamReader("test.txt"));
            int test = Program.Game(Program.queezNum);
            Assert.AreEqual(expected, test);
        }

        [TestMethod]
        public void Unreal()
        {
            // тест на неправильный ввод
            int expected = 6;
            Program.queezNum = 12;
            Console.SetIn(new StreamReader("test1.txt"));
            int test = Program.Game(Program.queezNum);
            Assert.AreEqual(expected, test);
        }

    }
}
