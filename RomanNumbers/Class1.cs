using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class Class1
    {
        private readonly ArabicNumberToRomanConverter _arabicNumberToRomanConverter = new ArabicNumberToRomanConverter();

        [TestMethod]
        public void test1()
        {
            Assert.AreEqual("I", _arabicNumberToRomanConverter.value(1));
        }

        [TestMethod]
        public void test2()
        {
            Assert.AreEqual("II", _arabicNumberToRomanConverter.value(2));
        }

        [TestMethod]
        public void test3()
        {
            Assert.AreEqual("III", _arabicNumberToRomanConverter.value(3));
        }

        [TestMethod]
        public void test4()
        {
            Assert.AreEqual("IV", _arabicNumberToRomanConverter.value(4));
        }

        [TestMethod]
        public void test5()
        {
            Assert.AreEqual("V", _arabicNumberToRomanConverter.value(5));
        }

        [TestMethod]
        public void test6()
        {
            Assert.AreEqual("VI", _arabicNumberToRomanConverter.value(6));
        }

        [TestMethod]
        public void test7()
        {
            Assert.AreEqual("VII", _arabicNumberToRomanConverter.value(7));
        }

        [TestMethod]
        public void test8()
        {
            Assert.AreEqual("VIII", _arabicNumberToRomanConverter.value(8));
        }


        [TestMethod]
        public void test9()
        {
            Assert.AreEqual("IX", _arabicNumberToRomanConverter.value(9));
        }


        [TestMethod]
        public void test10()
        {
            Assert.AreEqual("X", _arabicNumberToRomanConverter.value(10));
        }

        [TestMethod]
        public void test11()
        {
            Assert.AreEqual("XI", _arabicNumberToRomanConverter.value(11));
        }


        [TestMethod]
        public void test12()
        {
            Assert.AreEqual("XII", _arabicNumberToRomanConverter.value(12));
        }


        [TestMethod]
        public void test13()
        {
            Assert.AreEqual("XIII", _arabicNumberToRomanConverter.value(13));
        }

        [TestMethod]
        public void test14()
        {
            Assert.AreEqual("XIV", _arabicNumberToRomanConverter.value(14));
            Assert.AreEqual("XV", _arabicNumberToRomanConverter.value(15));
            Assert.AreEqual("XVI", _arabicNumberToRomanConverter.value(16));
        }

        [TestMethod]
        public void test19()
        {
            Assert.AreEqual("XIX", _arabicNumberToRomanConverter.value(19));
        }

        [TestMethod]
        public void test20()
        {
            Assert.AreEqual("XX", _arabicNumberToRomanConverter.value(20));
            Assert.AreEqual("XXI", _arabicNumberToRomanConverter.value(21));
            Assert.AreEqual("XXV", _arabicNumberToRomanConverter.value(25));
            Assert.AreEqual("XXVI", _arabicNumberToRomanConverter.value(26));
            Assert.AreEqual("XXIX", _arabicNumberToRomanConverter.value(29));
        }

        [TestMethod]
        public void test30()
        {
            Assert.AreEqual("XXX", _arabicNumberToRomanConverter.value(30));
            Assert.AreEqual("XXXI", _arabicNumberToRomanConverter.value(31));
            Assert.AreEqual("XXXV", _arabicNumberToRomanConverter.value(35));
            Assert.AreEqual("XXXVI", _arabicNumberToRomanConverter.value(36));
            Assert.AreEqual("XXXIX", _arabicNumberToRomanConverter.value(39));
        }

        [TestMethod]
        public void test40()
        {
            Assert.AreEqual("XL", _arabicNumberToRomanConverter.value(40));
            Assert.AreEqual("L", _arabicNumberToRomanConverter.value(50));
            Assert.AreEqual("LX", _arabicNumberToRomanConverter.value(60));
            Assert.AreEqual("LXX", _arabicNumberToRomanConverter.value(70));
            Assert.AreEqual("LXXX", _arabicNumberToRomanConverter.value(80));
            Assert.AreEqual("XC", _arabicNumberToRomanConverter.value(90));
        }


        [TestMethod]
        public void testCentenas()
        {
            Assert.AreEqual("C", _arabicNumberToRomanConverter.value(100));
            Assert.AreEqual("CI", _arabicNumberToRomanConverter.value(101));
            Assert.AreEqual("CXI", _arabicNumberToRomanConverter.value(111));
            Assert.AreEqual("CCXXII", _arabicNumberToRomanConverter.value(222));
            Assert.AreEqual("CCCXXXIII", _arabicNumberToRomanConverter.value(333));
            Assert.AreEqual("CDXLIV", _arabicNumberToRomanConverter.value(444));
            Assert.AreEqual("DLV", _arabicNumberToRomanConverter.value(555));
            Assert.AreEqual("DCLXVI", _arabicNumberToRomanConverter.value(666));
            Assert.AreEqual("DCCLXXVII", _arabicNumberToRomanConverter.value(777));
            Assert.AreEqual("DCCCLXXXVIII", _arabicNumberToRomanConverter.value(888));
            Assert.AreEqual("CMXCIX", _arabicNumberToRomanConverter.value(999));           

        }
    }
}
