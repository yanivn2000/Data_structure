using System;
using System.Collections.Generic;
using System.Text;

namespace CircularQueue
{
    class Queue_Array<T>
    {
        T[] arr;
        int firstInd;
        int lastInd;
        int cnt;

        public Queue_Array(int capacity)
        {
            arr = new T[capacity];
            firstInd = lastInd = -1;
        }

        public bool IsEmpty()
        {
            return firstInd == -1;
            //return cnt == 0;
        }

        public bool IsFull()
        {
            return (lastInd + 1) % arr.Length == firstInd;
           // return cnt == arr.Length;
        }
        //insert
        public bool EnQueue(T item)
        {
            if (IsFull()) return false;
            cnt++;
            if(IsEmpty())
            {
                arr[0] = item;
                firstInd = lastInd = 0;
                return true;
            }
            lastInd = (lastInd + 1) % arr.Length;
            arr[lastInd] = item;
            return true;
        }

        public bool DeQueue(out T item)
        {            item = default(T);            if (IsEmpty()) return false;            cnt--;            //first == last cases: 1) single item left in queue 2) queue is full            if (lastInd.Equals(firstInd) && !IsFull())            {                item = arr[firstInd];                lastInd = firstInd = -1;                return true;            }            item = arr[firstInd];            firstInd = (firstInd + 1) % arr.Length;            return true;        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
