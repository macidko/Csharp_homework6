using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Interface (Şablon)?
    //Classlarda ortak methodlar varsa ve farklı parametreler alması gerekiyorsa interface kullanılır.
    //interface'in kullanılacağı class, interface methodlarını içermek zorundadır.
    //Okunurluğu artırmak için I harfi ile başlar.
    interface ICreditManager
    {
        void Calculate();
        void DoSomething();
    }
}
