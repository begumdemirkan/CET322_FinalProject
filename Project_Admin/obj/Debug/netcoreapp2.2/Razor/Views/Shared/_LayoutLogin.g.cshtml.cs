#pragma checksum "C:\Users\Begum\Desktop\CET322_FinalProject\Project_Admin\Views\Shared\_LayoutLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf00fbd0bf94b438942c9481cb17116948f42829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutLogin), @"mvc.1.0.view", @"/Views/Shared/_LayoutLogin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LayoutLogin.cshtml", typeof(AspNetCore.Views_Shared__LayoutLogin))]
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
#line 1 "C:\Users\Begum\Desktop\CET322_FinalProject\Project_Admin\Views\_ViewImports.cshtml"
using Project_Admin;

#line default
#line hidden
#line 2 "C:\Users\Begum\Desktop\CET322_FinalProject\Project_Admin\Views\_ViewImports.cshtml"
using Project_Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf00fbd0bf94b438942c9481cb17116948f42829", @"/Views/Shared/_LayoutLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8dc45f48968cd9accab67b04893a7a9fb25be0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(37, 1600, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf00fbd0bf94b438942c9481cb17116948f428294703", async() => {
                BeginContext(43, 1587, true);
                WriteLiteral(@"
  
    <!-- Required meta tags-->
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content=""au theme template"">
    <meta name=""author"" content=""Hau Nguyen"">
    <meta name=""keywords"" content=""au theme template"">
    <!-- Title Page-->
    <title>Login</title>
    <!-- Fontfaces CSS-->
    <link href=""css/font-face.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/font-awesome-4.7/css/font-awesome.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/font-awesome-5/css/fontawesome-all.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/mdi-font/css/material-design-iconic-font.min.css"" rel=""stylesheet"" media=""all"">
    <!-- Bootstrap CSS-->
    <link href=""vendor/bootstrap-4.1/bootstrap.min.css"" rel=""stylesheet"" media=""all"">
    <!-- Vendor CSS-->
    <link href=""vendor/animsition/animsition.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""vendor/bootstrap-progre");
                WriteLiteral(@"ssbar/bootstrap-progressbar-3.3.4.min.css"" rel=""stylesheet"" media=""all"">
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
            BeginContext(1637, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1641, 3762, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf00fbd0bf94b438942c9481cb17116948f428297609", async() => {
                BeginContext(1666, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1673, 12, false);
#line 34 "C:\Users\Begum\Desktop\CET322_FinalProject\Project_Admin\Views\Shared\_LayoutLogin.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1685, 522, true);
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
                BeginContext(2207, 1688, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf00fbd0bf94b438942c9481cb17116948f428298889", async() => {
                    BeginContext(2237, 1651, true);
                    WriteLiteral(@"
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
                                        <input type=""checkbox"" name=""remember"">Remember Me
                                    </label>
                                    <label>
                                        <a href=""#"">Forgotten Password?</a>
                                    </label>
                               ");
                    WriteLiteral(@" </div>
                                <button class=""au-btn au-btn--block au-btn--green m-b-20"" type=""submit"">sign in</button>
                                <div class=""social-login-content"">
                                    <div class=""social-button"">
                                        <button class=""au-btn au-btn--block au-btn--blue m-b-20"">sign in with facebook</button>
                                        <button class=""au-btn au-btn--block au-btn--blue2"">sign in with twitter</button>
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
                BeginContext(3895, 1457, true);
                WriteLiteral(@"
                            <div class=""register-link"">
                                <p>
                                    Don't you have account?
                                    <a href=""#"">Sign Up Here</a>
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
    <script src=""vendor/counter-up/jquery.waypoints.min.js""");
                WriteLiteral(@"></script>
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
                BeginContext(5353, 41, false);
#line 105 "C:\Users\Begum\Desktop\CET322_FinalProject\Project_Admin\Views\Shared\_LayoutLogin.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(5394, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(5403, 33, true);
            WriteLiteral("\r\n</html>\r\n<!-- end document-->\r\n");
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
