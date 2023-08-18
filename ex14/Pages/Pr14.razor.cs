using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex14.Pages {
    public partial class Pr14 {
        public string Value {get;set;}
        public string PrintValue {get;set;}

        private void ChangeValue(ChangeEventArgs e)
        {
            Value= e.Value.ToString();
        }
        private void DisplayValue(FocusEventArgs e)
        {
            PrintValue=Value;
        }
    }
}