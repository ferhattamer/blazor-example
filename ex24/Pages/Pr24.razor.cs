using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex24.Pages
{
    public partial class Pr24
    {
        private int indexNames {get;set;}=2;
        private string tmpNames {get;set;}
        public int UpdateName
        {
            get {return indexNames;}
            set{
                indexNames=value;
                if(indexNames==4)
                {
                    tmpNames="Taklamakan";
                }
                else {tmpNames="";}
            }
        }
    }
}