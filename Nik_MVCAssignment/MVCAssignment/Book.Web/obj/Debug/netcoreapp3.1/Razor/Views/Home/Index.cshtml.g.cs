#pragma checksum "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7974e2a5d622847baf3fe245ddca9790e39009d2"
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
#line 1 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\_ViewImports.cshtml"
using Book.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\_ViewImports.cshtml"
using Book.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7974e2a5d622847baf3fe245ddca9790e39009d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a41bd6a612a03f76fb256ab98b9deeb3e7efc8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book.BL.ReadingEvent>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReadingEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
  

    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6"">
        <h2 class=""text-center"">Upcoming Events</h2>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>
                        Date
                    </th>
                    <th>Event Name</th>
                </tr>
            </thead>

");
#nullable restore
#line 20 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
              if (item.Date >= DateTime.Now)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                     if (User.IsInRole("Admin"))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 28 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7974e2a5d622847baf3fe245ddca9790e39009d25991", async() => {
#nullable restore
#line 31 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                                                                                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"

                    }
                    else if (item.Type == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 40 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7974e2a5d622847baf3fe245ddca9790e39009d29695", async() => {
#nullable restore
#line 43 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                                                                                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                 
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </table>
    </div>
    <div class=""col-md-6"">
        <h2 class=""text-center"">Past Events</h2>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>
                        Date
                    </th>
                    <th>Event Name</th>
                </tr>
            </thead>

");
#nullable restore
#line 63 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                 if (item.Date < DateTime.Now)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                     if (User.IsInRole("Admin"))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 73 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7974e2a5d622847baf3fe245ddca9790e39009d215167", async() => {
#nullable restore
#line 76 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                                                                                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 79 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"

                    }
                    else if (item.Type == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 85 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7974e2a5d622847baf3fe245ddca9790e39009d218872", async() => {
#nullable restore
#line 88 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                                                                                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 91 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\nikitachaudhary\Desktop\Training\Code\nikitachaudhary_trainee\testing_file\Assignment5\MVCAssignment\Book.Web\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book.BL.ReadingEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
