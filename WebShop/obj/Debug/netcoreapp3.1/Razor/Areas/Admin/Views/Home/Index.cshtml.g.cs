<<<<<<< HEAD
#pragma checksum "D:\projectWeb\Web_MobileShop\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eca97559d7eb0278ad47d8701407bb8efd2f5be2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca97559d7eb0278ad47d8701407bb8efd2f5be2", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\projectWeb\Web_MobileShop\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_MasterLayout.cshtml";

    var totalUser = ViewBag.TotalUser;
    var totalProdct = ViewBag.totalProduct;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""section__content section__content--p30"">
    <div class=""container-fluid"">
        <div class=""rowEarnings By Items
            <div class=""col-md-12"">
                <div class=""overview-wrap"">
                    <h2 class=""title-1"">overview</h2>
                    <button class=""au-btn au-btn-icon au-btn--blue"">
                        <i class=""zmdi zmdi-plus""></i>add item
                    </button>
                </div>
            </div>
        </div>
        <div class=""row m-t-25"">
            <div class=""col-sm-6 col-lg-3"">
                <div class=""overview-item overview-item--c1"">
                    <div class=""overview__inner"">
                        <div class=""overview-box clearfix"">
                            <div class=""icon"">
                                <i class=""zmdi zmdi-account-o""></i>
                            </div>
                            <div class=""text"">
                                <h2>");
#nullable restore
#line 29 "D:\projectWeb\Web_MobileShop\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml"
                               Write(totalUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                <span>members</span>
                            </div>
                        </div>
                        <div class=""overview-chart"">
                            <canvas id=""widgetChart1""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""overview-item overview-item--c2"">
                    <div class=""overview__inner"">
                        <div class=""overview-box clearfix"">
                            <div class=""icon"">
                                <i class=""zmdi zmdi-shopping-cart""></i>
                            </div>
                            <div class=""text"">
                                <h2>");
#nullable restore
#line 47 "D:\projectWeb\Web_MobileShop\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml"
                               Write(totalProdct);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                <span>items solid</span>
                            </div>
                        </div>
                        <div class=""overview-chart"">
                            <canvas id=""widgetChart2""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""overview-item overview-item--c3"">
                    <div class=""overview__inner"">
                        <div class=""overview-box clearfix"">
                            <div class=""icon"">
                                <i class=""zmdi zmdi-calendar-note""></i>
                            </div>
                            <div class=""text"">
                                <h2>1,086</h2>
                                <span>this week</span>
                            </div>
                        </div>
                        <div class=""overview-chart"">
                 ");
            WriteLiteral(@"           <canvas id=""widgetChart3""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""overview-item overview-item--c4"">
                    <div class=""overview__inner"">
                        <div class=""overview-box clearfix"">
                            <div class=""icon"">
                                <i class=""zmdi zmdi-money""></i>
                            </div>
                            <div class=""text"">
                                <h2>$1,060,386</h2>
                                <span>total earnings</span>
                            </div>
                        </div>
                        <div class=""overview-chart"">
                            <canvas id=""widgetChart4""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
       ");
            WriteLiteral(@"     <div class=""col-lg-6"">
                <div class=""au-card recent-report"">
                    <div class=""au-card-inner"">
                        <h3 class=""title-2"">recent reports</h3>
                        <div class=""chart-info"">
                            <div class=""chart-info__left"">
                                <div class=""chart-note"">
                                    <span class=""dot dot--blue""></span>
                                    <span>products</span>
                                </div>
                                <div class=""chart-note mr-0"">
                                    <span class=""dot dot--green""></span>
                                    <span>services</span>
                                </div>
                            </div>
                            <div class=""chart-info__right"">
                                <div class=""chart-statis"">
                                    <span class=""index incre"">
                               ");
            WriteLiteral(@"         <i class=""zmdi zmdi-long-arrow-up""></i>25%
                                    </span>
                                    <span class=""label"">products</span>
                                </div>
                                <div class=""chart-statis mr-0"">
                                    <span class=""index decre"">
                                        <i class=""zmdi zmdi-long-arrow-down""></i>10%
                                    </span>
                                    <span class=""label"">services</span>
                                </div>
                            </div>
                        </div>
                        <div class=""recent-report__chart"">
                            <canvas id=""recent-rep-chart""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""au-card chart-percent-card"">
                    <div class=""au-card-inner");
            WriteLiteral(@""">
                        <h3 class=""title-2 tm-b-5"">char by %</h3>
                        <div class=""row no-gutters"">
                            <div class=""col-xl-6"">
                                <div class=""chart-note-wrap"">
                                    <div class=""chart-note mr-0 d-block"">
                                        <span class=""dot dot--blue""></span>
                                        <span>products</span>
                                    </div>
                                    <div class=""chart-note mr-0 d-block"">
                                        <span class=""dot dot--red""></span>
                                        <span>services</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-xl-6"">
                                <div class=""percent-chart"">
                                    <canvas id=""percent-chart""></canvas>
    ");
            WriteLiteral(@"                            </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <h2 class=""title-1 m-b-25"">Earnings By Items</h2>
                <div class=""table-responsive table--no-card m-b-40"">
                    <table class=""table table-borderless table-striped table-earning"">
                        <thead>
                            <tr>
                                <th>date</th>
                                <th>order ID</th>
                                <th>name</th>
                                <th class=""text-right"">price</th>
                                <th class=""text-right"">quantity</th>
                                <th class=""text-right"">total</th>
                            </tr>
                        </thead>
                        <tbody> 
                        ");
            WriteLiteral(@"    <tr>
                                <td>2018-09-29 05:57</td>
                                <td>100398</td>
                                <td>iPhone X 64Gb Grey</td>
                                <td class=""text-right"">$999.00</td>
                                <td class=""text-right"">1</td>
                                <td class=""text-right"">$999.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-28 01:22</td>
                                <td>100397</td>
                                <td>Samsung S8 Black</td>
                                <td class=""text-right"">$756.00</td>
                                <td class=""text-right"">1</td>
                                <td class=""text-right"">$756.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-27 02:12</td>
                                <td>100396</td>
                              ");
            WriteLiteral(@"  <td>Game Console Controller</td>
                                <td class=""text-right"">$22.00</td>
                                <td class=""text-right"">2</td>
                                <td class=""text-right"">$44.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-26 23:06</td>
                                <td>100395</td>
                                <td>iPhone X 256Gb Black</td>
                                <td class=""text-right"">$1199.00</td>
                                <td class=""text-right"">1</td>
                                <td class=""text-right"">$1199.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-25 19:03</td>
                                <td>100393</td>
                                <td>USB 3.0 Cable</td>
                                <td class=""text-right"">$10.00</td>
                                <td class=""te");
            WriteLiteral(@"xt-right"">3</td>
                                <td class=""text-right"">$30.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-29 05:57</td>
                                <td>100392</td>
                                <td>Smartwatch 4.0 LTE Wifi</td>
                                <td class=""text-right"">$199.00</td>
                                <td class=""text-right"">6</td>
                                <td class=""text-right"">$1494.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-24 19:10</td>
                                <td>100391</td>
                                <td>Camera C430W 4k</td>
                                <td class=""text-right"">$699.00</td>
                                <td class=""text-right"">1</td>
                                <td class=""text-right"">$699.00</td>
                            </tr>
                      ");
            WriteLiteral(@"      <tr>
                                <td>2018-09-22 00:43</td>
                                <td>100393</td>
                                <td>USB 3.0 Cable</td>
                                <td class=""text-right"">$10.00</td>
                                <td class=""text-right"">3</td>
                                <td class=""text-right"">$30.00</td>
                            </tr>
                        </tbody>
                    </table>
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
=======
#pragma checksum "C:\Users\Asus\Source\Repos\thanhhautran\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d760c3b2540c2680accd4a0fe8c5986335539fba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d760c3b2540c2680accd4a0fe8c5986335539fba", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asus\Source\Repos\thanhhautran\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_MasterLayout.cshtml";

    var totalUser = ViewBag.TotalUser;
    var totalProdct = ViewBag.totalProduct;
    var totalProductThisMonth = ViewBag.totalProductThisMonth;
    var totalEarningThisMonth = ViewBag.totalEarningThisMonth;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""section__content section__content--p30"">
    <div class=""container-fluid"">
        <div class=""rowEarnings By Items
            <div class=""col-md-12"">
                <div class=""overview-wrap"">
                    <h2 class=""title-1"">overview</h2>
                    <button class=""au-btn au-btn-icon au-btn--blue"">
                        <i class=""zmdi zmdi-plus""></i>add item
                    </button>
                </div>
            </div>
        </div>
        <div class=""row m-t-25"">
            <div class=""col-sm-6 col-lg-3"">
                <div class=""overview-item overview-item--c1"">
                    <div class=""overview__inner"">
                        <div class=""overview-box clearfix"">
                            <div class=""icon"">
                                <i class=""zmdi zmdi-account-o""></i>
                            </div>
                            <div class=""text"">
                                <h2>");
#nullable restore
#line 31 "C:\Users\Asus\Source\Repos\thanhhautran\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml"
                               Write(totalUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                <span>members</span>
                            </div>
                        </div>
                        <div class=""overview-chart"">
                            <canvas id=""widgetChart1""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""overview-item overview-item--c2"">
                    <div class=""overview__inner"">
                        <div class=""overview-box clearfix"">
                            <div class=""icon"">
                                <i class=""zmdi zmdi-shopping-cart""></i>
                            </div>
                            <div class=""text"">
                                <h2>");
#nullable restore
#line 49 "C:\Users\Asus\Source\Repos\thanhhautran\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml"
                               Write(totalProdct);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                <span>items solid</span>
                            </div>
                        </div>
                        <div class=""overview-chart"">
                            <canvas id=""widgetChart2""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""overview-item overview-item--c3"">
                    <div class=""overview__inner"">
                        <div class=""overview-box clearfix"">
                            <div class=""icon"">
                                <i class=""zmdi zmdi-calendar-note""></i>
                            </div>
                            <div class=""text"">
                                <h2>");
#nullable restore
#line 67 "C:\Users\Asus\Source\Repos\thanhhautran\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml"
                               Write(totalProductThisMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                <span>sold this month</span>
                            </div>
                        </div>
                        <div class=""overview-chart"">
                            <canvas id=""widgetChart3""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""overview-item overview-item--c4"">
                    <div class=""overview__inner"">
                        <div class=""overview-box clearfix"">
                            <div class=""icon"">
                                <i class=""zmdi zmdi-money""></i>
                            </div>
                            <div class=""text"">
                                <h2>$");
#nullable restore
#line 85 "C:\Users\Asus\Source\Repos\thanhhautran\.NetProject\WebShop\Areas\Admin\Views\Home\Index.cshtml"
                                Write(totalEarningThisMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                <span>total earnings</span>
                            </div>
                        </div>
                        <div class=""overview-chart"">
                            <canvas id=""widgetChart4""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""au-card recent-report"">
                    <div class=""au-card-inner"">
                        <h3 class=""title-2"">recent reports</h3>
                        <div class=""chart-info"">
                            <div class=""chart-info__left"">
                                <div class=""chart-note"">
                                    <span class=""dot dot--blue""></span>
                                    <span>products</span>
                                </div>
                                <div class=""chart-note mr-0"">
                ");
            WriteLiteral(@"                    <span class=""dot dot--green""></span>
                                    <span>services</span>
                                </div>
                            </div>
                            <div class=""chart-info__right"">
                                <div class=""chart-statis"">
                                    <span class=""index incre"">
                                        <i class=""zmdi zmdi-long-arrow-up""></i>25%
                                    </span>
                                    <span class=""label"">products</span>
                                </div>
                                <div class=""chart-statis mr-0"">
                                    <span class=""index decre"">
                                        <i class=""zmdi zmdi-long-arrow-down""></i>10%
                                    </span>
                                    <span class=""label"">services</span>
                                </div>
                            </d");
            WriteLiteral(@"iv>
                        </div>
                        <div class=""recent-report__chart"">
                            <canvas id=""recent-rep-chart""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""au-card chart-percent-card"">
                    <div class=""au-card-inner"">
                        <h3 class=""title-2 tm-b-5"">char by %</h3>
                        <div class=""row no-gutters"">
                            <div class=""col-xl-6"">
                                <div class=""chart-note-wrap"">
                                    <div class=""chart-note mr-0 d-block"">
                                        <span class=""dot dot--blue""></span>
                                        <span>products</span>
                                    </div>
                                    <div class=""chart-note mr-0 d-block"">
                                        <");
            WriteLiteral(@"span class=""dot dot--red""></span>
                                        <span>services</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-xl-6"">
                                <div class=""percent-chart"">
                                    <canvas id=""percent-chart""></canvas>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <h2 class=""title-1 m-b-25"">Earnings By Items</h2>
                <div class=""table-responsive table--no-card m-b-40"">
                    <table class=""table table-borderless table-striped table-earning"">
                        <thead>
                            <tr>
                                <th>date</th>
                    ");
            WriteLiteral(@"            <th>order ID</th>
                                <th>name</th>
                                <th class=""text-right"">price</th>
                                <th class=""text-right"">quantity</th>
                                <th class=""text-right"">total</th>
                            </tr>
                        </thead>
                        <tbody> 
                            <tr>
                                <td>2018-09-29 05:57</td>
                                <td>100398</td>
                                <td>iPhone X 64Gb Grey</td>
                                <td class=""text-right"">$999.00</td>
                                <td class=""text-right"">1</td>
                                <td class=""text-right"">$999.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-28 01:22</td>
                                <td>100397</td>
                                <td>Samsung S8 Black</td>");
            WriteLiteral(@"
                                <td class=""text-right"">$756.00</td>
                                <td class=""text-right"">1</td>
                                <td class=""text-right"">$756.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-27 02:12</td>
                                <td>100396</td>
                                <td>Game Console Controller</td>
                                <td class=""text-right"">$22.00</td>
                                <td class=""text-right"">2</td>
                                <td class=""text-right"">$44.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-26 23:06</td>
                                <td>100395</td>
                                <td>iPhone X 256Gb Black</td>
                                <td class=""text-right"">$1199.00</td>
                                <td class=""text-right"">1</td>
       ");
            WriteLiteral(@"                         <td class=""text-right"">$1199.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-25 19:03</td>
                                <td>100393</td>
                                <td>USB 3.0 Cable</td>
                                <td class=""text-right"">$10.00</td>
                                <td class=""text-right"">3</td>
                                <td class=""text-right"">$30.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-29 05:57</td>
                                <td>100392</td>
                                <td>Smartwatch 4.0 LTE Wifi</td>
                                <td class=""text-right"">$199.00</td>
                                <td class=""text-right"">6</td>
                                <td class=""text-right"">$1494.00</td>
                            </tr>
                            <tr>
               ");
            WriteLiteral(@"                 <td>2018-09-24 19:10</td>
                                <td>100391</td>
                                <td>Camera C430W 4k</td>
                                <td class=""text-right"">$699.00</td>
                                <td class=""text-right"">1</td>
                                <td class=""text-right"">$699.00</td>
                            </tr>
                            <tr>
                                <td>2018-09-22 00:43</td>
                                <td>100393</td>
                                <td>USB 3.0 Cable</td>
                                <td class=""text-right"">$10.00</td>
                                <td class=""text-right"">3</td>
                                <td class=""text-right"">$30.00</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
           
        </div>
        
        <div class=""row"">
            <div class=""col-md-");
            WriteLiteral(@"12"">
                <div class=""copyright"">
                    <p>Copyright © 2020 Creepy. All rights reserved. Template by <a href=""https://colorlib.com"">Colorlib</a>.</p>
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
>>>>>>> 1f5f9c5aa49e556b65956bd080a5b6d9943d868a
