#pragma checksum "E:\Tugas_BNI\Tugas_BNI\MVC\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e347e7e2e6a3aa85977bdbeca46c1fac74d817dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "E:\Tugas_BNI\Tugas_BNI\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Tugas_BNI\Tugas_BNI\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e347e7e2e6a3aa85977bdbeca46c1fac74d817dc", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("forgotPasswordForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Tugas_BNI\Tugas_BNI\MVC\Views\Account\Index.cshtml"
  
    Layout = "_LoginLayout";
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Login -->
<div class=""container"">
    <div class=""col-lg-6 m-5"">
        <div class="" card"" style=""margin-left:250px; width:550px"">
            <div class=""card-body m-2"">
                <div class=""p-3"">
                    <h4 class=""text-muted font-18 m-b-2 text-center"">Welcome</h4>
                    <span style=""text-align: center;"" class=""fa fa-pencil"" aria-hidden=""true""></span>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e347e7e2e6a3aa85977bdbeca46c1fac74d817dc5217", async() => {
                WriteLiteral(@"
                        <div class=""mb-3"">
                            <label for=""email"">Email</label>
                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text"" id=""inputGroup-sizing-default"">
                                        <i class=""fas fa-envelope""></i>
                                    </span>
                                </div>
                                <input type=""email"" id=""emaillogin"" class=""form-control"" name=""Email"" placeholder=""Email"" aria-label=""Default"" aria-describedby=""inputGroup-sizing-default"" required>
                            </div>
                        </div>
                        <div class=""mb-3"">
                            <label for=""email"">Password</label>
                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <s");
                WriteLiteral(@"pan class=""input-group-text"" id=""inputGroup-sizing-default"">
                                        <i class=""fas fa-key""></i>
                                    </span>
                                </div>
                                <input type=""password"" id=""passwordlogin"" class=""form-control"" name=""Password"" placeholder=""Password"" aria-label=""Default"" aria-describedby=""inputGroup-sizing-default"" required>

                            </div>
                        </div>
                        <input type=""checkbox"" onclick=""myFunction()"">  Show Password
                        <div class=""mb-1 text-right"">
                            <a data-toggle=""modal"" data-target=""#forgotpassword"" class=""text-right text-decoration-none"" style=""cursor: pointer"" onclick=""reset()"">
                                Forgot Password?
                            </a>
                        </div>
                        <div class=""mb-1 text-right"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e347e7e2e6a3aa85977bdbeca46c1fac74d817dc7608", async() => {
                    WriteLiteral("\r\n                                Register\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"submit\" class=\"btn btn-primary\">Login</button>\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""forgotpassword"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addModalLabel"">Forgot Password</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e347e7e2e6a3aa85977bdbeca46c1fac74d817dc11117", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""col-form-label"">Email</label>
                        <input type=""email"" class=""form-control"" id=""email"" name=""email"">
                    </div>
                    <div class=""modal-footer "">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                    <div id=""loading-overlay"">
                        <div class=""loading-icon""></div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var obj;
        $(""#loginForm"").submit(function (e) {
            e.preventDefault();
            var form = $(this)
            $.ajax({
                type: ""POST"",
                url: ""account/login"",
                data: form.serialize(),
                success: function (data) {
                    localStorage.setItem(""token"", data['token']);
                    parseJwt(localStorage.getItem('token'));

                    var roles = obj.role;
                    sessionStorage.role = roles;
                    console.log(roles);
                    if (data.status == '200') {
                         Swal.fire({
                            icon: 'success',
                             title: 'Your Login Success',
                             closeOnClickOutside: false,
                            showConfirmButton: true,
                             timer: 1500,
                        })
                        window.location.href = """);
#nullable restore
#line 114 "E:\Tugas_BNI\Tugas_BNI\MVC\Views\Account\Index.cshtml"
                                           Write(Url.Action("Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";

                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Email or Password Wrong!!',
                        })
                    }
                }
            });
        });

        function parseJwt(token) {
            var base64Url = token.split('.')[1];
            var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
            var jsonPayload = decodeURIComponent(atob(base64).split('').map(function(c) {
                return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
            }).join(''));
            obj = JSON.parse(jsonPayload);
            return obj;
        };

        $(document).ready(function () {
            $(""#loading-overlay"").hide();
        });

        $(""#forgotPasswordForm"").submit(function (e) {
            e.preventDefault();
            var form = $(this)
            $.ajax({
           ");
                WriteLiteral(@"     type: ""PUT"",
                url: ""account/ResetPassword"",
                data: form.serialize(),
                beforeSend: function(){
                 $(""#loading-overlay"").show();
                },
                success: function (data) {
                    $(""#loading-overlay"").hide();
                    Swal.fire({
                            icon: 'success',
                            title: 'Email Has Been Sent To Your Email, Please Check your Email',
                            showConfirmButton: true
                    })
                    $('#forgotpassword').modal('hide');
                },
                error: function (error, data) {
                    $(""#loading-overlay"").hide();
                    alert('error');
                },

            });
        })

         function reset() {
            isUpdate = 0;
            $('#forgotPasswordForm').trigger('reset');
        }

        function myFunction() {
  var x = document.getElementById(");
                WriteLiteral("\"passwordlogin\");\r\n  if (x.type === \"password\") {\r\n    x.type = \"text\";\r\n  } else {\r\n    x.type = \"password\";\r\n  }\r\n}\r\n    </script>\r\n");
            }
            );
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