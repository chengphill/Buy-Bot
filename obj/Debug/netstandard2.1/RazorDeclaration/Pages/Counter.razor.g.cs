// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AIOPurchaseBot.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\_Imports.razor"
using AIOPurchaseBot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\_Imports.razor"
using AIOPurchaseBot.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\cheng\Desktop\Projects\csharp-practice\purchase-bot\AIOPurchaseBot\Pages\Counter.razor"
       
    private int currentCount = 0;

    [Parameter]
    public int IncrementAmount { get; set; } = 1;

    protected override void OnInitialized()
    {
        StateContainer.OnCountChange += StateHasChanged;
    }

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
        StateContainer.CurrentCountState += IncrementAmount;
    }
    private void ResetCount()
    {
        currentCount = 0;
        StateContainer.CurrentCountState = 0;
    }

    public void Dispose()
    {
        StateContainer.OnCountChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer StateContainer { get; set; }
    }
}
#pragma warning restore 1591
