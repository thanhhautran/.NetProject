#pragma checksum "D:\Temp\NetProject\WebShop\Areas\Admin\Views\Icon\Modals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fd9f732aed8278c215aaa471caaee0adf1db2df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Icon_Modals), @"mvc.1.0.view", @"/Areas/Admin/Views/Icon/Modals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd9f732aed8278c215aaa471caaee0adf1db2df", @"/Areas/Admin/Views/Icon/Modals.cshtml")]
    public class Areas_Admin_Views_Icon_Modals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Temp\NetProject\WebShop\Areas\Admin\Views\Icon\Modals.cshtml"
  
    ViewData["Title"] = "Button";
    Layout = "~/Areas/Admin/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- MAIN CONTENT-->
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <i class=""mr-2 fa fa-align-justify""></i>
                            <strong class=""card-title"" v-if=""headerText"">Modals</strong>
                        </div>
                        <div class=""card-body"">

                            <!-- Button trigger modal -->
                            <button type=""button"" class=""btn btn-secondary mb-1"" data-toggle=""modal"" data-target=""#smallmodal"">
                                Small
                            </button>

                            <button type=""button"" class=""btn btn-secondary mb-1"" data-toggle=""modal"" data-target=""#mediumModal"">
                                Medium
                            </but");
            WriteLiteral(@"ton>
                            <button type=""button"" class=""btn btn-secondary mb-1"" data-toggle=""modal"" data-target=""#largeModal"">
                                Large
                            </button>
                            <button type=""button"" class=""btn btn-secondary mb-1"" data-toggle=""modal"" data-target=""#scrollmodal"">
                                Scrolling
                            </button>
                            <button type=""button"" class=""btn btn-secondary mb-1"" data-toggle=""modal"" data-target=""#staticModal"">
                                Static
                            </button>

                        </div>
                    </div>






                </div>
            </div>
        </div>
    </div>
</div>
<!-- modal small -->
<div class=""modal fade"" id=""smallmodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""smallmodalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-sm"" role=""document"">
        <div class=""modal-content""");
            WriteLiteral(@">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""smallmodalLabel"">Small Modal</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>
                    There are three species of zebras: the plains zebra, the mountain zebra and the Grévy's zebra. The plains zebra and the mountain
                    zebra belong to the subgenus Hippotigris, but Grévy's zebra is the sole species of subgenus Dolichohippus. The latter
                    resembles an ass, to which it is closely related, while the former two are more horse-like. All three belong to the
                    genus Equus, along with other living equids.
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" dat");
            WriteLiteral(@"a-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"">Confirm</button>
            </div>
        </div>
    </div>
</div>
<!-- end modal small -->
<!-- modal medium -->
<div class=""modal fade"" id=""mediumModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""mediumModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""mediumModalLabel"">Medium Modal</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>
                    There are three species of zebras: the plains zebra, the mountain zebra and the Grévy's zebra. The plains zebra and the mountain
                    zebra belong to the subgenus Hipp");
            WriteLiteral(@"otigris, but Grévy's zebra is the sole species of subgenus Dolichohippus. The latter
                    resembles an ass, to which it is closely related, while the former two are more horse-like. All three belong to the
                    genus Equus, along with other living equids.
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"">Confirm</button>
            </div>
        </div>
    </div>
</div>
<!-- end modal medium -->
<!-- modal large -->
<div class=""modal fade"" id=""largeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""largeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""largeModalLabel"">Large Modal</h5>
                <button type=""");
            WriteLiteral(@"button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>
                    There are three species of zebras: the plains zebra, the mountain zebra and the Grévy's zebra. The plains zebra and the mountain
                    zebra belong to the subgenus Hippotigris, but Grévy's zebra is the sole species of subgenus Dolichohippus. The latter
                    resembles an ass, to which it is closely related, while the former two are more horse-like. All three belong to the
                    genus Equus, along with other living equids.
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"">Confirm</button>
            </div>
        </div>
 ");
            WriteLiteral(@"   </div>
</div>
<!-- end modal large -->
<!-- modal scroll -->
<div class=""modal fade"" id=""scrollmodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""scrollmodalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""scrollmodalLabel"">Scrolling Long Content Modal</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>
                    Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi leo
                    risus, porta ac consectetur ac, vestibulum at eros.
                    <br> Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augu");
            WriteLiteral(@"e laoreet rutrum
                    faucibus dolor auctor.
                    <br> Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et.
                    Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.
                    <br> Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi
                    leo risus, porta ac consectetur ac, vestibulum at eros.
                    <br> Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum
                    faucibus dolor auctor.
                    <br> Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et.
                    Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.
                    <br> Cras mattis consectetur purus sit amet fermentum. Cras justo od");
            WriteLiteral(@"io, dapibus ac facilisis in, egestas eget quam. Morbi
                    leo risus, porta ac consectetur ac, vestibulum at eros.
                    <br> Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum
                    faucibus dolor auctor.
                    <br> Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et.
                    Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.
                    <br> Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi
                    leo risus, porta ac consectetur ac, vestibulum at eros.
                    <br> Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum
                    faucibus dolor auctor.
                    <br> Aenean lacinia bibendum nulla sed consect");
            WriteLiteral(@"etur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et.
                    Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.
                    <br> Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi
                    leo risus, porta ac consectetur ac, vestibulum at eros.
                    <br> Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum
                    faucibus dolor auctor.
                    <br> Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et.
                    Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.
                    <br> Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi
                    leo risus, porta ac consectetur ac, vestibulum at ero");
            WriteLiteral(@"s.
                    <br> Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum
                    faucibus dolor auctor.
                    <br> Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et.
                    Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"">Confirm</button>
            </div>
        </div>
    </div>
</div>
<!-- end modal scroll -->
<!-- modal static -->
<div class=""modal fade"" id=""staticModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticModalLabel"" aria-hidden=""true""
     data-backdrop=""static"">
    <div class=""modal-dialog modal-sm"" role=""document"">
        <div class=");
            WriteLiteral(@"""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""staticModalLabel"">Static Modal</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>
                    This is a static modal, backdrop click will not close it.
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"">Confirm</button>
            </div>
        </div>
    </div>
</div>
<!-- end modal static -->
		
<!-- END PAGE CONTAINER-->
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
