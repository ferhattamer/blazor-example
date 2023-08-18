using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex20.Pages
{
    public partial class Pr20
    {
        private string Names{get;set;}="Heyy";
        private void UpdateName(ChangeEventArgs e)
        {
            Names= e.Value as string;
        }
    }
}