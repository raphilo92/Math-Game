#pragma checksum "C:\Users\evanc\OneDrive\Documents\Github\Math-Game\Project File\RazorPagesMathGame\Pages\Subtraction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ec0b4cf8df0f921861b0ba7c1634190bdee4a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMathGame.Pages.Pages_Subtraction), @"mvc.1.0.razor-page", @"/Pages/Subtraction.cshtml")]
namespace RazorPagesMathGame.Pages
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
#line 1 "C:\Users\evanc\OneDrive\Documents\Github\Math-Game\Project File\RazorPagesMathGame\Pages\_ViewImports.cshtml"
using RazorPagesMathGame;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97ec0b4cf8df0f921861b0ba7c1634190bdee4a1", @"/Pages/Subtraction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2138c5e61216596cffdd68b32dcfab68e1d4d365", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Subtraction : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\evanc\OneDrive\Documents\Github\Math-Game\Project File\RazorPagesMathGame\Pages\Subtraction.cshtml"
Write(Model.MyProperty2);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97ec0b4cf8df0f921861b0ba7c1634190bdee4a13581", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>rand100.html</title>
    <style type=""text/css"">
        fieldset {
            width: 600px;
            margin-right: auto;
            margin-left: auto;
        }

        label {
            float: left;
            width: 250px;
            text-align: right;
            margin-right: 1em;
            clear: left;
        }

        span {
            float: left;
        }
        input {
            float: right;
            width: 250px;
            text-align: right;
            margin-right: 1em;
            clear: left;
        }
        button {
            display: block;
            clear: both;
            margin: auto;
        }
    </style>
    <script type=""text/javascript"">
        function subtract() {
            //create variables for form elements
            var dNum1 = document.getElementById(""dNumx"");
            var dNum2 = document.getElementById(""dNumy"");
            var result = document.getElementById");
                WriteLiteral(@"(""resultz"");
            var result1 = document.getElementById(""result"")
            //get random number
            var rand1 = Math.random();
            //multiply by 100
            var a = rand1 * 100;
            var dNum1 = Math.floor(a);
            var rand2 = Math.random();
            var b = rand2 * 100;
            //multiply by 100
            var dNum2 = Math.floor(b);
            dNumx.innerHTML = dNum1;
            dNumy.innerHTML = dNum2;
            var result = (dNum1 - dNum2);
            resultz.innerHTML = result;
            /*var result2 = console.log(parseInt(result1, 10));
            if (result2 == result) {
                document.write(""Congratulations! Try Another one"");
            }
            if (result2 != result) {
                document.write(""Incorrect!! Try Again"");
            }*/
        } // end subtract
    </script>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97ec0b4cf8df0f921861b0ba7c1634190bdee4a16522", async() => {
                WriteLiteral("\r\n    <h1>Substract Number 1 from Number 2</h1>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97ec0b4cf8df0f921861b0ba7c1634190bdee4a16833", async() => {
                    WriteLiteral(@"
        <fieldset>
            <label>Number 1</label>
            <span id=""dNumx"">0</span>
            <label>Number 2</label>
            <span id=""dNumy"">0</span>
            <input type=""text"" name=""result"" id=""result"" placeholder=""Enter your answer"" />
            <br />
            <button onclick=""subtract()"" id=""btn1"">Submit</button>
            <label>result</label>
            <span id=""resultz"">0</span>
            <button type=""button""
            onclick=""subtract()"">
            Subtract
            </button>
        </fieldset>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MathGame.Pages.SubtractionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MathGame.Pages.SubtractionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MathGame.Pages.SubtractionModel>)PageContext?.ViewData;
        public MathGame.Pages.SubtractionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
