#pragma checksum "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7be8dd60fda874f8c30f3aae0568af486a67c5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MinhaAgenda_Detalhes), @"mvc.1.0.view", @"/Views/MinhaAgenda/Detalhes.cshtml")]
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
#line 1 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\_ViewImports.cshtml"
using LoginRegistroProjeto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\_ViewImports.cshtml"
using LoginRegistroProjeto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7be8dd60fda874f8c30f3aae0568af486a67c5a", @"/Views/MinhaAgenda/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70bdda4590f540d8d60fcc680376752e6e1f70bf", @"/Views/_ViewImports.cshtml")]
    public class Views_MinhaAgenda_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginRegistroProjeto.Models.Entidades.MinhaAgenda>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div>\r\n    <h4>MinhaAgenda</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Local));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Local));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.DataEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Desafio\Desafio\Agenda\LoginRegistroProjeto\Views\MinhaAgenda\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.DataEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginRegistroProjeto.Models.Entidades.MinhaAgenda> Html { get; private set; }
    }
}
#pragma warning restore 1591
