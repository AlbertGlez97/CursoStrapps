#pragma checksum "C:\Users\juan_\Desktop\CursoStrapp\Proyectos\Empleado\Empleado.MVC\Views\Empleado\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f561c36bfaf84b29cce8ecfd416059b298748d81"
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
#line 1 "C:\Users\juan_\Desktop\CursoStrapp\Proyectos\Empleado\Empleado.MVC\Views\_ViewImports.cshtml"
using Empleado.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\juan_\Desktop\CursoStrapp\Proyectos\Empleado\Empleado.MVC\Views\_ViewImports.cshtml"
using Empleado.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f561c36bfaf84b29cce8ecfd416059b298748d81", @"/Views/Empleado/Listado.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f561c36bfaf84b29cce8ecfd416059b298748d813648", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f561c36bfaf84b29cce8ecfd416059b298748d814671", async() => {
                WriteLiteral(@"
    <div>
        <h2>Listado de personal</h2>
        <br>
        <br>
        <a href=""/Empleado/Registro"">Agregar Empleado</a>
        <br>
        <br>
        <table id=""tablaempleado"" style=""width: 100%;"">
            <thead>
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
                        Consultar
                    </th>
                    <th>
                        Editar
                    </th>
                    <th>
                        Eliminar
                    </th>
                </tr>
            </thead>
            <tbody>
");
                WriteLiteral(@"            </tbody>
        </table>
    </div>
    <script>
        function iniciarPagina(){
            cargarListado();
        }
        function cargarListado(){
            // 1.- Obtener la lista 
            // [{Empleado a}, {Empleado b}, {Empleado c}] --> httpGet
            var requestOptions = {
                method: 'GET',
                redirect: 'follow'
            };

            fetch(""https://localhost:5003/empleados"", requestOptions)
            .then(response =>{
                console.log(response);
                return response.json();
                
            })
            .then(result => {
                console.log(result);
                // 1.1 Si la peticion fue correcta 
                // 1.1.1 Buscar el elemento html table
                const tabla = document.getElementById(""tablaempleado"");
                const tbody = tabla.querySelectorAll(""tbody"")[0];
                // Limpiar el tbody de la tabla
                tbody.innerHTML");
                WriteLiteral(@" = "" "";
                // 1.1.2 Iteramos el arreglo de empleados
                for(let i = 0; i < result.length; i++){
                    // 1.1.2.1 Por cada iteracion crear una fila en la tabla <tr>
                    const tr = document.createElement(""tr"")
                    tbody.appendChild(tr);

                    let td = null;
                    let a = null;
                    // 1.1.2.2 Por cada propiedad del elemento empleado crea un td 
                    // 1.1.2.2.1 Para la propiedad idEmpleado crea un td, agregar el valor de la propiedad al td y agregar al td al tr que se esta creando
                    td = document.createElement(""td"");
                    td.textContent = result[i].idEmpleado;
                    tr.appendChild(td);
                    // 1.1.2.2.2 Para la propiedad Nombre crea un td, agregar el valor de la propiedad al td y agregar al td al tr que se esta creando
                    td = document.createElement(""td"");
                    td.textConte");
                WriteLiteral(@"nt = result[i].nombre + ' ' + result[i].apellidoPaterno + ' ' + result[i].apellidoMaterno;
                    tr.appendChild(td);
                    // 1.1.2.2.3 Para la propiedad Puesto crea un td, agregar el valor de la propiedad al td y agregar al td al tr que se esta creando
                    td = document.createElement(""td"");
                    td.textContent = result[i].puesto;
                    tr.appendChild(td);
                    // 1.1.2.2.4 Para la propiedad Telefono crea un td, agregar el valor de la propiedad al td y agregar al td al tr que se esta creando
                    td = document.createElement(""td"");
                    td.textContent = result[i].telefono;
                    tr.appendChild(td);
                    // 1.1.2.2.5 Para la propiedad Correo crea un td, agregar el valor de la propiedad al td y agregar al td al tr que se esta creando
                    td = document.createElement(""td"");
                    td.textContent = result[i].correoElectronico;
  ");
                WriteLiteral(@"                  tr.appendChild(td);
                     // 1.1.2.2.6 Para el Consultar para visualizar y agregar el href /Empleado/Editar + idEmpleado
                    td = document.createElement(""td"");
                    a = document.createElement(""a"");
                    a.href = ""/Empleado/Consultar/"" + result[i].idEmpleado;
                    a.textContent = ""Consultar"";
                    td.appendChild(a);
                    tr.appendChild(td);
                    // 1.1.2.2.6 Para el Editar crear un td, crear anchor y agregar el href /Empleado/Editar + idEmpleado
                    td = document.createElement(""td"");
                    a = document.createElement(""a"");
                    a.href = ""/Empleado/Editar/"" + result[i].idEmpleado;
                    a.textContent = ""Editar"";
                    td.appendChild(a);
                    tr.appendChild(td);
                    // 1.1.2.2.7 Para el Eliminar crear un td, crear anchor y agregar el href /Empleado/Eliminar + ");
                WriteLiteral(@"idEmpleado
                    td = document.createElement(""td"");
                    a = document.createElement(""a"");
                    a.href = ""javascript:eliminar("" + result[i].idEmpleado + "")"";
                    a.textContent = ""Eliminar"";
                    td.appendChild(a);
                    tr.appendChild(td);
                }
            })
            .catch(error => {
                // 1.2 Si la peticion no fue correcta 
                // 1.2.1 Enviar el mensaje de error al momento de realizar la consulta de empleados
                alert(""Error al momento de realizar la petición, contacte al administrador"");
                console.log(error);
            });
        }
        function eliminar(idEmpleado){
                // 1.- Inicio
                // 2.- Recibimos parametro de entrada idEmpleado
                // 3.- Confirmar que se desea eliminar
                let Eliminar = confirm(""¿Esta seguro que desea eliminar el empleado?"");
                // 3.1.-");
                WriteLiteral(@" Si la respuesta es si
                if(Eliminar == true)
                {
                    // 3.1.1.- Eliminar el empleado a traves de servicio de eliminar
                    var requestOptions = {
                    method: 'DELETE',
                    redirect: 'follow'
                    };
                    var url = ""https://localhost:5003/empleados/"" + idEmpleado;

                    fetch(url, requestOptions)
                    .then(response => response.json())
                    .then(result => {
                        // 3.1.1.1.- Si se elimino correctamente
                        // 3.1.1.2.- Actualizar lista de empleados
                        console.log(""El empleado se elimino correctamente"");
                        cargarListado();
                        // let actualizado = cargarListado();
                        //return actualizado;
                        //location.reload(cargarListado());
                    })
                    .catch(error =>");
                WriteLiteral(@" {
                        // 3.1.1.2.- Si no se elimino correctamente
                        // 3.1.1.2.1.- Informar que no se elimino correctamente
                        console.log('error', error)
                        alert(""Hubo un error al eliminar el empleado, contacte al administrador del sistema"");
                    });
                    // 3.1.2.- Actualizar lista de empleados
                }else
                // 3.2.- Si la respuesta es no 
                {
                    // 3.2.1.- Cancelar operación y salir
                    return;
                }
                // 4.- Fin
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