#pragma checksum "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "005b0f4addc7282ef3f393e6f449257bf1bab12e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"005b0f4addc7282ef3f393e6f449257bf1bab12e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89719371a496d6f34a83ac7118974af2d623733", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vm>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
   <!-- Page Content-->
        <div class=""container-fluid p-0"">
            <!-- About-->
            <section class=""resume-section"" id=""about"">
                <div class=""resume-section-content"">
                    <h1 class=""mb-0"">
                        Clarence
                        <span class=""text-primary"">");
#nullable restore
#line 14 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                              Write(Model.users.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </h1>\r\n                    <div class=\"subheading mb-5\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                   Write(Model.users.FirstOrDefault().Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <a href=\"mailto:name@email.com\">name@email.com</a>\r\n                    </div>\r\n                    <p class=\"lead mb-5\">");
#nullable restore
#line 20 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                    Write(Model.users.FirstOrDefault().Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"social-icons\">\r\n");
#nullable restore
#line 22 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                         foreach (var item in Model.socialMedia)
                       {
                           
                       

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"social-icon\"");
            BeginWriteAttribute("href", " href=\"", 998, "\"", 1015, 1);
#nullable restore
#line 26 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
WriteAttributeValue("", 1005, item.Link, 1005, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1019, "\"", 1037, 1);
#nullable restore
#line 26 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
WriteAttributeValue("", 1027, item.Icon, 1027, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 27 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </section>
            <hr class=""m-0"" />
            <!-- Experience-->
            <section class=""resume-section"" id=""experience"">
                <div class=""resume-section-content"">
                    <h2 class=""mb-5"">Experience</h2>
");
#nullable restore
#line 36 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                     foreach (var item in Model.experiences)
                   {
                       
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"d-flex flex-column flex-md-row justify-content-between mb-5\">\r\n                        <div class=\"flex-grow-1\">\r\n                            <h3 class=\"mb-0\">");
#nullable restore
#line 42 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"subheading mb-3\">");
#nullable restore
#line 43 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                                    Write(item.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                            <p>");
#nullable restore
#line 44 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"flex-shrink-0\"><span class=\"text-primary\">March 2013 - Present</span></div>\r\n                    </div>\r\n");
#nullable restore
#line 48 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                   
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                </div>
            </section>
            <hr class=""m-0"" />
            <!-- Education-->
            <section class=""resume-section"" id=""education"">
                <div class=""resume-section-content"">
                    <h2 class=""mb-5"">Education</h2>
");
#nullable restore
#line 58 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                     foreach (var item in Model.educations)
                    {
                        
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"d-flex flex-column flex-md-row justify-content-between mb-5\">\r\n                        <div class=\"flex-grow-1\">\r\n                            <h3 class=\"mb-0\">");
#nullable restore
#line 64 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"subheading mb-3\">");
#nullable restore
#line 65 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                                    Write(item.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>");
#nullable restore
#line 66 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <p>GPA: 3.23</p>\r\n                        </div>\r\n                        <div class=\"flex-shrink-0\"><span class=\"text-primary\">August 2006 - May 2010</span></div>\r\n                    </div>\r\n");
#nullable restore
#line 71 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
                </div>
            </section>
            <hr class=""m-0"" />
            <!-- Skills-->
            <section class=""resume-section"" id=""skills"">
                <div class=""resume-section-content"">
                    <h2 class=""mb-5"">Skills</h2>
                    <div class=""subheading mb-3"">Programming Languages & Tools</div>
                    <ul class=""list-inline dev-icons"">
");
#nullable restore
#line 82 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                         foreach (var item in Model.icons)
                {
                    
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-inline-item\"><i");
            BeginWriteAttribute("class", " class=\"", 3695, "\"", 3713, 1);
#nullable restore
#line 86 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
WriteAttributeValue("", 3703, item.Icoo, 3703, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></li>");
#nullable restore
#line 86 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                    <div class=""subheading mb-3"">Workflow</div>
                    <ul class=""fa-ul mb-0"">
                        <li>
                            <span class=""fa-li""><i class=""fas fa-check""></i></span>
                            Mobile-First, Responsive Design
                        </li>
                        <li>
                            <span class=""fa-li""><i class=""fas fa-check""></i></span>
                            Cross Browser Testing & Debugging
                        </li>
                        <li>
                            <span class=""fa-li""><i class=""fas fa-check""></i></span>
                            Cross Functional Teams
                        </li>
                        <li>
                            <span class=""fa-li""><i class=""fas fa-check""></i></span>
                            Agile Development & Scrum
                        </li>
                    </ul>
                </div>
            </section");
            WriteLiteral(">\r\n            <hr class=\"m-0\" />\r\n            <!-- Interests-->\r\n            <section class=\"resume-section\" id=\"interests\">\r\n                <div class=\"resume-section-content\">\r\n                    <h2 class=\"mb-5\">Interests</h2>\r\n");
#nullable restore
#line 125 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                     foreach (var item in Model.awards)
                   {
                       
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p> ");
#nullable restore
#line 129 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                   Write(item.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 130 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                  Write(item.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 131 "C:\Users\Acer\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </section>
            <hr class=""m-0"" />
            <!-- Awards-->
            <section class=""resume-section"" id=""awards"">
                <div class=""resume-section-content"">
                    <h2 class=""mb-5"">Awards & Certifications</h2>
                    <ul class=""fa-ul mb-0"">
                        <li>
                            <span class=""fa-li""><i class=""fas fa-trophy text-warning""></i></span>
                            Google Analytics Certified Developer
                        </li>
                        <li>
                            <span class=""fa-li""><i class=""fas fa-trophy text-warning""></i></span>
                            Mobile Web Specialist - Google Certification
                        </li>
                        <li>
                            <span class=""fa-li""><i class=""fas fa-trophy text-warning""></i></span>
                            1
                            <sup>st</sup>
                            P");
            WriteLiteral(@"lace - University of Colorado Boulder - Emerging Tech Competition 2009
                        </li>
                        <li>
                            <span class=""fa-li""><i class=""fas fa-trophy text-warning""></i></span>
                            1
                            <sup>st</sup>
                            Place - University of Colorado Boulder - Adobe Creative Jam 2008 (UI Design Category)
                        </li>
                        <li>
                            <span class=""fa-li""><i class=""fas fa-trophy text-warning""></i></span>
                            2
                            <sup>nd</sup>
                            Place - University of Colorado Boulder - Emerging Tech Competition 2008
                        </li>
                        <li>
                            <span class=""fa-li""><i class=""fas fa-trophy text-warning""></i></span>
                            1
                            <sup>st</sup>
                            Place ");
            WriteLiteral(@"- James Buchanan High School - Hackathon 2006
                        </li>
                        <li>
                            <span class=""fa-li""><i class=""fas fa-trophy text-warning""></i></span>
                            3
                            <sup>rd</sup>
                            Place - James Buchanan High School - Hackathon 2005
                        </li>
                    </ul>
                </div>
            </section>
        </div>
        <!-- Bootstrap core JS-->

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vm> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
