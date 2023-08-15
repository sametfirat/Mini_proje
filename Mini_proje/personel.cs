using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Mini_proje
{
    internal class musteri
    {
        static ArrayList dataBase;
        static musteri()
        {
            dataBase = new ArrayList();
        }
        
        public int Id ;
        public string Name ;
        public string Sorname;
        public string Email;
        public string Password ;
        private string Kulanıcıadı;
        
        public string _kulancıAdı
        {
            get
            {
                return this.Kulanıcıadı;
            }
            set
            {
                bool kontrol = kulanıcıAdıSorgulama(value);

                if (kontrol == true) { 
                    Console.WriteLine("kulanıcı adı bulnmaktadır");
                    this.Kulanıcıadı = string.Empty;
                }
                else
                {
                    this.Kulanıcıadı = value;
                }
                

            }
        }
            static bool kulanıcıAdıSorgulama(string _kulanıcıadı)
        {
            bool flag = false;
            for (int i = 0 ; i<dataBase.Count ; i++)
            {
                musteri temp = (musteri)dataBase[i];
                if (temp.Kulanıcıadı== _kulanıcıadı)
                {
                    flag = true;
                    break;
                }
                
            }
            return flag;
        }
        static bool kulanıcıMailSorgula(string email)
        {
            bool flag = false;
            for(int i=0;  i<dataBase.Count ; i++)
            {
                musteri cont = (musteri)dataBase[i];
                if (cont.Email== email)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public static void ekle (musteri M)
        {
            if (M != null && !string.IsNullOrEmpty(M.Kulanıcıadı) && !string.IsNullOrEmpty(M.Email))
            {
                
                bool emailSorgula = kulanıcıAdıSorgulama(M.Email);

                if(emailSorgula == true)
                {
                    Console.WriteLine("sistemde kayıtlı");
                } 

            else
                {
                    dataBase.Add(M);
                    Console.WriteLine("yeni kayıt eklendi");
                }
            }
        }

    }
}
