using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface leri birbirinin alternatifi olan ama kod içeriği farklı olan durumlar için kullanırız.
    //Aşağıdaki banka kredileri örneğimizde olduğu gibi.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
