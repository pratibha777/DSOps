using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    //4. Create your own class or a set of functions that implement a stack.Include the following four methods:
    //a.Push: Adds a data element to the top of the stack
    //b.Pop: Removes a data element from the top of the stack
    //c.Size: Returns the total number of elements in the stack
    //d.isEmpty: Returns true if the stack is empty.
    public class MyStack<T>
    {
        int size;
        T[] data;
        int top;

        //Initializes an empty stack.
        public MyStack(int maxElements)
        {
            size = maxElements;
            data = new T[size];
            top = -1; //initialize top with -1 i.e. stack is empty
        }

        //Push: Adds a data element to the top of the stack
        public int Push(T dataElement)
        {
            //Check Overflow
            if (top == size - 1)
            {
                // return -1 if over flow is there
                return -1;
            }
            else
            {
                // insert element into stack
                top = top + 1;
                data[top] = dataElement;
            }
            return 0;
        }

        //Pop: Removes a data element from the top of the stack
        public T Pop()
        {
            T RemovedElement;
            T temp = default(T);
            //check Underflow
            if (top > -1)
            {
                RemovedElement = data[top];
                data[top] = temp;
                top = top - 1;
                return RemovedElement;
            }
            return temp;
        }

        //Size: Returns the total number of elements in the stack
        public int MaxSize()
        {          
                return size;           
        }

        //Size: Returns the total number of elements in the stack
        public int Size()
        {
            T temp = default(T);
            if (top < 0)
                return 0;
            else
            {
                int count = 0;
                foreach (T element in data)
                {
                    if (element != null & !element.Equals(temp))
                    {
                        count++;
                    }
                    else
                        break;
                }
                return count;
            }                              
        }

        //IsEmpty: Returns true if the stack is empty
        public bool IsEmpty()
        {
            return (top < 0);
        }          
    }
}

