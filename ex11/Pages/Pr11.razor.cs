using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;
 
 namespace ex11.Pages
 {
     public partial class Pr11
     {
         public string MyName{get;set;}
         private void SetName(ChangeEventArgs e1, ChangeEventArgs e2)
         {
             if(e1 is not null)
             MyName= e1.Value as string;
             if(e2 is not null)
             MyName= MyName+""+e2.Value as string;
         }
     }
 }