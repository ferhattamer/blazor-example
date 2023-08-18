using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex23.Pages
{
    public partial class Pr23
    {
        private int Counter {get;set;}
        private void IncCounter(MouseEventArgs e)
        {
            Counter++;
        }
        private void DecCounter(MouseEventArgs e)
        {
            Counter--;
        }
    }
}