using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;
 
namespace ex1.Pages
{
    public partial class Pr1
    {
        
        string text1="";
        string text2="";
        string htmlText="Bana Tıkla";
        

        private void Kimbüyük(){
            if((text1.Length)>(text2.Length)){
                htmlText=text1;
            }else if(text1.Length==text2.Length){
                htmlText="Aynı uzunlukta";
            }
            else{
                htmlText=text2;
            }
        }
    }
}