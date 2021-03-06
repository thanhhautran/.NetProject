#pragma checksum "D:\DotNET\DoAnCuoiKy2\.NetProject\WebShop\Areas\Admin\Views\Chart\Chart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d518dda0a9311a93bcc2ac93dfe858c2379ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Chart_Chart), @"mvc.1.0.view", @"/Areas/Admin/Views/Chart/Chart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d518dda0a9311a93bcc2ac93dfe858c2379ca6", @"/Areas/Admin/Views/Chart/Chart.cshtml")]
    public class Areas_Admin_Views_Chart_Chart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DotNET\DoAnCuoiKy2\.NetProject\WebShop\Areas\Admin\Views\Chart\Chart.cshtml"
  
    ViewBag.Title = "Chart";
    var user = ViewBag.user;
    if (user != null)
    {
        Layout = "~/Areas/Admin/Views/Shared/_MasterLayout.cshtml";
    }

    var pie = ViewBag.PieChart;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""au-card m-b-30"">
                        <div class=""au-card-inner"">
                            <h3 class=""title-2 m-b-40"">Monthly Sales</h3>
                            <canvas id=""line-chart"" width=""800"" height=""450""></canvas>
                            <script>
                                new Chart(document.getElementById(""line-chart""), {
                                    type: 'line',
                                    data: {
                                        labels: [""January"", ""Ferbuary"", ""Match"", ""April"", ""May"", ""June"", ""July"", ""August"", ""September"",""October"", ""November"", ""December""],
                                        datasets: [{
                                            data:  ");
#nullable restore
#line 27 "D:\DotNET\DoAnCuoiKy2\.NetProject\WebShop\Areas\Admin\Views\Chart\Chart.cshtml"
                                              Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.LineDataPhone)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                                            label: ""Smartphone"",
                                            borderColor: ""#3e95cd"",
                                            fill: false
                                        }, {
                                            data: ");
#nullable restore
#line 32 "D:\DotNET\DoAnCuoiKy2\.NetProject\WebShop\Areas\Admin\Views\Chart\Chart.cshtml"
                                             Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.LineDataTablet)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                                            label: ""Tablet"",
                                            borderColor: ""#8e5ea2"",
                                            fill: false
                                        }, {
                                            data: ");
#nullable restore
#line 37 "D:\DotNET\DoAnCuoiKy2\.NetProject\WebShop\Areas\Admin\Views\Chart\Chart.cshtml"
                                             Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.LineDataHeadphone)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                                            label: ""Headphone"",
                                            borderColor: ""#3cba9f"",
                                            fill: false
                                        }, 
                                        ]
                                    },
                                    options: {
                                        title: {
                                            display: true,
                                            text: 'Monthly Sales'
                                        }
                                    }
                                });
                            </script>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""au-card m-b-30"">
                        <div class=""au-card-inner"">
                            <h3 class=""title-2 m-b-40"">Sales By Quarters</h3>
             ");
            WriteLiteral(@"               <canvas id=""pie-chart"" width=""500"" height=""400""></canvas>
                            <script>


                                // Pie chart
                                new Chart(document.getElementById(""pie-chart""), {
                                    type: 'pie',
                                    data: {
                                        labels: [""1"", ""2"", ""3"", ""4""],
                                        datasets: [{
                                            label: ""Receipts"",
                                            backgroundColor: [""#3e95cd"", ""#8e5ea2"", ""#3cba9f"", ""#e8c3b9""],
                                            data: ");
#nullable restore
#line 71 "D:\DotNET\DoAnCuoiKy2\.NetProject\WebShop\Areas\Admin\Views\Chart\Chart.cshtml"
                                             Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(pie)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        }]
                                    },
                                    options: {
                                        title: {
                                            display: true,
                                            text: 'The whole Turnover of ");
#nullable restore
#line 77 "D:\DotNET\DoAnCuoiKy2\.NetProject\WebShop\Areas\Admin\Views\Chart\Chart.cshtml"
                                                                    Write(ViewBag.YearNow);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                                        }
                                    }
                                });
                            </script>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-6"">
                    <div class=""au-card m-b-30"">
                        <div class=""au-card-inner"">
                            <h3 class=""title-2 m-b-40"">Product Type</h3>
                            <canvas id=""radar-chart"" width=""500"" height=""400""></canvas>
                            <script>
                                    //Radar chart
                                new Chart(document.getElementById(""radar-chart""), {
                                    type: 'radar',
                                    data: {
                                        labels:  ");
#nullable restore
#line 96 "D:\DotNET\DoAnCuoiKy2\.NetProject\WebShop\Areas\Admin\Views\Chart\Chart.cshtml"
                                            Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.productLabel)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                                        datasets: [
                                            {
                                                label: 'Products',
                                                fill: true,
                                                backgroundColor: ""rgba(255,99,132,0.2)"",
                                                borderColor: ""rgba(255,99,132,1)"",
                                                pointBorderColor: ""#fff"",
                                                pointBackgroundColor: ""rgba(255,99,132,1)"",
                                                pointBorderColor: ""#fff"",
                                                data:  ");
#nullable restore
#line 106 "D:\DotNET\DoAnCuoiKy2\.NetProject\WebShop\Areas\Admin\Views\Chart\Chart.cshtml"
                                                  Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.RadarData)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            }
                                        ]
                                    },
                                    options: {
                                        title: {
                                            display: true,
                                            text: 'Type of all Product'
                                        }
                                    }
                                });
                            </script>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""copyright"">
                            <p>Copyright © 2020 Creepy. All rights reserved. Template by <a href=""https://colorlib.com"">Colorlib</a>.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
