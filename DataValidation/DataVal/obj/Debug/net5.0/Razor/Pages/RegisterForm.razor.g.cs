#pragma checksum "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd837b23c134961159cf68a18dc7f2ad291e94c6"
// <auto-generated/>
#pragma warning disable 1591
namespace DataVal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using DataVal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Tutorials\DataValidation\DataValidation\DataVal\_Imports.razor"
using DataVal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
using System.Text.Encodings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
using Common.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegisterForm")]
    public partial class RegisterForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                  amg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                      ValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "card BordaRelevo");
                __builder2.AddMarkupContent(8, "<div class=\"card-header d-flex justify-content-center mt-2\" style=\"background-color:lightgrey ; border:solid 1px; border-radius:3px;\"><h4 class=\"m-2 \">Teste de CPF Validator</h4></div>\r\n\r\n        \r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "card-body mt-1 p-3");
                __builder2.AddAttribute(11, "style", "background-color:lightgrey ; border: solid 1px; border-radius:3px;");
                __builder2.AddMarkupContent(12, "<label style=\"font-size:12px; color:blue; margin-bottom:0; \">Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control InBox");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                            amg.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => amg.Nome = __value, amg.Nome))));
                __builder2.AddAttribute(18, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => amg.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __Blazor.DataVal.Pages.RegisterForm.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, "font-size:11px; color:red", 22, 
#nullable restore
#line 20 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                         () => amg.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\r\n\r\n            ");
                __builder2.AddMarkupContent(24, "<label style=\"font-size:12px; color:blue; margin-bottom:0; margin-top:16px\">CPF</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "class", "form-control InBox");
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                            amg.Cpf

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => amg.Cpf = __value, amg.Cpf))));
                __builder2.AddAttribute(30, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => amg.Cpf));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __Blazor.DataVal.Pages.RegisterForm.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, "font-size:11px;color:red", 34, 
#nullable restore
#line 24 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                       () => amg.Cpf

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n\r\n            ");
                __builder2.AddMarkupContent(36, "<label style=\"font-size:12px; color:blue; margin-bottom:0; margin-top:16px\">Phone</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "class", "form-control InBox");
                __builder2.AddAttribute(39, "type", "text");
                __builder2.AddAttribute(40, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                            amg.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => amg.Phone = __value, amg.Phone))));
                __builder2.AddAttribute(42, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => amg.Phone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __Blazor.DataVal.Pages.RegisterForm.TypeInference.CreateValidationMessage_2(__builder2, 44, 45, "font-size:11px;color:red", 46, 
#nullable restore
#line 28 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                       () => amg.Phone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n        \r\n        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "card-footer d-flex flex-row justify-content-end mt-4 mb-0 p-0");
                __builder2.AddAttribute(50, "style", "background-color:gainsboro; border:none;");
#nullable restore
#line 33 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
             if ( ShowButton)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(51, "<button class=\"btn btn-outline-primary mx-4\" type=\"button\">Cancel</button>");
#nullable restore
#line 37 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                 if (FormAction == "A")
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(52, "<button class=\"btn btn-outline-primary\" type=\"submit\">ADD NEW</button>");
#nullable restore
#line 38 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                 if ( FormAction == "U")
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(53, "<button class=\"btn btn-outline-primary\" type=\"submit\">UPDATE</button>");
#nullable restore
#line 40 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                                                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                 if ( FormAction == "D")
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(54, "button");
                __builder2.AddAttribute(55, "class", "btn btn-danger");
                __builder2.AddAttribute(56, "type", "button");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                                       (() => Delete( amg.RowId))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(58, "DELETE");
                __builder2.CloseElement();
#nullable restore
#line 42 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                                                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                                                                                     
            } else  {                                           

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "style", "border:none");
                __builder2.AddAttribute(62, "type", "text");
                __builder2.AddAttribute(63, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                                               Msg

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Msg = __value, Msg))));
                __builder2.AddAttribute(65, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Msg));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.OpenElement(67, "button");
                __builder2.AddAttribute(68, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(69, "type", "button");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
                                                                                 (() => Close())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(71, "CLOSE");
                __builder2.CloseElement();
#nullable restore
#line 46 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n\r\n");
            __builder.AddMarkupContent(73, @"<style>
    .BordaRelevo {
        max-width: auto;
        padding: 34px;
        background-color: gainsboro;
        box-shadow: 2px 10px 8px #101010;
        border-radius: 9px;
        border-color: black;
        border-style: double;
        margin: 5px 10px 20px 30px;
    }

    .InBox {
        background-color: gainsboro;
        border-radius: 5px;
        border-color: gray;
        border-style: solid;
        border-top: none;
        border-right: none;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\Tutorials\DataValidation\DataValidation\DataVal\Pages\RegisterForm.razor"
      
    public string FormAction = "A";
    public bool ShowButton = true;
    public string Msg = "Status messages";
    public AmigoModel amg = new();

    protected override void OnInitialized()
    {
            base.OnInitialized();               
    }

    public void ValidSubmit()
    {
        if (FormAction.Equals("A")) 
        {
            amg.Cpf = Convert.ToDouble( amg.Cpf.Replace(".", "").Replace("-", "")).ToString("### ### ###-##").Replace(" ", ".");            
            ShowButton = false; 
        }
                
            if (FormAction.Equals("U")) { ShowButton = false; }    
    }

    private void Delete(int RowId) 
    {
            ShowButton = true;
    }

    private void Close() => ShowButton = true;

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DataVal.Pages.RegisterForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
