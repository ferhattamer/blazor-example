using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ex25.Pages
{
    public partial class Pr25
    {
        protected string Cordinates{get;set;}
        protected void  MouseMove(MouseEventArgs e)
        {
            Cordinates=$"X={e.ClientX} Y={e.ClientY}";
        }
        protected string strOver{get;set;}
        protected void MouseOver(MouseEventArgs e)
        {
            strOver="Buğra";
        }
        protected void MouseOut(MouseEventArgs e)
        {
            strOver="Oktar";
        }
        protected string strDownUp{get;set;}
        protected void MouseDown(MouseEventArgs e)
        {
            strDownUp=$"Button Down:{e.Button}";
        }
        protected void MouseUp(MouseEventArgs e)
        {
            strDownUp=$"Button Up :{e.Button}";
        }
    }
}