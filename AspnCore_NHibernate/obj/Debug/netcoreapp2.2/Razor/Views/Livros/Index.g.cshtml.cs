#pragma checksum "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90e20d1f5f8d358da20d5cbbaf796eecc32afa9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livros_Index), @"mvc.1.0.view", @"/Views/Livros/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livros/Index.cshtml", typeof(AspNetCore.Views_Livros_Index))]
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
#line 1 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\_ViewImports.cshtml"
using AspnCore_NHibernate;

#line default
#line hidden
#line 2 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\_ViewImports.cshtml"
using AspnCore_NHibernate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e20d1f5f8d358da20d5cbbaf796eecc32afa9b", @"/Views/Livros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"151a27e4fb2dafed11d4fa0bbbf7829a4c4ed3ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Livros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AspnCore_NHibernate.Models.Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
      
    ViewData["Title"] = "Index";
    

#line default
#line hidden
            BeginContext(105, 53, true);
            WriteLiteral("\r\n    <h1>Relação de Livros</h1>\r\n\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(158, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e20d1f5f8d358da20d5cbbaf796eecc32afa9b3913", async() => {
                BeginContext(181, 10, true);
                WriteLiteral("Criar Novo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(195, 94, true);
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
            EndContext();
            BeginContext(290, 43, false);
#line 15 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.LivroId));

#line default
#line hidden
            EndContext();
            BeginContext(333, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(361, 42, false);
#line 16 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(403, 88, true);
            WriteLiteral("</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 21 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
            BeginContext(535, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(574, 42, false);
#line 23 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LivroId));

#line default
#line hidden
            EndContext();
            BeginContext(616, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(644, 41, false);
#line 24 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(685, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(735, 67, false);
#line 26 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
               Write(Html.ActionLink("Edit", "Editar", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(802, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(827, 72, false);
#line 27 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
               Write(Html.ActionLink("Details", "Detalhes", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(899, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(924, 70, false);
#line 28 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
               Write(Html.ActionLink("Delete", "Deletar", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(994, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "F:\3 - Dotnet\nhibernate\AspnCore_NHibernate\AspnCore_NHibernate\Views\Livros\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1041, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AspnCore_NHibernate.Models.Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
