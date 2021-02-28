using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    public class MyDict <K, V>
    {
        K[] key;
        V[] value;
        K[] keyEmanet;
        V[] valueEmanet;
        public MyDict()
        {
            key = new K[0];
            value = new V[0];
        }
        public void Add(K index, V name)
        {
            keyEmanet = key;
            valueEmanet = value;
            key = new K[key.Length + 1];
            value = new V[value.Length + 1];
            for (int i = 0; i < valueEmanet.Length; i++)
            {
                key[i] = keyEmanet[i];
                value[i] = valueEmanet[i];
            }
            key[key.Length - 1] = index;
            value[value.Length - 1] = name;
            Console.WriteLine(name + " başarıyla eklendi");
            DictionaryList();
        }
        public void DictionaryList()
        {
            Console.WriteLine("------Tum Liste------");
            for (int i = 0; i <value.Length; i++)
            {
                Console.WriteLine(key[i]+ " --> " + value[i]);
            }
            Console.WriteLine(key.Length + " adet veri.");
        }
    }
}
