#pragma checksum "D:\projectWeb\Web_MobileShop\.NetProject\WebShop\Areas\Admin\Views\Icon\ProgressBars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e663019c9580d62f2d5c578c6db5985b14ac5772"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Icon_ProgressBars), @"mvc.1.0.view", @"/Areas/Admin/Views/Icon/ProgressBars.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e663019c9580d62f2d5c578c6db5985b14ac5772", @"/Areas/Admin/Views/Icon/ProgressBars.cshtml")]
    public class Areas_Admin_Views_Icon_ProgressBars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\projectWeb\Web_MobileShop\.NetProject\WebShop\Areas\Admin\Views\Icon\ProgressBars.cshtml"
  
    ViewData["Title"] = "Button";
    Layout = "~/Areas/Admin/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Basic Progress Bar</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""muted"">
                                To create a default progress bar, add a
                                <code>.progress</code> class to a
                                <code>&lt;div&gt;</code> element:
                            </p>
                            <div class=""progress mb-3"">
                                <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""prog");
            WriteLiteral(@"ress mb-3"">
                                <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress mb-3"">
                                <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress mb-3"">
                                <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>
                    </div>
                    <!-- /# card -->

                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Labels</h4>
                        </div>
       ");
            WriteLiteral(@"                 <div class=""card-body"">
                            <p class=""muted"">
                                To create a default progress bar, add a
                                <code>.progress</code> class to a
                                <code>&lt;div&gt;</code> element:
                            </p>
                            <div class=""progress mb-2"">
                                <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                            </div>
                            <div class=""progress mb-2"">
                                <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100"">50%</div>
                            </div>
                            <div class=""progress mb-2"">
                                <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 75");
            WriteLiteral(@"%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100"">75%</div>
                            </div>
                            <div class=""progress mb-2"">
                                <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 90%"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100"">90%</div>
                            </div>
                        </div>
                    </div>
                    <!-- /# card -->

                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Striped</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""muted"">
                                To create a default progress bar, add a
                                <code>.progress-bar-striped</code> class to a
                                <code>&lt;div&gt;</code> element:
                            </p>
                            <div");
            WriteLiteral(@" class=""progress mb-2"">
                                <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0""
                                     aria-valuemax=""100"">25%</div>
                            </div>
                            <div class=""progress mb-2"">
                                <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%;"" aria-valuenow=""50"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress mb-2"">
                                <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%;"" aria-valuenow=""75"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress mb-2"">
                        ");
            WriteLiteral(@"        <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%;"" aria-valuenow=""100"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                        </div>
                    </div>
                    <!-- /# card -->
                </div>


                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Animated Progress Bar</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""muted"">
                                To create a default progress bar, add a
                                <code>.progress-bar-striped and .progress-bar-animated</code> class to a
                                <code>&lt;div&gt;</code> element:
                            </p>
                            <div class=""progress mb-3""");
            WriteLiteral(@">
                                <div class=""progress-bar bg-success progress-bar-striped progress-bar-animated"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25""
                                     aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress mb-3"">
                                <div class=""progress-bar bg-info progress-bar-striped progress-bar-animated"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50""
                                     aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress mb-3"">
                                <div class=""progress-bar bg-warning progress-bar-striped progress-bar-animated"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75""
                                     aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""pro");
            WriteLiteral(@"gress mb-3"">
                                <div class=""progress-bar bg-danger progress-bar-striped progress-bar-animated"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100""
                                     aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>
                    </div>
                    <!-- /# card -->

                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Animated Labels</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""muted"">
                                To create a default progress bar, add a
                                <code>.progress-bar-striped and .progress-bar-animated</code> class to a
                                <code>&lt;div&gt;</code> element:
                            </p>
                            <div class=""progress mb-2"">
          ");
            WriteLiteral(@"                      <div class=""progress-bar bg-success progress-bar-striped progress-bar-animated"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25""
                                     aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                            </div>
                            <div class=""progress mb-2"">
                                <div class=""progress-bar bg-info progress-bar-striped progress-bar-animated"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50""
                                     aria-valuemin=""0"" aria-valuemax=""100"">50%</div>
                            </div>
                            <div class=""progress mb-2"">
                                <div class=""progress-bar bg-warning progress-bar-striped progress-bar-animated"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75""
                                     aria-valuemin=""0"" aria-valuemax=""100"">75%</div>
                            </div>
                            <div class=""progres");
            WriteLiteral(@"s mb-2"">
                                <div class=""progress-bar bg-danger progress-bar-striped progress-bar-animated"" role=""progressbar"" style=""width: 90%"" aria-valuenow=""90""
                                     aria-valuemin=""0"" aria-valuemax=""100"">90%</div>
                            </div>
                        </div>
                    </div>
                    <!-- /# card -->

                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Heights</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""muted"">
                                To create a height progress bar, add a
                                <code>.progress-bar</code> class to a
                                <code>&lt;div&gt;</code> element:
                            </p>
                            <div class=""progress mb-2"" style=""height: 5px;"">
                                <div");
            WriteLiteral(@" class=""progress-bar bg-success"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress mb-2"" style=""height: 5px;"">
                                <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%;"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress mb-2"" style=""height: 5px;"">
                                <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 75%;"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress mb-2"" style=""height: 5px;"">
                                <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 100%;"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            ");
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
