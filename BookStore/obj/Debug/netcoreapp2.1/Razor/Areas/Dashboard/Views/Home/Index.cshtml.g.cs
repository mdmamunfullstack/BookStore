#pragma checksum "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Areas\Dashboard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fef2ab9c96b39a383ea95d1f0c33089f48ba8e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Dashboard/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Dashboard_Views_Home_Index))]
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
#line 1 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Areas\Dashboard\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#line 2 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Areas\Dashboard\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#line 3 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Areas\Dashboard\Views\_ViewImports.cshtml"
using BookStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fef2ab9c96b39a383ea95d1f0c33089f48ba8e0", @"/Areas/Dashboard/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebfb66dd7688adb2b874a32236680b170c920090", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1856, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6 col-lg-3"">
        <div class=""widget-small primary coloured-icon"">
            <i class=""icon fa fa-users fa-3x""></i>
            <div class=""info"">
                <h4>Users</h4>
                <p><b>5</b></p>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""widget-small info coloured-icon"">
            <i class=""icon fa fa-thumbs-o-up fa-3x""></i>
            <div class=""info"">
                <h4>Likes</h4>
                <p><b>25</b></p>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""widget-small warning coloured-icon"">
            <i class=""icon fa fa-files-o fa-3x""></i>
            <div class=""info"">
                <h4>Uploades</h4>
                <p><b>10</b></p>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""widget-small danger coloured-icon"">
            <i class=""ico");
            WriteLiteral(@"n fa fa-star fa-3x""></i>
            <div class=""info"">
                <h4>Stars</h4>
                <p><b>500</b></p>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-6"">
        <div class=""tile"">
            <h3 class=""tile-title"">Monthly Sales</h3>
            <div class=""embed-responsive embed-responsive-16by9"">
                <canvas class=""embed-responsive-item"" id=""lineChartDemo""></canvas>
            </div>
        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""tile"">
            <h3 class=""tile-title"">Support Requests</h3>
            <div class=""embed-responsive embed-responsive-16by9"">
                <canvas class=""embed-responsive-item"" id=""pieChartDemo""></canvas>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1873, 2006, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
      var data = {
      	labels: [""January"", ""February"", ""March"", ""April"", ""May""],
      	datasets: [
      		{
      			label: ""My First dataset"",
      			fillColor: ""rgba(220,220,220,0.2)"",
      			strokeColor: ""rgba(220,220,220,1)"",
      			pointColor: ""rgba(220,220,220,1)"",
      			pointStrokeColor: ""#fff"",
      			pointHighlightFill: ""#fff"",
      			pointHighlightStroke: ""rgba(220,220,220,1)"",
      			data: [65, 59, 80, 81, 56]
      		},
      		{
      			label: ""My Second dataset"",
      			fillColor: ""rgba(151,187,205,0.2)"",
      			strokeColor: ""rgba(151,187,205,1)"",
      			pointColor: ""rgba(151,187,205,1)"",
      			pointStrokeColor: ""#fff"",
      			pointHighlightFill: ""#fff"",
      			pointHighlightStroke: ""rgba(151,187,205,1)"",
      			data: [28, 48, 40, 19, 86]
      		}
      	]
      };
      var pdata = [
      	{
      		value: 300,
      		color: ""#46BFBD"",
      		highlight: ""#5AD3D1"",
      		label: ""Complet");
                WriteLiteral(@"e""
      	},
      	{
      		value: 50,
      		color:""#F7464A"",
      		highlight: ""#FF5A5E"",
      		label: ""In-Progress""
      	}
      ]

      var ctxl = $(""#lineChartDemo"").get(0).getContext(""2d"");
      var lineChart = new Chart(ctxl).Line(data);

      var ctxp = $(""#pieChartDemo"").get(0).getContext(""2d"");
      var pieChart = new Chart(ctxp).Pie(pdata);
    </script>
    <!-- Google analytics script-->
    <script type=""text/javascript"">
      if(document.location.hostname == 'pratikborsadiya.in') {
      	(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
      	(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
      	m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
      	})(window,document,'script','//www.google-analytics.com/analytics.js','ga');
      	ga('create', 'UA-72504830-1', 'auto');
      	ga('send', 'pageview');
      }
    </script>
");
                EndContext();
            }
            );
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
