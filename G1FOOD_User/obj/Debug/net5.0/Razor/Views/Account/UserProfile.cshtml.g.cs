#pragma checksum "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Account\UserProfile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ced068eb8d42e45f7e5bc8a440bc34c9df1ed5772f6e1f1f865f1e67054386fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserProfile), @"mvc.1.0.view", @"/Views/Account/UserProfile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\_ViewImports.cshtml"
using G1FOOD_User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\_ViewImports.cshtml"
using G1FOOD_User.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ced068eb8d42e45f7e5bc8a440bc34c9df1ed5772f6e1f1f865f1e67054386fa", @"/Views/Account/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ec284603a7a48677156f49aea0516ffeba6978c27d4639d8d6bb66b9a9c500b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.DTO.AccountDTO>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Account\UserProfile.cshtml"
  
    ViewData["Title"] = "UserProfile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid wrapper"">
    <div class=""container-fluid container-fluid-form"">
        <div class=""wrapper-form text-left"">
            <div class=""form-heading-group"">
                <i class=""fa-solid fa-clipboard-user fa-circle""></i>
                <h2 class=""form-heading"">USER PROFILE</h2>
            </div>
            <div class=""form-control-group"">
                <label class=""form-text-label"">Name:</label>
                <label> ");
#nullable restore
#line 17 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Account\UserProfile.cshtml"
                   Write(Html.DisplayFor(model => model.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\">Email</label>\r\n                <label>");
#nullable restore
#line 21 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Account\UserProfile.cshtml"
                  Write(Html.DisplayFor(model => model.AccountEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\">Address:</label>\r\n                <label>");
#nullable restore
#line 25 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Account\UserProfile.cshtml"
                  Write(Html.DisplayFor(model => model.AccountAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\">Phone:</label>\r\n                <label>");
#nullable restore
#line 29 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Account\UserProfile.cshtml"
                  Write(Html.DisplayFor(model => model.AccountPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\">Birthday:</label>\r\n                <label>");
#nullable restore
#line 33 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Account\UserProfile.cshtml"
                  Write(Html.DisplayFor(model => model.AccountBirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-btn-group\">\r\n");
            WriteLiteral("                \r\n                <button type=\"button\" class=\"btn btn-primary\">\r\n                    ");
#nullable restore
#line 39 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Account\UserProfile.cshtml"
               Write(Html.ActionLink("Edit profile", "Edit", new { id = Model.AccountId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.DTO.AccountDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
