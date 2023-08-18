using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;
using System.Globalization;

namespace blazor.Pages
{
    public class DcompBase:ComponentBase
    {
        [Inject]
        public Apps AppData {get;set;}

        protected override void OnInitialized()
        {
            AppData.OnChange += StateHasChanged;
        }
        public void Dispose ()
        {
            AppData.OnChange -= StateHasChanged;
        }
    } 
}