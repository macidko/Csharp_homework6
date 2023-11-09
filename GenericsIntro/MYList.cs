using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        //Değerleri tutmak için array tanımlanır.
        T[] items;
        //constructor
        public MyList()
        {
            //constructor içerisinde array boyutu 0 olarak tanımlanır çünkü constructor, içerisinde bulunduğu
            //class çağrıldığı an çalışır. böylece array boyutu 0 olmuş olur.
            items = new T[0];
        }
        public void Add(T item)
        {
            //geçici array önceki array'in refini saklamak için tanımlanır.
            T[] tempArray = items;
            //boyut değiştime işlemini yapabilmek için array newlenmek zorundadır ve artırma yapabilmek için
            //önceki array boyutu + 1 yapılmalıdır.
            items = new T[items.Length + 1];
            //önceki ref numarası saklanmış array'in içerisindeki değerleri index sırası ile yeni oluşturulmuş referansa ekleme
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //parametre ile alınan değeri son indexe ekleme
            items[items.Length - 1] = item;
        }
    }
}
