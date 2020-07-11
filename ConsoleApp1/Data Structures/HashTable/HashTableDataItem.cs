using System;
using System.Collections.Generic;
using System.Text;

namespace BlakeIshoyAlgorithms.Data_Structures.HashTable
{
    public class HashTableDataItem
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public HashTableDataItem(int key, int value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
