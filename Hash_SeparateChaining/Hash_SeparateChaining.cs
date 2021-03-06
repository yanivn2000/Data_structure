﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hash_SeparateChaining
{
    class Hash_SeparateChaining<TKey, TValue>
    {
        LinkedList<Data>[] arr;
        // const double M = 1.3; //extra 30% space
        int items;
        int maxItems; //maxItems = 100, array size = 130

        public Hash_SeparateChaining()
            :this(1024)
        {
           // Hash_SeparateChaining(1024);
        }

        public Hash_SeparateChaining(int maxItems)//hashCodeCalcDel ?
        {
            items = 0;
            arr = new LinkedList<Data>[maxItems];
            this.maxItems = maxItems;
        }

        //public double AverListSize()
        //{
        //    int totalSize = 0;
        //    int nonEmptyLists = 0;
        //    foreach (var item in arr)
        //    {

        //    }
        //}


        public bool GetValue(TKey key, out TValue value)//find value by key
        {
            int ind = CalcHashCode(key);

            if (arr[ind] != null)
            {
                foreach (Data d in arr[ind])
                {
                    if (d.key.Equals(key))
                    {
                        value = d.val;
                        return true;
                    }
                }
            }
            //Data d = arr[ind].First(d => d.key.Equals(key));
            //value = d.val;
            value = default(TValue);
            return false;
        }

        public void Add(TKey key, TValue value) //O(1)
        {
            int ind = CalcHashCode(key);

            if (arr[ind] == null)
            {
                arr[ind] = new LinkedList<Data>(); //this is a first item for this ind
            }
            else
            {
                if (arr[ind].Any(d => d.key.Equals(key)))
                {
                    throw new ArgumentException($"An item with the same key has already been added. Key: {key}");
                }
            }

            arr[ind].AddLast(new Data(key, value));
            items++;

            if(items > maxItems)
            {
                ReHash();//to do - add implemintation
            }
        }

        private void ReHash() //O(n)
        {
            items = 0;
            var tmp = arr;
            arr = new LinkedList<Data>[arr.Length * 2];

            foreach(LinkedList<Data> lst in tmp)
            {
                if (lst == null) continue;
                foreach (Data d in lst)
                {
                    Add(d.key, d.val);
                }
               
            }           
        }

        private int CalcHashCode(TKey key)
        {            
            int res = key.GetHashCode();
            //return res % arr.Length; // index: 0 - len-1
            return Math.Abs(res) % arr.Length; // index: 0 - len-1
        }

        class Data
        {
            public TKey key;
            public TValue val;

            public Data(TKey key, TValue val)
            {
                this.key = key;
                this.val = val;
            }
        }
    }
}
