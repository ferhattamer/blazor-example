using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex15.Pages
{
    public partial class Pr15
    {
        public bool AgreeValue{get;set;}
        private void Agree(ChangeEventArgs e)
        {
            AgreeValue= Convert.ToBoolean(e.Value);
        }
    }
}