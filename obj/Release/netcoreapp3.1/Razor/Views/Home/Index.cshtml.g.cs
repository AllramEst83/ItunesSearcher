#pragma checksum "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86350d3497addb5b88604d633154fe922f28356c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\_ViewImports.cshtml"
using ItunesSearcher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\_ViewImports.cshtml"
using ItunesSearcher.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
using ItunesSearcher.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
using ItunesSearcher.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86350d3497addb5b88604d633154fe922f28356c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57af43d2db45cff83371f0bbc340d10d870e049d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "paid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "free", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Start page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">

        <div class=""input-group inputContainer"">

            <input id=""searchInput"" type=""text"" class=""form-control"" placeholder=""Search Itunes for stuff..."" aria-label=""Search for apps"" aria-describedby=""basic-addon2"">
            <div class=""input-group-append"">
                <button id=""searchButton"" class=""btn btn-outline-secondary"" type=""button"">Search</button>
            </div>


        </div>

        <div class=""input-group inputContainer"">
            <select class=""form-control"" id=""genreSelect"">

");
#nullable restore
#line 30 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                 foreach (var genre in GenreService.GetGenres())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86350d3497addb5b88604d633154fe922f28356c5453", async() => {
#nullable restore
#line 32 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                                              Write(genre.GenreName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                       WriteLiteral(genre.GenreId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n\r\n        <div class=\"input-group inputContainer\" hidden>\r\n            <select class=\"form-control\" id=\"paidSelect\" disabled>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86350d3497addb5b88604d633154fe922f28356c7696", async() => {
                WriteLiteral("Paid");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86350d3497addb5b88604d633154fe922f28356c8869", async() => {
                WriteLiteral("free");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </select>
        </div>

    </div>




    <div class=""col-md-9"">

        <div class=""tableContainer"">
            <table id=""itunesContentTable"" class=""contentTable table table-striped table-bordered"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Namn</th>
                        <th>Beskrivning</th>
                        <th>Bild</th>
                    </tr>
                </thead>
                <tbody>
");
            WriteLiteral(@"                </tbody>
            </table>
        </div>

    </div>

    <div class=""col-md-3 cardContainer"">
            
        <div class=""card"">
            <div class=""card-header"">Wishlist</div>
            <div class=""card-body wishListBody"">
");
#nullable restore
#line 77 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                     if (WishService.UserHasWishes())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"list-group\">\r\n");
#nullable restore
#line 82 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                             foreach (var wish in WishService.ReturnUserWishes())
                            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item d-flex justify-content-between align-items-center\" data-itemid=\"");
#nullable restore
#line 86 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                                                                                                                      Write(wish.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\r\n                                    ");
#nullable restore
#line 88 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                               Write(wish.TrackName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    <div class=\"image-parent\">\r\n                                        <img data-appId=\"");
#nullable restore
#line 91 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                                                    Write(wish.AppId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", " src=\"", 2832, "\"", 2855, 1);
#nullable restore
#line 91 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
WriteAttributeValue("", 2838, wish.AppImageUrl, 2838, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid wishedhApp lessRoundEdges\" alt=\"appImage\">\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 94 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n");
#nullable restore
#line 96 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            No wishes added yet!\r\n                        </div>\r\n");
#nullable restore
#line 102 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"loggedOutMessage\">\r\n                        Pleas sign in to see your wishlist\r\n                    </div>\r\n");
#nullable restore
#line 109 "C:\Users\Kay Wiberg\source\repos\ItunesSearcher\ItunesSearcher\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>

</div>

<!-- The Modal -->
<div class=""modal fade"" id=""appPopUp"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title""></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                <div class=""card"">
                    <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 4092, "\"", 4098, 0);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                    <div class=\"card-body dialogCardBody\">\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWishService WishService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGenreService GenreService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
