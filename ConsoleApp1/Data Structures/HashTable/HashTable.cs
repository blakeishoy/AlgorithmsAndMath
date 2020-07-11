using System;
using System.Collections.Generic;
using System.Text;

namespace BlakeIshoyAlgorithms.Data_Structures.HashTable
{
    public class HashTable
    {
        public HashTableDataItem[] Table { get; set; }

        public HashTable(int capacity)
        {
            this.Table = new HashTableDataItem[capacity];
        }

        private int hashCode(int key)
        {
            return key % this.Table.Length;
        }

        public void Insert(int key, int value)
        {
            var pair = new HashTableDataItem(key, value);
            var hashIndex = this.hashCode(key);
            
            while (this.Table[hashIndex] != null && this.Table[hashIndex].Key != -1) 
            {
                hashIndex++;
                hashIndex %= this.Table.Length;
            }
            this.Table[hashIndex] = pair;
        }

        public HashTableDataItem Search(int key)
        {
            int hashIndex = this.hashCode(key);

            while (this.Table[hashIndex] != null)
            {
                if (this.Table[hashIndex].Key == key)
                {
                    return this.Table[hashIndex];
                }
                hashIndex++;
                hashIndex %= this.Table.Length;
            }
            return null;
        }

        public bool Delete(HashTableDataItem item)
        {
            var hashIndex = hashCode(item.Key);
            var wasDeleted = false;

            while(this.Table[hashIndex] != null)
            {
                if (this.Table[hashIndex].Key == item.Key)
                {
                    this.Table[hashIndex] = null;
                    wasDeleted = true;
                    break;
                }
                hashIndex++;
                hashIndex %= this.Table.Length;
            }
            return wasDeleted;
        }
    }
}
