#pragma checksum "D:\quantico06\ISTA_Project\BugTracker\BugTracker 1.0\Views\Shared\_TicketRecords.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25f35ff222c6b6c753764841fa278eec50fb9b80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TicketRecords), @"mvc.1.0.view", @"/Views/Shared/_TicketRecords.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\quantico06\ISTA_Project\BugTracker\BugTracker 1.0\Views\_ViewImports.cshtml"
using BugTracker.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\quantico06\ISTA_Project\BugTracker\BugTracker 1.0\Views\_ViewImports.cshtml"
using BugTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25f35ff222c6b6c753764841fa278eec50fb9b80", @"/Views/Shared/_TicketRecords.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b663a73ba05130bb6d83b08f051f8213564406f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TicketRecords : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TicketRecord>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\quantico06\ISTA_Project\BugTracker\BugTracker 1.0\Views\Shared\_TicketRecords.cshtml"
 foreach (var record in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-sm table-bordered table-secondary text-black\">\r\n        <tbody>\r\n            <tr><th>Updated</th><td>");
#nullable restore
#line 7 "D:\quantico06\ISTA_Project\BugTracker\BugTracker 1.0\Views\Shared\_TicketRecords.cshtml"
                               Write(record.TicketUpdatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n            <tr><th>Status</th><td>");
#nullable restore
#line 8 "D:\quantico06\ISTA_Project\BugTracker\BugTracker 1.0\Views\Shared\_TicketRecords.cshtml"
                              Write(record.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n            <tr><th>Priority</th><td>");
#nullable restore
#line 9 "D:\quantico06\ISTA_Project\BugTracker\BugTracker 1.0\Views\Shared\_TicketRecords.cshtml"
                                Write(record.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n            <tr><th>Description</th><td>");
#nullable restore
#line 10 "D:\quantico06\ISTA_Project\BugTracker\BugTracker 1.0\Views\Shared\_TicketRecords.cshtml"
                                   Write(record.TicketDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 13 "D:\quantico06\ISTA_Project\BugTracker\BugTracker 1.0\Views\Shared\_TicketRecords.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TicketRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591