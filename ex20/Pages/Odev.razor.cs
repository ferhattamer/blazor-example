using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;


namespace ex20.Pages
{
    public partial class Odev 
    {   
        Random rnd=new Random();
        int count,sayi1,sayi2,sayi3,sonuc;
        string htmmlText="hesapla";
        private string sayi11;
        private string sayi22;
        private string sayi33;
        private void Hesapla(){
            for(count=1;count<4;count++){
            switch(count){
            case 1 :
             sayi1 = rnd.Next(1,100);
            sayi11=sayi1.ToString();
            break;
            case 2 :
            sayi2 = rnd.Next(1,100);
            sayi22=sayi2.ToString();
            break;
            case 3 :
            sayi3 = rnd.Next(1,100);
            sayi33=sayi3.ToString();
            sonuc= sayi1 * sayi2 + sayi3;
            break;
            }
            }
            count=0;
            htmmlText=sonuc.ToString();
        }
    }
}
