using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //mylistte t ile çalışılacak T olarak ne verilirse istenilen tip o?
    {
        T[] items;
        //constructor class bir yerde new lenddiğinde otomatik çalışır.
        public MyList()
        {
            items = new T[0];//0 elemanlı dizimiz var.
        }
        public void Add(T item)
        {
            T[] tempArray = items;//geçici dizinin referansı itemsin referansı
            items = new T[items.Length+1];//dizinin eleman sayısını artırıryor
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //tempArrayde tutulanlan değerler items a tekrardan yuklenıyor.
            }

            items[items.Length - 1] = item; //itemsin son elemanı 
        }
    }
}
