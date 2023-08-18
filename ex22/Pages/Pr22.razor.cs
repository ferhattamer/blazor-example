using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;
using System.Globalization;

namespace ex22.Pages{
    public partial class Pr22
    {
        private DateTime DOB = new DateTime(2000, 11, 30);
        public DateTime STime {get;set;}= DateTime.Parse("2020/05/15 07:20");
        public CultureInfo CultureTR {get;set;}= CultureInfo.GetCultureInfo("tr-TR");
    }
}