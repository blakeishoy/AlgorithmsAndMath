using BlakeIshoyAlgorithms.Data_Structures.HashTable;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace AlgorithmUnitTests
{
    public class HashTableTests
    {
        public HashTable HashTable { get; set; }
        [SetUp]
        public void Setup()
        {
            this.HashTable = new HashTable(20);
            this.HashTable.Insert(1, 20);
            this.HashTable.Insert(2, 70);
            this.HashTable.Insert(42, 80);
            this.HashTable.Insert(4, 25);
            this.HashTable.Insert(12, 44);
            this.HashTable.Insert(14, 32);
            this.HashTable.Insert(17, 11);
            this.HashTable.Insert(13, 78);
            this.HashTable.Insert(37, 98);
        }

        [Test]
        public void VerifyOrganization()
        {
            var verify1 = this.HashTable.Search(1).Value == 20;
            var verify2 = this.HashTable.Search(2).Value == 70;
            var verify42 = this.HashTable.Search(42).Value == 80;
            var verify4 = this.HashTable.Search(4).Value == 25;
            var verify12 = this.HashTable.Search(12).Value == 44;
            var verify14 = this.HashTable.Search(14).Value == 32;
            var verify17 = this.HashTable.Search(17).Value == 11;
            var verify13 = this.HashTable.Search(13).Value == 78;
            var verify37 = this.HashTable.Search(37).Value == 98;

            var verifyAll = verify1 && verify2 && verify42 && verify4 && verify12 && verify14 && verify17 && verify13 && verify37;
            Assert.IsTrue(verifyAll);
        }

        [Test]
        public void TestDelete()
        {
            var item = this.HashTable.Search(12);
            this.HashTable.Delete(item);
            var verifyDeletion = this.HashTable.Search(12) == null;
            Assert.IsTrue(verifyDeletion);
        }
    }
}
