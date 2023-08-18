using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

    namespace ex26.Pages
    {
        public partial class Pr26
        {
            protected string keyPress{get;set;}
            private void KeyBindPressed(KeyboardEventArgs e)
            {
                keyPress=e.Key;
            }
            string KeyPressed="";
            string Eventinfo="";
            private void KeyboardEventHandler(KeyboardEventArgs e)
            {
                KeyPressed="Key Pressed is "+e.Key;
                Eventinfo="Event Type"+e.Type+" "+e.Code;
            }
        }
    }