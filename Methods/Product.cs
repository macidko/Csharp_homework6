using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Product
    {
        //Class bir veri tipidir
        //Class isimleri PascalCase yazılır

        /*Property - Özellik
         *sınıf veya nesne içinde veri üyelerine erişim sağlamak için kullanılan özelliklerdir. 
         *Bir property, genellikle bir alanın (field) değerine erişmek veya ayarlamak için kullanılan get ve set erişim yöntemlerini içerir. 
         *Propertyler, veri saklama ve erişimini daha kontrol edilebilir hale getirerek sınıfların ve nesnelerin kullanımını daha güvenli ve 
         *kolay hale getirir.
         */
 
        /*Field 
         *sınıf veya nesne içinde veri saklamak için kullanılan değişken veya alan anlamına gelir. Fields, bir sınıfın veya
         *nesnenin durumunu temsil eden verileri depolamak için kullanılır. 
         */
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

    }
}
