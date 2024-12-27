using DSA_CSharp._03_HashTables_DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp._03_HashTables_DS
{
    public class NodeKeyValue
    {
        public string key { get; set; }
        public int value { get; set; }

        public NodeKeyValue(string key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }
    public class HashTableImplementation
    {
        private class NodeKeyValues : List<NodeKeyValue> { };
        private readonly int size;
        private NodeKeyValues[] data;

        public HashTableImplementation(int size) 
        {
            this.size = size;
            this.data = new NodeKeyValues[size];
        }

        private int hash(string key)
        {
            int hash = 0;

            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % size;
            }
            return hash;
        }

        public void SetData(string key, int value)
        {
            //Get address
            var address = hash(key);
            //Check address exist and assign new array
            if (data[address] == null)
                data[address] = new NodeKeyValues();
            //push new key/value in same address
            data[address].Add(new NodeKeyValue(key,value));
        }

       

        public int GetData(string key)
        {
            int address = hash(key);
            var bucket = data[address];
            for(int i = 0;i < bucket.Count;i++)
            {
                if (bucket[i].key == key)
                    return bucket[i].value;
            }
            return 0;
        }

        public List<string> Keys()
        {
            var keys = new List<string>();
            for (int i = 0; i < this.data.Length; i++)
            {
                if (this.data[i] != null)
                {
                    for (int j = 0; j < this.data[i].Count; j++)
                    {
                        keys.Add(this.data[i][j].key.ToString());
                    }
                }
            }
            return keys;
        }
    }
}


// Hashtable Implemetation MainMethod

//HashTableImplementation hashTable = new(5);
//hashTable.SetData("grapes", 10000);
//hashTable.SetData("apples", 70000);
//var result = hashTable.GetData("apples");
//Console.WriteLine(result);
//var keys = hashTable.Keys();
//for (int i = 0; i < keys.Count; i++)
//{
//    Console.WriteLine(keys[i]);
//}
