using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex21.Pages
{
    public partial class Pr21
    {
        private string Names {get;set;}
        private string tmpNames{get;set;}
        private string UpdateName
        {
            get {return Names;}
            set
            {
                Names=value;
                if(Names=="Timur")
                {
                    tmpNames="Taklamakan";
                }
            }
        }
    }
}