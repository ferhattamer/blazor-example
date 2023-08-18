using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex16.Pages 
{
    public partial class Pr16
    {
        public string PrintMale{get;set;}
        public string PrintFemale{get;set;}

        private void Agree(string sex, object checkedValue)
        {
            if((bool)checkedValue)
            if(sex=="male")PrintMale="male";
            else PrintFemale="female";
            else
            if(sex=="female")PrintMale="";
            else PrintFemale="";
        }
    }
}