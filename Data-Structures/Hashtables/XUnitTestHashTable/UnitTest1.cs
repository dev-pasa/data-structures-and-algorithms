using System;
using Xunit;
using Hashtable.Classes;

namespace XUnitTestHashTable
{

    public class UnitTest1
    {
        /// <summary>
        /// check to see if the key exists
        /// </summary>
        [Fact]
        public void KeyNotFound()
        {
            HashTable hasht = new HashTable(5);
            hasht.Add("hello", "world");
            Assert.False(hasht.Contains("snow"));
        }

        /// <summary>
        /// test to see if key is found
        /// </summary>
        [Fact]
        public void KeyNotFound2()
        {
            HashTable hasht = new HashTable(5);
            hasht.Add("hello", "world");
            Assert.False(hasht.Contains("cat"));
        }

        /// <summary>
        /// test to see if key is found
        /// </summary>
        [Fact]
        public void KeyNotFound3()
        {
            HashTable hasht = new HashTable(5);
            hasht.Add("hello", "world");
            Assert.False(hasht.Contains("ball"));
        }

        /// <summary>
        /// test for collison
        /// </summary>
        [Fact]
        public void TestCollisions1()
        {
            HashTable hasht = new HashTable(5);
            hasht.Add("55", "hello");
            hasht.Add("55", "world");
            Assert.True(hasht.Contains("55") && hasht.Contains("55"));
        }

        /// <summary>
        /// test for collison
        /// </summary>
        [Fact]
        public void TestCollisions2()
        {
            HashTable hasht = new HashTable(5);
            hasht.Add("57", "hello");
            hasht.Add("75", "world");
            Assert.True(hasht.Contains("57") && hasht.Contains("75"));
        }

        /// <summary>
        /// test for collison
        /// </summary>
        [Fact]
        public void TestCollisions3()
        {
            HashTable hasht = new HashTable(5);
            hasht.Add("34", "hello");
            hasht.Add("43", "world");
            Assert.True(hasht.Contains("34") && hasht.Contains("43"));
        }

        /// <summary>
        /// Create a hash table and test if a key exists
        /// </summary>
        [Fact]
        public void AddKeyValue1()
        {
            HashTable testTable = new HashTable(10);
            testTable.Add("Apple", 1);
            testTable.Add("Banana", 2);
            testTable.Add("Cat", 3);
            Assert.Equal(1, testTable.Get("Apple"));
        }

        /// <summary>
        /// Create a hash table and test if a key exists after adding the key and values
        /// </summary>
        [Theory]
        [InlineData("TestKey", "TestValue")]
        [InlineData("Hello", 1)]
        [InlineData("snow", true)]
        public void TestAdd(string key, object value)
        {
            HashTable hasht = new HashTable(10);
            hasht.Add(key, value);
            Assert.Equal(value, hasht.Get(key));
        }

        /// <summary>
        /// Test contains method
        /// </summary>
        [Theory]
        [InlineData("TestKey", "TestValue")]
        [InlineData("Hello", 1)]
        [InlineData("snow", true)]
        public void TestContains(string key, object value)
        {
            HashTable hasht = new HashTable(10);
            hasht.Add(key, value);
            Assert.True(hasht.Contains(key));
        }

        /// <summary>
        /// test remove method
        /// </summary>
        [Theory]
        [InlineData("TestKey", "TestValue")]
        [InlineData("Hello", 1)]
        [InlineData("snow", true)]
        public void TestRemove(string key, object value)
        {
            HashTable hasht = new HashTable(10);
            hasht.Add(key, value);
            if (hasht.Contains("Hello"))
            {
                hasht.Remove("hello");
            }
            Assert.False(hasht.Contains("hello"));
        }
    }
}