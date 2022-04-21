using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        //deopent injection
        public void BasvuruYap(ICrediManager crediManager,ILoggerService loggerService)
        {
            //başvuru bilgilerini değerlendirme
            //
            //MortageManager mortageManager = new MortageManager();
            //mortageManager.Hesapla();müptelası oldu
           
            
            crediManager.Hesapla();
            loggerService.Log();
            //dikkattttttt :teknik mülakat çıkar....
        }
        public void KrediOnBilgilendirmesiYap(List<ICrediManager> credis)
        {
            foreach (var credi in credis)
            {
                credi.Hesapla();
            }
        }
    }
}
