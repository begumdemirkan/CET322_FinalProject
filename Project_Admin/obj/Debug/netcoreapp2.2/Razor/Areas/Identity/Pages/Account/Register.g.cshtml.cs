#pragma checksum "C:\Users\Begum\Desktop\CET322_FinalProject\Project_Admin\Areas\Identity\Pages\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "236a67f0bb0ee4c3a6264f4cf141a0ce9525c87c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project_Admin.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Register), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Register.cshtml", typeof(Project_Admin.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Register))]
namespace Project_Admin.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Begum\Desktop\CET322_FinalProject\Project_Admin\Areas\Identity\Pages\_ViewImports.cshtml"
using Project_Admin.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\Begum\Desktop\CET322_FinalProject\Project_Admin\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\Begum\Desktop\CET322_FinalProject\Project_Admin\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Project_Admin.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236a67f0bb0ee4c3a6264f4cf141a0ce9525c87c", @"/Areas/Identity/Pages/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aa2577daf9f689ea985b54ce9abbaa47c81024d", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb59f919f8aba4e3b201fae270c416a53c30eca", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animsition"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 1599, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236a67f0bb0ee4c3a6264f4cf141a0ce9525c87c5334", async() => {
                BeginContext(41, 1586, true);
                WriteLiteral(@"
    <!-- Required meta tags-->
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content=""au theme template"">
    <meta name=""author"" content=""Hau Nguyen"">
    <meta name=""keywords"" content=""au theme template"">
    <!-- Title Page-->
    <title>Register</title>
    <!-- Fontfaces CSS-->
    <link href=""css/font-face.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/font-awesome-4.7/css/font-awesome.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/font-awesome-5/css/fontawesome-all.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/mdi-font/css/material-design-iconic-font.min.css"" rel=""stylesheet"" media=""all"">
    <!-- Bootstrap CSS-->
    <link href=""vendor/bootstrap-4.1/bootstrap.min.css"" rel=""stylesheet"" media=""all"">
    <!-- Vendor CSS-->
    <link href=""vendor/animsition/animsition.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/bootstrap-progres");
                WriteLiteral(@"sbar/bootstrap-progressbar-3.3.4.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/wow/animate.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/css-hamburgers/hamburgers.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/slick/slick.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/select2/select2.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/perfect-scrollbar/perfect-scrollbar.css"" rel=""stylesheet"" media=""all"">
    <!-- Main CSS-->
    <link href=""css/theme.css"" rel=""stylesheet"" media=""all"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1634, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1636, 3823, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236a67f0bb0ee4c3a6264f4cf141a0ce9525c87c8235", async() => {
                BeginContext(1661, 522, true);
                WriteLiteral(@"
    <div class=""page-wrapper"">
        <div class=""page-content--bge5"">
            <div class=""container"">
                <div class=""login-wrap"">
                    <div class=""login-content"">
                        <div class=""login-logo"">
                            <a href=""#"">
                                <img src=""images/icon/logo.png"" alt=""CoolAdmin"">
                            </a>
                        </div>
                        <div class=""login-form"">
                            ");
                EndContext();
                BeginContext(2183, 1823, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236a67f0bb0ee4c3a6264f4cf141a0ce9525c87c9161", async() => {
                    BeginContext(2213, 1786, true);
                    WriteLiteral(@"
                                <div class=""form-group"">
                                    <label>Username</label>
                                    <input class=""au-input au-input--full"" type=""text"" name=""username"" placeholder=""Username"">
                                </div>
                                <div class=""form-group"">
                                    <label>Email Address</label>
                                    <input class=""au-input au-input--full"" type=""email"" name=""email"" placeholder=""Email"">
                                </div>
                                <div class=""form-group"">
                                    <label>Password</label>
                                    <input class=""au-input au-input--full"" type=""password"" name=""password"" placeholder=""Password"">
                                </div>
                                <div class=""login-checkbox"">
                                    <label>
                                        <input typ");
                    WriteLiteral(@"e=""checkbox"" name=""aggree"">Agree the terms and policy
                                    </label>
                                </div>
                                <button class=""au-btn au-btn--block au-btn--green m-b-20"" type=""submit"">register</button>
                                <div class=""social-login-content"">
                                    <div class=""social-button"">
                                        <button class=""au-btn au-btn--block au-btn--blue m-b-20"">register with facebook</button>
                                        <button class=""au-btn au-btn--block au-btn--blue2"">register with twitter</button>
                                    </div>
                                </div>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4006, 1446, true);
                WriteLiteral(@"
                            <div class=""register-link"">
                                <p>
                                    Already have account?
                                    <a href=""#"">Sign In</a>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Jquery JS-->
    <script src=""vendor/jquery-3.2.1.min.js""></script>
    <!-- Bootstrap JS-->
    <script src=""vendor/bootstrap-4.1/popper.min.js""></script>
    <script src=""vendor/bootstrap-4.1/bootstrap.min.js""></script>
    <!-- Vendor JS       -->
    <script src=""vendor/slick/slick.min.js"">
    </script>
    <script src=""vendor/wow/wow.min.js""></script>
    <script src=""vendor/animsition/animsition.min.js""></script>
    <script src=""vendor/bootstrap-progressbar/bootstrap-progressbar.min.js"">
    </script>
    <script src=""vendor/counter-up/jquery.waypoints.min.js""></scri");
                WriteLiteral(@"pt>
    <script src=""vendor/counter-up/jquery.counterup.min.js"">
    </script>
    <script src=""vendor/circle-progress/circle-progress.min.js""></script>
    <script src=""vendor/perfect-scrollbar/perfect-scrollbar.js""></script>
    <script src=""vendor/chartjs/Chart.bundle.min.js""></script>
    <script src=""vendor/select2/select2.min.js"">
    </script>
    <!-- Main JS-->
    <script src=""js/main.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5459, 31, true);
            WriteLiteral("\r\n</html>\r\n<!-- end document-->");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
