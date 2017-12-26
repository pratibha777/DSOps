using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview;

namespace TestInterview
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void Test_StackIsEmpty()
        {
                MyStack<int> stack = new MyStack<int>(10);
                Assert.IsTrue(stack.IsEmpty());
                stack.Push(1);
                Assert.IsFalse(stack.IsEmpty());
                stack.Pop();
                Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void Test_StackHasZeroElements()
        {
            MyStack<int> stack = new MyStack<int>(10);
            Assert.AreEqual(0, stack.Size());
            stack.Push(1);
            Assert.AreEqual(1, stack.Size());
            stack.Push(2);
            Assert.AreEqual(2, stack.Size());
            stack.Pop();
            Assert.AreEqual(1, stack.Size());
            stack.Pop();
            Assert.AreEqual(0, stack.Size());
        }

        [TestMethod]
        public void Test_Size()
        {
            MyStack<int> stack = new MyStack<int>(10);
            Assert.AreEqual(0, stack.Size());
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Assert.AreEqual(5, stack.Size());
            stack.Pop();
            stack.Pop();
            Assert.AreEqual(3, stack.Size());
            stack.Pop();
            stack.Pop();
            Assert.AreEqual(1, stack.Size());
            stack.Pop();
            Assert.AreEqual(0, stack.Size());
        }

        [TestMethod]
        public void Test_PopOneElement()
        {
            MyStack<int> stack = new MyStack<int>(10);            
            stack.Push(1);
            Assert.AreEqual(1, stack.Pop());            
        }

        [TestMethod]
        public void Test_TwoDataElementsAreLifo()
        {
            MyStack<int> stack = new MyStack<int>(10);
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }


        [TestMethod]
        public void Test_EmptyPop()
        {
            MyStack<int> stack = new MyStack<int>(10);            
            Assert.AreEqual(default(int), stack.Pop());           
        }

        [TestMethod]
        public void Test_EmptyOnEmptyPop()
        {
            MyStack<int> stack = new MyStack<int>(10);
            Assert.IsTrue(stack.IsEmpty());
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void Test_CountOnEmptyPop()
        {
            MyStack<int> stack = new MyStack<int>(10);
            Assert.AreEqual(0, stack.Size());
            stack.Pop();
            Assert.AreEqual(0, stack.Size());            
        }       

    }
}
