#pragma checksum "C:\Users\renat\OneDrive\Área de Trabalho\Projeto-InstaDev\Views\Perfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51a5404538244a3f7748356edb481f6aa933b7d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Index), @"mvc.1.0.view", @"/Views/Perfil/Index.cshtml")]
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
#line 1 "C:\Users\renat\OneDrive\Área de Trabalho\Projeto-InstaDev\Views\_ViewImports.cshtml"
using Projeto_InstaDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\renat\OneDrive\Área de Trabalho\Projeto-InstaDev\Views\_ViewImports.cshtml"
using Projeto_InstaDev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a5404538244a3f7748356edb481f6aa933b7d9", @"/Views/Perfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1bc84d1aab90cac05d0630ddd706279729949c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "EditarPerfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EditarPerfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\renat\OneDrive\Área de Trabalho\Projeto-InstaDev\Views\Perfil\Index.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <main class=""main"">
            <div class=""perfil""> 
            <!--Perfil-->
                    <div class=""perfil-todo"">
                        <div class=""content"">
                            <div class=""flex"">
                                <div class=""f-perfil"">
                               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51a5404538244a3f7748356edb481f6aa933b7d94538", async() => {
                WriteLiteral(" <img class=\"img-perfil\"  src=\"img/thank-you 3.png\" alt=\"Foto de Perfil do Usuário\"> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""info"">
                                    <div class=""username"">
                                        <h1>yes_baby</h1>
                                    
                                    </div>
                                    <div class=""infop"">
                                        <p class=""pu"">2 publicações</p>
                                        <p class=""pu"">128 seguindo</p>
                                        <p class=""pu"">214 seguidores</p>
                                    </div>
                                    <div class=""nome"">
                                        <h2>Marcos Jeeves</h2>
                                        <a href=""#"">Sair</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>           
            <!--Fim Perfil-->

   ");
            WriteLiteral(@"                 <!--Linha-->       
                    <hr class=""linha"" size=""2"" width=""100%"" color=""#EEEEEE"">
                    <!-- Fim linha-->


                    <!--Publicações-->
                            <div class=""pub"">
                                <div class=""publi"">
                                    <img class=""meio"" src=""img/pub.png"">
                                    <h3>PUBLICAÇÕES</h3> 
                                </div>    
                            
                                    <div class=""publicacao-toda"">
                                        <section class=""publicacao"">
                                            <div class=""content flex-center-bt"">
                                                    <img class=""foto-postagem"" src=""img/Rectangle 4.png"" alt=""Publicação do usuário"">
                                                <div class=""postagem"">
                                                    <div class=""postagem-perfil"">
         ");
            WriteLiteral(@"                                               <img class=""foto-profile"" src=""img/thank-you 4.png"" alt=""Imagem de perfil do usuário que fez o post"">
                                                        <div class=""nome-perfil"">
                                                            <h3>Marcos Jeeves</h3>
                                                            <p>Rio de Janeiro, Brasil</p>
                                                        </div>
                                                    </div>
                                                    <picture class=""icon"">
                                                        <img class=""curti"" src=""img/Vector (1).png"" alt=""Curtida"">
                                                        <img class=""com""src=""img/comentario.png"" alt=""Comentário"">
                                                    </picture>
                                                    <p class=""curtidas"">1954 curtidas</p>
                             ");
            WriteLiteral(@"                       <div class=""post-comentarios"">
                                                        <p><span class=""name""> fausto_silva</span> Esse cara é fera bixo!!! <img class=""iconc"" src=""img/Vector (2).png""> </p>
                                                        <p><span class=""name""> yes_baby</span> thank you <img class=""iconc"" src=""img/Vector (2).png""> </p>
                                                        <p><span class=""name""> adriano_stark</span> Quando eu adormecer, vou sonhar com você. <img class=""iconc"" src=""img/Vector (2).png""> <br>É sempre você. </p>
                                                        <p><span class=""name""> yes_baby</span> Yes baby!! <img class=""iconc"" src=""img/Vector (2).png""> </p>
                                                        <p class=""mais"">Ver todos os 585 comentários</p>
                                                    </div>
                                                </div>
                                            </d");
            WriteLiteral(@"iv>            
                                    </section>    
                                    <section class=""publicacao1"">
                                            <div class=""content flex-center-bt"">
                                                    <img src=""img/Rectangle 4.png"" alt=""Publicação do usuário"">
                                                <div class=""postagem"">
                                                    <div class=""postagem-perfil"">
                                                        <img class=""foto-profile"" src=""img/thank-you 4.png"" alt=""Imagem de perfil do usuário que fez o post"">
                                                        <div class=""nome-perfil"">
                                                            <h3>Marcos Jeeves</h3>
                                                            <p>Rio de Janeiro, Brasil</p>
                                                        </div>
                                                    </div");
            WriteLiteral(@">
                                                    <picture class=""icon"">
                                                        <img class=""curti"" src=""img/Vector (1).png"" alt=""Curtida"">
                                                        <img class=""com""src=""img/comentario.png"" alt=""Comentário"">
                                                    </picture>
                                                    <p class=""curtidas"">1954 curtidas</p>
                                                    <div class=""post-comentarios"">
                                                        <p><span class=""name""> fausto_silva</span> Esse cara é fera bixo!!! <img class=""iconc"" src=""img/Vector (2).png""> </p>
                                                        <p><span class=""name""> yes_baby</span> thank you <img class=""iconc"" src=""img/Vector (2).png""> </p>
                                                        <p><span class=""name""> adriano_stark</span> Quando eu adormecer, vou sonhar com você. <");
            WriteLiteral(@"img class=""iconc"" src=""img/Vector (2).png""> <br>É sempre você. </p>
                                                        <p><span class=""name""> yes_baby</span> Yes baby!! <img class=""iconc"" src=""img/Vector (2).png""> </p>
                                                        <p class=""mais"">Ver todos os 585 comentários</p>
                                                    </div>
                                                </div>
                                            </div>            
                                    </section>  
                                </div> 
                            </div>    
                         <!--Fim publicação--> 
            </div>                  
        </main>            
");
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
