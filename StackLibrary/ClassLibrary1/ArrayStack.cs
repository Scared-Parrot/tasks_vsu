using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ArrayStack<T>: IStack <T>
    {
        private T[] arrayData;
        private const int defaultSize = 30;
        private int index;

        public int Count => index;

        public bool IsEmpty => index == 0;

        public ArrayStack()
        {
            arrayData = new T[defaultSize];
            index = 0;
        }

        public ArrayStack(int size)
        {
            if (size < 0)
                throw new StackException("Size must be a positive number");

            arrayData = new T[size];
            index = 0;
        }
        public T Pop()
        {
            if (index == 0)
                throw new StackException("Exception: Empty stack");

            return arrayData[--index];

        }

        public T Peek()
        {
            if (index == 0)
                throw new StackException("Exception: Empty stack");

            return arrayData[index - 1];

        }

        public void Push(T obj)
        {
            if (index == arrayData.Length)
            {
                T[] newArray = new T[2 * arrayData.Length];
                Array.Copy(arrayData, 0, newArray, 0, index);
                arrayData = newArray;
            }
            arrayData[index] = obj;
            index++;
        }

        public void Clear()
        {
            arrayData = new T[defaultSize];
            index = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return arrayData[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
