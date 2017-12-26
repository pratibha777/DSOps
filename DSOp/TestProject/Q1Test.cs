using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview;

namespace TestInterview
{
    [TestClass]
    public class Q1Test
    {
        [TestMethod]
        public void Test_ReverseWords1()
        {
            Q1 objInterview = new Q1();
            string sentence = "efficient more and safer smarter, agencies transit makes that technology the provide We";
            string expected = "We provide the technology that makes transit agencies smarter, safer and more efficient";
            string actual = objInterview.ReverseWords1(sentence);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_ReverseWords1_IsEmptyString()
        {
            Q1 objInterview = new Q1();
            string sentence = "";
            string expected = "";
            string actual = objInterview.ReverseWords1(sentence);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_ReverseWords1_IsNull()
        {
            Q1 objInterview = new Q1();
            string sentence = null;
            string expected = "";
            string actual = objInterview.ReverseWords1(sentence);
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void Test_ReverseWords2()
        {
            Q1 objInterview = new Q1();
            string sentence = "efficient more and safer smarter, agencies transit makes that technology the provide We";
            string expected = "We provide the technology that makes transit agencies smarter, safer and more efficient";
            string actual = objInterview.ReverseWords2(sentence);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_ReverseWords2_IsEmptyString()
        {
            Q1 objInterview = new Q1();
            string sentence = "";
            string expected = "";
            string actual = objInterview.ReverseWords2(sentence);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_ReverseWords2_IsNull()
        {
            Q1 objInterview = new Q1();
            string sentence = null;
            string expected = "";
            string actual = objInterview.ReverseWords2(sentence);
            Assert.AreEqual(actual, expected);
        }

    }
}
