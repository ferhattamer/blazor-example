using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex17.Pages
{
    public partial class Pr17
    {
        public string SexValue{get;set;}
        private void YourSex(ChangeEventArgs e)
        {
            SexValue= e.Value as string;
        }
    }
}