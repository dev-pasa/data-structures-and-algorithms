using System;
using Xunit;
using leftjoin;
using Hashtable.Classes;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    { 
        /// <summary>
        /// test 1 to check if the method works 
        /// </summary>
        [Fact]
        public void LeftJoinTest1()
        {
            HashTable hasht1 = new HashTable(5);
            hasht1.Add("5", "hello");
            hasht1.Add("6", "world");
            hasht1.Add("7", "hello");
            hasht1.Add("8", "world");
            
            HashTable hasht2 = new HashTable(5);
            hasht2.Add("5", "hell");
            hasht2.Add("6", "worl");
          
            List<string[]> leftjoin = Program.LeftJoin(hasht1, hasht2);
            Assert.Equal(4, leftjoin.Count);
        }

        /// <summary>
        /// test 2 to check if the method works 
        /// </summary>
        [Fact]
        public void LeftJoinTest2()
        {
            HashTable hasht1 = new HashTable(5);
            hasht1.Add("5", "hello");
            hasht1.Add("6", "world");
            hasht1.Add("7", "hello");

            HashTable hasht2 = new HashTable(5);
            hasht2.Add("5", "hell");
            hasht2.Add("6", "worl");

            List<string[]> leftjoin = Program.LeftJoin(hasht1, hasht2);
            Assert.Equal(3, leftjoin.Count);
        }

        /// <summary>
        /// test 3 to check if the method works 
        /// </summary>
        [Fact]
        public void LeftJoinTest3()
        {
            HashTable hasht1 = new HashTable(5);
            hasht1.Add("5", "hello");
            hasht1.Add("6", "world");
            hasht1.Add("7", "hello");
            hasht1.Add("8", "world");
            hasht1.Add("9", "hello");

            HashTable hasht2 = new HashTable(5);
            hasht2.Add("5", "hell");
            hasht2.Add("6", "worl");

            List<string[]> leftjoin = Program.LeftJoin(hasht1, hasht2);
            Assert.Equal(5, leftjoin.Count);
        }
    }
}
