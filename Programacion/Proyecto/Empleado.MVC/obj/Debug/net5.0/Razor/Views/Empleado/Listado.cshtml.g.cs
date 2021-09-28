#pragma checksum "C:\Users\juan_\Desktop\CursoStrapp\Programacion\Proyecto\Empleado.MVC\Views\Empleado\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaf05605d9fa9ed3f6cbb2450f7f434ce1316576"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Listado), @"mvc.1.0.view", @"/Views/Empleado/Listado.cshtml")]
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
#line 1 "C:\Users\juan_\Desktop\CursoStrapp\Programacion\Proyecto\Empleado.MVC\Views\_ViewImports.cshtml"
using Empleado.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\juan_\Desktop\CursoStrapp\Programacion\Proyecto\Empleado.MVC\Views\_ViewImports.cshtml"
using Empleado.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf05605d9fa9ed3f6cbb2450f7f434ce1316576", @"/Views/Empleado/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665e294b289bcdb065e06dd59e17fb5ad8ed4148", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Listado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("iniciarPagina()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaf05605d9fa9ed3f6cbb2450f7f434ce13165763657", async() => {
                WriteLiteral("\r\n    <title>Empleado - Listado de personal</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaf05605d9fa9ed3f6cbb2450f7f434ce13165764680", async() => {
                WriteLiteral(@"
    <div>
        <h2>Listado de personal</h2>
        <br>
        <br>
        <a href=""/Empleado/Registro"">Agregar Empleado</a>
        <br>
        <br>
        <table style=""width: 100%;"">
            <tdead>
                <tr>
                    <th>
                        Id Empleado
                    </th>
                    <th>
                        Nombre
                    </th>
                    <th>
                        Puesto
                    </th>
                    <th>
                        Telefono
                    </th>
                    <th>
                        Correo
                    </th>
                    <th>
                        Editar
                    </th>
                    <th>
                        Eliminar
                    </th>
                </tr>
            </tdead>
            <tbody id=""datosEmpleado"">
               
            </tbody>
        </table>
    </div>
    <script>
     ");
                WriteLiteral(@"   function iniciarPagina(){
            
            const $datosEmpleado = document.getElementById(""datosEmpleado""),
            $fragment = document.createDocumentFragment();

            var requestOptions = {
                method: 'GET',
                redirect: 'follow'
                };

                fetch(""https://localhost:5006/Empleado"", requestOptions)
                .then(response => response.json())
                .then(result => {
                    result.forEach((emple) =>{
                        const $tr = document.createElement(""tr"");
                        $tr.innerHTML=`<td>${emple.idEmpleado}</td>
                                       <td>${emple.nombre}</td>
                                       <td>${emple.puesto}</td>
                                       <td>${emple.telefono}</td>
                                       <td>${emple.correo}</td>
                                       <td><a href=""/Empleado/Editar"">Editar</a></td>
                    ");
                WriteLiteral(@"                   <td><a href=""#"">Eliminar</a></td>`;
                        $fragment.appendChild($tr);
                    })
                    $datosEmpleado.appendChild($fragment);
                    console.log(result)
                })
                .catch(error => console.log('error', error));
            }

    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
