using System;
using Interview;

namespace Interview
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Q1
            Console.WriteLine("Q1: Write a function that reverses the order of words of a sentence.");
            Q1 objInterview = new Q1();
            string s1 = "My name is Pratibha";
            string s2 = "efficient more and safer smarter, agencies transit makes that technology the provide We";
            Console.WriteLine();
            Console.WriteLine("Original statement s1: {0}", s1.ToString());
            Console.WriteLine();
            Console.WriteLine("Original statement s2: {0}", s2.ToString());
            Console.WriteLine();
            Console.WriteLine("Using function ReverseWords1 -- using inbuild reverse function");
            Console.WriteLine();
            Console.WriteLine("reversed s1: {0}", objInterview.ReverseWords1(s1));     
            Console.WriteLine("reversed s2: {0}", objInterview.ReverseWords1(s2));
  
            Console.WriteLine();
            Console.WriteLine("Using function ReverseWords2 -- without using inbuild reverse function");
            Console.WriteLine();
            Console.WriteLine("reversed s1: {0}", objInterview.ReverseWords2(s1));            
            Console.WriteLine("reversed s2: {0}", objInterview.ReverseWords2(s2));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("User Input to reverse sentence");
            Console.WriteLine("Please Enter a sentence");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Sentence after reversing order of words:");
            Console.WriteLine();
            Console.WriteLine("Using inbuilt c# reverse function");
            Console.WriteLine("reversed sentence is: {0}", objInterview.ReverseWords1(s));
            Console.WriteLine();
            Console.WriteLine("Without using inbuilt c# reverse function");
            Console.WriteLine("reversed sentence is: {0}", objInterview.ReverseWords2(s));
            Console.WriteLine("_____________________________________________________________________________________________");
            Console.ReadLine();

            //Q2
            Console.WriteLine("Q2: Create your own class or a set of functions that implement a stack. ");
            MyStack<string> stack1 = new MyStack<string>(5);
            stack1.Push("name");
            stack1.Push("first");
            stack1.Push("my");
            stack1.Push("is");
            stack1.Push("Pratibha");
            Console.WriteLine("5 items are pushed into stack1 of type string");
            Console.WriteLine("stack1.Push(\"name\");");
            Console.WriteLine("stack1.Push(\"first\");");
            Console.WriteLine("stack1.Push(\"my\");");
            Console.WriteLine("stack1.Push(\"is\");");
            Console.WriteLine("stack1.Push(\"Pratibha\")");
            Console.WriteLine();
            MyStack <int> stack2 = new MyStack<int>(7);
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Push(4);
            stack2.Push(5);
            stack2.Push(6);
            stack2.Push(7);
            Console.WriteLine("7 items are pushed into stack2 of type int");
            Console.WriteLine("stack2.Push(1);");
            Console.WriteLine("stack2.Push(2);");
            Console.WriteLine("stack2.Push(3);");
            Console.WriteLine("stack2.Push(4);");
            Console.WriteLine("stack2.Push(5);");
            Console.WriteLine("stack2.Push(6);");
            Console.WriteLine("stack2.Push(7);");
            Console.WriteLine();
            Console.ReadLine();
            //Check if Stack1 is Empty
            Console.WriteLine("Stack 1 is Empty?  {0} ", stack1.IsEmpty());

            //Check if Stack2 is Empty
            Console.WriteLine("Stack 2 is Empty?  {0} ", stack2.IsEmpty());

            //Print size of stack1
            Console.WriteLine("Size of stack1 is: {0} ", stack1.Size());

            //Print size of stack2
            Console.WriteLine("Size of stack2 is: {0} ", stack2.Size());

            Console.ReadLine();
            //Pop elements from stack 1 of type string
            Console.WriteLine();
            Console.WriteLine("Pop all elements from stack 1 of type string");

            Console.WriteLine();
            for (int i = 0; i < stack1.MaxSize(); i++)
                Console.WriteLine(stack1.Pop());

           
            Console.WriteLine();
            //Pop elements from stack 2 of type int
            Console.WriteLine("Pop only 5 elements from stack 2 of type int");
            Console.WriteLine();
            for (int i = 0; i < stack2.MaxSize() - 2; i++)
                Console.WriteLine(stack2.Pop());

            Console.ReadLine();
            //Check if Stack1 is Empty

            Console.WriteLine("Stack 1 is Empty?  {0} ", stack1.IsEmpty());

            //Check if Stack2 is Empty
            Console.WriteLine("Stack 2 is Empty?  {0} ", stack2.IsEmpty());

            //Print size of stack1
            Console.WriteLine("Size of stack1 is: {0} ", stack1.Size());

            //Print size of stack2
            Console.WriteLine("Size of stack2 is: {0} ", stack2.Size());

            Console.WriteLine("_____________________________________________________________________________________________");
            Console.ReadLine();

            //Q3
            Console.WriteLine("Q3: Write a function f(a, b) which takes two character string arguments and returns a string containing only the characters found in both strings.");
            Q3 objInterview3 = new Q3();
            char[] ch1 = { 'a', 's', 't', 'c', 'i', 'n', 'g' };
            char[] ch2 = { 'g', 'f', 'c', 'w', 'e', 'n', 'a' };

            char[] ch3 = { 'a', 's', 't', 'c', 'i', 'n', 'g' };
            char[] ch4 = { 'g', 'f', 'c', 'c', 'e', 'n', 'a' };

            Console.WriteLine();
            Console.WriteLine("ex1: Original character strings are as below");
            Console.WriteLine("1:  char[] ch1 = { 'a', 's', 't', 'c', 'i', 'n', 'g' };");
            Console.WriteLine("2:  char[] ch2 = { 'g', 'f', 'c', 'w', 'e', 'n', 'a' };");
            Console.WriteLine("above is without repeated characters");
            Console.WriteLine();
            Console.WriteLine("ex2: Original character strings are as below");
            Console.WriteLine("1:  char[] ch3 = { 'a', 's', 't', 'c', 'i', 'n', 'g' };");
            Console.WriteLine("2:  char[] ch4 = { 'g', 'f', 'c', 'c', 'e', 'n', 'a' };");
            Console.WriteLine("above is with repeated characters");
            Console.WriteLine();
            Console.WriteLine("Solution for ex1: using GetStringWithCommonChars1");
            Console.WriteLine("new string: {0}", objInterview3.GetStringWithCommonChars1(ch1, ch2));
            //Console.ReadLine();
            Console.WriteLine("Solution for ex1: using GetStringWithCommonChars2");
            Console.WriteLine("new string: {0}", objInterview3.GetStringWithCommonChars2(ch1, ch2));
            //Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Solution for ex2: using GetStringWithCommonChars1");
            Console.WriteLine(objInterview3.GetStringWithCommonChars1(ch3, ch4));
            //Console.ReadLine();
            Console.WriteLine("Solution for ex2: using GetStringWithCommonChars2");
            Console.WriteLine(objInterview3.GetStringWithCommonChars2(ch3, ch4));
            Console.WriteLine("_____________________________________________________________________________________________");
            Console.ReadLine();
        }
    }
}
