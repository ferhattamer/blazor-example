using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace  ex5.Pages
{

    public class OrnekBase:ComponentBase{

        [Inject]
            protected NavigationManager nvg{get;set;}
        public void git(){
            nvg.NavigateTo("/counter");
    }
    }
    
    
}