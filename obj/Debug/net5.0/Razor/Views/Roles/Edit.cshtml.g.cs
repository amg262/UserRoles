#pragma checksum "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5babe35ba384335a4c644dfb94c21d778ec84f98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Edit), @"mvc.1.0.view", @"/Views/Roles/Edit.cshtml")]
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
#line 1 "C:\Users\Andy\IdeaProjects\UserRoles\Views\_ViewImports.cshtml"
using UserRoles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
using UserRoles.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5babe35ba384335a4c644dfb94c21d778ec84f98", @"/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bac874382a58c7131b36713d537aed499266e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Edit Role</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5babe35ba384335a4c644dfb94c21d778ec84f985084", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 6 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5babe35ba384335a4c644dfb94c21d778ec84f986669", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"roleName\"");
                BeginWriteAttribute("value", " value=\"", 215, "\"", 239, 1);
#nullable restore
#line 9 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 223, Model.Role.Name, 223, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"roleId\"");
                BeginWriteAttribute("value", " value=\"", 283, "\"", 305, 1);
#nullable restore
#line 10 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 291, Model.Role.Id, 291, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <ul class=\"list-group mb-2\">\r\n        <li class=\"list-group-item list-group-item-success\">Add To ");
#nullable restore
#line 12 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
                                                              Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Role</li>\r\n");
#nullable restore
#line 13 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li class=\"list-group-item\">\r\n                All Users Are Members\r\n            </li>\r\n");
#nullable restore
#line 18 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
             foreach (AppUser user in Model.NonMembers)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"list-group-item\">\r\n                    <input type=\"checkbox\" name=\"IdsToAdd\"");
                BeginWriteAttribute("id", " id=\"", 808, "\"", 821, 1);
#nullable restore
#line 24 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 813, user.Id, 813, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 822, "\"", 838, 1);
#nullable restore
#line 24 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 830, user.Id, 830, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 870, "\"", 884, 1);
#nullable restore
#line 25 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 876, user.Id, 876, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
                                     Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </li>\r\n");
#nullable restore
#line 27 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <ul class=\"list-group mb-2\">\r\n        <li class=\"list-group-item list-group-item-danger\">Remove From ");
#nullable restore
#line 31 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
                                                                  Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Role</li>\r\n");
#nullable restore
#line 32 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li class=\"list-group-item\">\r\n                No Users Are Members\r\n            </li>\r\n");
#nullable restore
#line 37 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
             foreach (AppUser user in Model.Members)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"list-group-item\">\r\n                    <input type=\"checkbox\" name=\"IdsToDelete\"");
                BeginWriteAttribute("id", " id=\"", 1467, "\"", 1480, 1);
#nullable restore
#line 43 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1472, user.Id, 1472, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1481, "\"", 1497, 1);
#nullable restore
#line 43 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1489, user.Id, 1489, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1529, "\"", 1543, 1);
#nullable restore
#line 44 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1535, user.Id, 1535, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
                                     Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </li>\r\n");
#nullable restore
#line 46 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Andy\IdeaProjects\UserRoles\Views\Roles\Edit.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n    <button type=\"submit\" class=\"btn btn-outline-primary\">Save</button>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5babe35ba384335a4c644dfb94c21d778ec84f9813767", async() => {
                    WriteLiteral("Done");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
