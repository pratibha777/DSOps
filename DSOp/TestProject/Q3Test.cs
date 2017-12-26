using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview;

namespace TestInterview
{
    [TestClass]
    public class Q3Test
    {
        [TestMethod]
        public void Test_GetStringWithCommonChars1_withoutRepeatedChars()
        {
            Q3 objInterview = new Q3();
            char[] ch1 = { 'a', 's', 't', 'c', 'i', 'n', 'g' };
            char[] ch2 = { 'g', 'f', 'c', 'w', 'e', 'n', 'a' };
            string expected = "acng";
            string actual = objInterview.GetStringWithCommonChars2(ch1, ch2);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetStringWithCommonChars1_withRepeatedChars()
        {
            Q3 objInterview = new Q3();
            char[] ch1 = { 'a', 's', 't', 'c', 'i', 'n', 'g' };
            char[] ch2 = { 'g', 'f', 'c', 'c', 'e', 'n', 'a' };
            string expected = "acng";
            string actual = objInterview.GetStringWithCommonChars2(ch1, ch2);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetStringWithCommonChars1_IsNull()
        {
            Q3 objInterview = new Q3();
            char[] ch1 = null;
            char[] ch2 = null;
            string expected = "";
            string actual = objInterview.GetStringWithCommonChars1(ch1, ch2);
            Assert.AreEqual(actual, expected);           
        }        

        [TestMethod]
        public void Test_GetStringWithCommonChars1_IsEmpty()
        {
            Q3 objInterview = new Q3();
            char[] ch1 = "".ToCharArray();
            char[] ch2 = "".ToCharArray();
            string expected = "";
            string actual = objInterview.GetStringWithCommonChars1(ch1, ch2);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetStringWithCommonChars2_IsNull()
        {
            Q3 objInterview = new Q3();
            char[] ch1 = null;
            char[] ch2 = null;
            string expected = "";
            string actual = objInterview.GetStringWithCommonChars2(ch1, ch2);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetStringWithCommonChars2_IsEmpty()
        {
            Q3 objInterview = new Q3();
            char[] ch1 = "".ToCharArray();
            char[] ch2 = "".ToCharArray();
            string expected = "";
            string actual = objInterview.GetStringWithCommonChars2(ch1, ch2);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetStringWithCommonChars2_withoutRepeatedChars()
        {
            Q3 objInterview = new Q3();
            char[] ch1 = { 'a', 's', 't', 'c', 'i', 'n', 'g' };
            char[] ch2 = { 'g', 'f', 'c', 'w', 'e', 'n', 'a' };
            string expected = "acng";
            string actual = objInterview.GetStringWithCommonChars2(ch1, ch2);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_GetStringWithCommonChars2_withRepeatedChars()
        {
            Q3 objInterview = new Q3();
            char[] ch1 = { 'a', 's', 't', 'c', 'i', 'n', 'g' };
            char[] ch2 = { 'g', 'f', 'c', 'c', 'e', 'n', 'a' };
            string expected = "acng";
            string actual = objInterview.GetStringWithCommonChars2(ch1, ch2);
            Assert.AreEqual(actual, expected);
        }
    }
}
