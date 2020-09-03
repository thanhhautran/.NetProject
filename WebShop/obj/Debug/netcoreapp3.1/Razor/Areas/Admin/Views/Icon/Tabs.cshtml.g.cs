#pragma checksum "D:\Temp\NetProject-master (1)\.NetProject-master\WebShop\Areas\Admin\Views\Icon\Tabs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02bbfc84d14faf3e2552eae7396e5110adf3ce60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Icon_Tabs), @"mvc.1.0.view", @"/Areas/Admin/Views/Icon/Tabs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02bbfc84d14faf3e2552eae7396e5110adf3ce60", @"/Areas/Admin/Views/Icon/Tabs.cshtml")]
    public class Areas_Admin_Views_Icon_Tabs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\Temp\NetProject-master (1)\.NetProject-master\WebShop\Areas\Admin\Views\Icon\Tabs.cshtml"
  
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
                            <h4>Menus</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""text-muted m-b-15"">
                                In HTML, a menu is often defined in an unordered list
                                <code>&lt;ul&gt;</code> (and styled afterwards), like this:
                            </p>

                            <ul class=""list-unstyled"">
                                <li>
                                    <a href=""#"">Home</a>
                                </li>
                                <li>
                                    <a href=""#"">Menu 1</a>
                                </li>
                              ");
            WriteLiteral(@"  <li>
                                    <a href=""#"">Menu 2</a>
                                </li>
                                <li>
                                    <a href=""#"">Menu 3</a>
                                </li>
                            </ul>

                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Inline List</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""text-muted m-b-15"">
                                In HTML, a menu is often defined in an unordered list
                                <code>&lt;ul&gt;</code> (and styled afterwards), like this:
                            </p>

                            <ul class=""list-inline"">
                                <li class=""list-inline-item"">
                             ");
            WriteLiteral(@"       <a href=""#"">Home</a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a href=""#"">Menu 1</a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a href=""#"">Menu 2</a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a href=""#"">Menu 3</a>
                                </li>
                            </ul>

                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Tabs With Dropdown Menu</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""text-muted");
            WriteLiteral(@" m-b-15"">The following example adds a dropdown menu to ""Menu 1"":</p>

                            <ul class=""nav nav-tabs"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" href=""#"">Home</a>
                                </li>
                                <li class=""nav-item dropdown"">
                                    <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                        Menu 1
                                        <span class=""caret""></span>
                                    </a>
                                    <div class=""dropdown-menu"">
                                        <a class=""dropdown-item"" href=""#"">Submenu 1-1</a>
                                        <a class=""dropdown-item"" href=""#"">Submenu 1-2</a>
                                        <a class=""dropdown-item"" href=""#"">Submenu 1-3</a>
            ");
            WriteLiteral(@"                        </div>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#"">Menu 2</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#"">Menu 3</a>
                                </li>
                            </ul>

                        </div>
                    </div>
                </div>
                <!-- /# column -->
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Pills</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""text-muted m-b-15"">
                                Pills are created with
                                <code>&lt;ul class=""nav nav-pills""&gt;</code>. Also mark the current page");
            WriteLiteral(@" with
                                <code>&lt;li class=""active""&gt;</code>:
                            </p>

                            <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" id=""pills-home-tab"" data-toggle=""pill"" href=""#pills-home"" role=""tab"" aria-controls=""pills-home""
                                       aria-selected=""true"">Home</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" id=""pills-profile-tab"" data-toggle=""pill"" href=""#pills-profile"" role=""tab"" aria-controls=""pills-profile""
                                       aria-selected=""false"">Profile</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" id=""pills-contact-tab"" data-toggle=""pill"" href=""#pills-contact"" ro");
            WriteLiteral(@"le=""tab"" aria-controls=""pills-contact""
                                       aria-selected=""false"">Contact</a>
                                </li>
                            </ul>

                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Vertical Pills</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""text-muted m-b-15"">
                                Pills can also be displayed vertically. Just add the
                                <code>.nav-stacked</code> class:
                            </p>

                            <div class=""nav flex-column nav-pills"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
                                <a class=""nav-link active"" id=""v-pills-home-tab""");
            WriteLiteral(@" data-toggle=""pill"" href=""#v-pills-home"" role=""tab"" aria-controls=""v-pills-home""
                                   aria-selected=""true"">Home</a>
                                <a class=""nav-link"" id=""v-pills-profile-tab"" data-toggle=""pill"" href=""#v-pills-profile"" role=""tab"" aria-controls=""v-pills-profile""
                                   aria-selected=""false"">Menu 1</a>
                                <a class=""nav-link"" id=""v-pills-messages-tab"" data-toggle=""pill"" href=""#v-pills-messages"" role=""tab"" aria-controls=""v-pills-messages""
                                   aria-selected=""false"">Menu 2</a>
                                <a class=""nav-link"" id=""v-pills-settings-tab"" data-toggle=""pill"" href=""#v-pills-settings"" role=""tab"" aria-controls=""v-pills-settings""
                                   aria-selected=""false"">Menu 3</a>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /# column -->
                <div class=""");
            WriteLiteral(@"col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Pills With Dropdown Menu</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""text-muted m-b-15"">The following example adds a dropdown menu to ""Menu 1"":</p>

                            <ul class=""nav nav-pills"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" href=""#"">Home</a>
                                </li>
                                <li class=""nav-item dropdown"">
                                    <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Menu 1</a>
                                    <div class=""dropdown-menu"">
                                        <a class=""dropdown-item"" href=""#"">Submenu 1-1</a>
                                        <a class");
            WriteLiteral(@"=""dropdown-item"" href=""#"">Submenu 1-2</a>
                                        <a class=""dropdown-item"" href=""#"">Submenu 1-3</a>
                                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                                        <div class=""dropdown-divider""></div>
                                        <a class=""dropdown-item"" href=""#"">Separated link</a>
                                    </div>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#"">Menu 2</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#"">Menu 3</a>
                                </li>
                            </ul>

                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
   ");
            WriteLiteral(@"                 <div class=""card"">
                        <div class=""card-header"">
                            <h4>Centered Tabs and Pills</h4>
                        </div>
                        <div class=""card-body"">
                            <p class=""text-muted m-b-15"">
                                To center/justify the tabs and pills, use the
                                <code>.nav-justified</code> class.
                            </p>

                            <!-- Centered Tabs -->
                            <ul class=""nav nav-tabs nav-justified"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" href=""#"">Home</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#"">Menu 1</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""n");
            WriteLiteral(@"av-link"" href=""#"">Menu 2</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#"">Menu 3</a>
                                </li>
                            </ul>

                            <ul class=""nav nav-pills nav-justified mb-3 mt-2"" id=""pills-tab"" role=""tablist"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" id=""pills-home-tab"" data-toggle=""pill"" href=""#pills-home"" role=""tab"" aria-controls=""pills-home""
                                       aria-selected=""true"">Home</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" id=""pills-profile-tab"" data-toggle=""pill"" href=""#pills-profile"" role=""tab"" aria-controls=""pills-profile""
                                       aria-selected=""false"">Menu 1</a>
                                </li>
");
            WriteLiteral(@"                                <li class=""nav-item"">
                                    <a class=""nav-link"" id=""pills-profile-tab"" data-toggle=""pill"" href=""#pills-profile"" role=""tab"" aria-controls=""pills-profile""
                                       aria-selected=""false"">Menu 2</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" id=""pills-contact-tab"" data-toggle=""pill"" href=""#pills-contact"" role=""tab"" aria-controls=""pills-contact""
                                       aria-selected=""false"">Menu 3</a>
                                </li>
                            </ul>


                        </div>
                    </div>
                </div>
                <!-- /# column -->
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Toggleable / Dynamic Tabs</h4>
                        </div>
");
            WriteLiteral(@"                        <div class=""card-body"">
                            <p class=""text-muted m-b-15"">
                                To make the tabs toggleable, add the
                                <code>data-toggle=""tab""</code> attribute to each link. Then add a
                                <code>.tab-pane</code> class with a unique ID for every tab and wrap them inside a
                                <code>&lt;div&gt;</code> element with class
                                <code>.tab-content</code>. If you want the tabs to fade in and out when clicking on them, add the
                                <code>.fade</code> class to
                                <code>.tab-pane</code>:
                            </p>

                            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-s");
            WriteLiteral(@"elected=""true"">Home</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Menu 1</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" id=""contact-tab"" data-toggle=""tab"" href=""#contact"" role=""tab"" aria-controls=""contact"" aria-selected=""false"">Menu 2</a>
                                </li>
                            </ul>
                            <div class=""tab-content pl-3 p-1"" id=""myTabContent"">
                                <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                                    <h3>Home</h3>
                                    <p>Some content here.</p>
                                </div>
                                <div ");
            WriteLiteral(@"class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                                    <h3>Menu 1</h3>
                                    <p>Some content here.</p>
                                </div>
                                <div class=""tab-pane fade"" id=""contact"" role=""tabpanel"" aria-labelledby=""contact-tab"">
                                    <h3>Menu 2</h3>
                                    <p>Some content here.</p>
                                </div>
                            </div>


                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Default Tab</h4>
                        </div>
                        <div class=""card-body"">
                            <div class=""default-tab"">
                                <nav>
  ");
            WriteLiteral(@"                                  <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                                        <a class=""nav-item nav-link active"" id=""nav-home-tab"" data-toggle=""tab"" href=""#nav-home"" role=""tab"" aria-controls=""nav-home""
                                           aria-selected=""true"">Home</a>
                                        <a class=""nav-item nav-link"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#nav-profile"" role=""tab"" aria-controls=""nav-profile""
                                           aria-selected=""false"">Profile</a>
                                        <a class=""nav-item nav-link"" id=""nav-contact-tab"" data-toggle=""tab"" href=""#nav-contact"" role=""tab"" aria-controls=""nav-contact""
                                           aria-selected=""false"">Contact</a>
                                    </div>
                                </nav>
                                <div class=""tab-content pl-3 pt-2"" id=""nav-tabContent"">
                                    <di");
            WriteLiteral(@"v class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
                                        <p>
                                            Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth
                                            master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh
                                            dreamcatcher synth. Cosby sweater eu banh mi, irure terry richardson ex sd. Alip placeat salvia cillum iphone.
                                            Seitan alip s cardigan american apparel, butcher voluptate nisi .
                                        </p>
                                    </div>
                                    <div class=""tab-pane fade"" id=""nav-profile"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">
                                        <p>
                                           ");
            WriteLiteral(@" Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth
                                            master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh
                                            dreamcatcher synth. Cosby sweater eu banh mi, irure terry richardson ex sd. Alip placeat salvia cillum iphone.
                                            Seitan alip s cardigan american apparel, butcher voluptate nisi .
                                        </p>
                                    </div>
                                    <div class=""tab-pane fade"" id=""nav-contact"" role=""tabpanel"" aria-labelledby=""nav-contact-tab"">
                                        <p>
                                            Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth
                                            master cleanse. Mustache cliche");
            WriteLiteral(@" tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh
                                            dreamcatcher synth. Cosby sweater eu banh mi, irure terry richardson ex sd. Alip placeat salvia cillum iphone.
                                            Seitan alip s cardigan american apparel, butcher voluptate nisi .
                                        </p>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
                <!-- /# column -->
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Custom Tab</h4>
                        </div>
                        <div class=""card-body"">
                            <div class=""custom-tab"">

                                <nav>
                                    <div class=""na");
            WriteLiteral(@"v nav-tabs"" id=""nav-tab"" role=""tablist"">
                                        <a class=""nav-item nav-link active"" id=""custom-nav-home-tab"" data-toggle=""tab"" href=""#custom-nav-home"" role=""tab"" aria-controls=""custom-nav-home""
                                           aria-selected=""true"">Home</a>
                                        <a class=""nav-item nav-link"" id=""custom-nav-profile-tab"" data-toggle=""tab"" href=""#custom-nav-profile"" role=""tab"" aria-controls=""custom-nav-profile""
                                           aria-selected=""false"">Profile</a>
                                        <a class=""nav-item nav-link"" id=""custom-nav-contact-tab"" data-toggle=""tab"" href=""#custom-nav-contact"" role=""tab"" aria-controls=""custom-nav-contact""
                                           aria-selected=""false"">Contact</a>
                                    </div>
                                </nav>
                                <div class=""tab-content pl-3 pt-2"" id=""nav-tabContent"">
                        ");
            WriteLiteral(@"            <div class=""tab-pane fade show active"" id=""custom-nav-home"" role=""tabpanel"" aria-labelledby=""custom-nav-home-tab"">
                                        <p>
                                            Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth
                                            master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh
                                            dreamcatcher synth. Cosby sweater eu banh mi, irure terry richardson ex sd. Alip placeat salvia cillum iphone.
                                            Seitan alip s cardigan american apparel, butcher voluptate nisi .
                                        </p>
                                    </div>
                                    <div class=""tab-pane fade"" id=""custom-nav-profile"" role=""tabpanel"" aria-labelledby=""custom-nav-profile-tab"">
                                        <p>
");
            WriteLiteral(@"                                            Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth
                                            master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh
                                            dreamcatcher synth. Cosby sweater eu banh mi, irure terry richardson ex sd. Alip placeat salvia cillum iphone.
                                            Seitan alip s cardigan american apparel, butcher voluptate nisi .
                                        </p>
                                    </div>
                                    <div class=""tab-pane fade"" id=""custom-nav-contact"" role=""tabpanel"" aria-labelledby=""custom-nav-contact-tab"">
                                        <p>
                                            Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth
                  ");
            WriteLiteral(@"                          master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh
                                            dreamcatcher synth. Cosby sweater eu banh mi, irure terry richardson ex sd. Alip placeat salvia cillum iphone.
                                            Seitan alip s cardigan american apparel, butcher voluptate nisi .
                                        </p>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
                <!-- /# column -->
            </div>
        </div>
    </div>
</div>
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
