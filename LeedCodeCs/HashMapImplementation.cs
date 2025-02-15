﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Pair<U, V>
    {
        public U first;
        public V second;

        public Pair(U first, V second)
        {
            this.first = first;
            this.second = second;
        }
    }

    public class Bucket
    {
        private LinkedList<Pair<int, int>> bucket;

        public Bucket()
        {
            this.bucket = new LinkedList<Pair<int, int>>();
        }

        public int Get(int key)
        {
            foreach (Pair<int, int> pair in this.bucket)
            {
                if (pair.first.Equals(key))
                {
                    return pair.second;
                }
            }
            return -1;
        }

        public void Update(int key, int value)
        {
            bool found = false;
            foreach (Pair<int, int> pair in this.bucket)
            {
                if (pair.first.Equals(key))
                {
                    pair.second = value;
                    found = true;
                }
            }

            if (!found)
            {
                this.bucket.AddLast(new Pair<int, int>(key, value));
            }
        }

        public void Remove(int key)
        {
            foreach (Pair<int, int> pair in this.bucket)
            {
                if (pair.first.Equals(key))
                {
                    this.bucket.Remove(pair);
                    break;
                }
            }
        }


    }


    public class MyHashMap
    {
        private int key_space;
        private List<Bucket> hash_table;


        /** Initialize your data structure here. */
        public MyHashMap()
        {
            this.key_space = 2069;
            this.hash_table = new List<Bucket>();

            for (int i = 0; i < this.key_space; i++)
            {
                this.hash_table.Add(new Bucket());
            }
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            int hash_key = key % this.key_space;
            this.hash_table[hash_key].Update(key, value);
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            int hash_key = key % this.key_space;
            return this.hash_table[hash_key].Get(key);
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            int hash_key = key % this.key_space;
            this.hash_table[hash_key].Remove(key);
        }
    }

    /**
     * Your MyHashMap object will be instantiated and called as such:
     * MyHashMap obj = new MyHashMap();
     * obj.Put(key,value);
     * int param_2 = obj.Get(key);
     * obj.Remove(key);
     */

}
