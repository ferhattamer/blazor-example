using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex13.Pages
{
    public partial class Pr13
    {
        public string MyOption{get;set;}
        public string Name{get;set;}

        private void Option(ChangeEventArgs e)
        {
            MyOption= e.Value as string;
        }
    }
}