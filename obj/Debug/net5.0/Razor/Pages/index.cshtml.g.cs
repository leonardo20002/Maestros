#pragma checksum "D:\Tachi\Projects_PrograAvanzada\3_Parcial\EscuelaWeb\Pages\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff444189d7f0a328c847a5e97e166f9b8b49a52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_index), @"mvc.1.0.razor-page", @"/Pages/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ff444189d7f0a328c847a5e97e166f9b8b49a52", @"/Pages/index.cshtml")]
    public class Pages_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- GET, POST, DELETE, OnGet, OnPost, OnDelete-->\r\n\r\n");
            WriteLiteral("    <link rel=\"stylesheet\" href=\"../css/index.css\">\r\n    <div class=\"login\">\r\n        <h1>Iniciar sesion</h1>\r\n        <h1>");
#nullable restore
#line 17 "D:\Tachi\Projects_PrograAvanzada\3_Parcial\EscuelaWeb\Pages\index.cshtml"
       Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        <form>
            <!-- Ingreso Usuario-->
            <label for=""ID_usuario"">Identificación</label>
            <input type=""number"" placeholder=""Ingresa ID"">
            <!-- Ingreso Contraseña-->
            <label for=""Contrasena"">Contraseña</label>
            <input type=""password"" placeholder=""Ingresa Contraseña"">
            <input type=""submit"" value=""Ingresar"">
        </form>
    </div>
");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Tachi\Projects_PrograAvanzada\3_Parcial\EscuelaWeb\Pages\index.cshtml"
 
    public string Time { get; set; } //specific time
    public void OnGet()
    {
        ViewData["Title"] = "Login Escuela";
        Model.Time = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_index>)PageContext?.ViewData;
        public Pages_index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
