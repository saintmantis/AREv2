#pragma checksum "C:\Users\Егор\source\repos\AREV2.0\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d01e6fe5cba1114170ae65eae2aa1c1edd1489e0"
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
#line 1 "C:\Users\Егор\source\repos\AREV2.0\Views\_ViewImports.cshtml"
using AREV2._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Егор\source\repos\AREV2.0\Views\_ViewImports.cshtml"
using AREV2._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d01e6fe5cba1114170ae65eae2aa1c1edd1489e0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8201be0a238035b84e490a4edcacdb347434baa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("decor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/HomeController1/ThankYouBd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fullpage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Егор\source\repos\AREV2.0\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
	<p style=""position: fixed; z-index:99; top: 3%; left: 4%; border: 0;"" data-menuanchor=""ARE"">
		<a href=""#ARE"">Are v2.0</a>
	</p>
</div>

<div id=""fullpage"">
	<div class=""section"" id=""section0"" data-anchor=""ARE"">
		<h1>
			ARE V2.0
		</h1>
		<div id=""menu"">
			<p data-menuanchor=""block1""><a href=""#block1"">About us</a></p>
			<p data-menuanchor=""block2""><a href=""#block2"">How it works</a></p>
			<p data-menuanchor=""block3""><a href=""#block3"">Suggestion for you</a></p>
			<p data-menuanchor=""block4""><a href=""#block4"">Privacy</a></p>
		</div>
	</div>
	<div class=""section"" id=""section1"">
		<div class=""slide"" id=""slide1""><h1>Листай</h1></div>
		<div class=""slide"" id=""slide2""><h1>Слайд справа</h1></div>
		<div class=""slide"" id=""slide3""><h1>второй слайд справа</h1></div>
		<div class=""slide"" id=""slide4""><h1>третий слайд справа</h1></div>
	</div>
	<div class=""section"" id=""section2"" data-anchor=""block1"">

		<h1>About us</h1>
		<div class=""text""></div>

	</div>
	<div class=""section"" id");
            WriteLiteral("=\"section1\" data-anchor=\"block2\">\r\n\t\t<h1>How it works</h1>\r\n\t</div>\r\n\t<div class=\"section\" id=\"section4\" data-anchor=\"block3\">\r\n\t\t<h1>Suggestions for you</h1>\r\n\t\t<!--форма для ввода-->\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d01e6fe5cba1114170ae65eae2aa1c1edd1489e06537", async() => {
                WriteLiteral(@"
			<div class=""form-left-decoration""></div>
			<div class=""form-right-decoration""></div>
			<div class=""circle""></div>
			<div class=""form-inner"">
				<h3>Написать нам</h3>
				<input input name=""login"" type=""text"" placeholder=""Username"">
				<input name=""login1"" type=""text"" placeholder=""Email"">
				<textarea name=""login2"" type=""text"" placeholder=""Сообщение..."" rows=""3""></textarea>
				<input type=""submit"" value=""Отправить"">
			</div>
		");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t<!--форма для ввода-->\r\n\t</div>\r\n\t<div class=\"section\" id=\"section1\" data-anchor=\"block4\">\r\n\t\t<h1>Privacy</h1>\r\n\t</div>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d01e6fe5cba1114170ae65eae2aa1c1edd1489e08764", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<!--Скрипты для кода-->
<script type=""text/javascript"">
	var myFullpage = new fullpage('#fullpage', {
		verticalCentered: false
	});
</script> <!--скрипт для fullpage-->
<script>
	class TextScramble {
		constructor(el) {
			this.el = el;
			this.chars = ""!<>-_\\/[]{}—=+*^?#________"";
			this.update = this.update.bind(this);
		}
		setText(newText) {
			const oldText = this.el.innerText;
			const length = Math.max(oldText.length, newText.length);
			const promise = new Promise((resolve) => (this.resolve = resolve));
			this.queue = [];
			for (let i = 0; i < length; i++) {
				const from = oldText[i] || """";
				const to = newText[i] || """";
				const start = Math.floor(Math.random() * 300);
				const end = start + Math.floor(Math.random() * 10);
				this.queue.push({ from, to, start, end });
			}
			cancelAnimationFrame(this.frameRequest);
			this.frame = 0;
			this.update();
			return promise;
		}
		update() {
			let output = """";
			let complete = 0;
			for (let i = ");
            WriteLiteral(@"0, n = this.queue.length; i < n; i++) {
				let { from, to, start, end, char } = this.queue[i];
				if (this.frame >= end) {
					complete++;
					output += to;
				} else if (this.frame >= start) {
					if (!char || Math.random() < 0.28) {
						char = this.randomChar();
						this.queue[i].char = char;
					}
					output += `<span class=""dud"">${char}</span>`;
				} else {
					output += from;
				}
			}
			this.el.innerHTML = output;
			if (complete === this.queue.length) {
				this.resolve();
			} else {
				this.frameRequest = requestAnimationFrame(this.update);
				this.frame++;
			}
		}
		randomChar() {
			return this.chars[Math.floor(Math.random() * this.chars.length)];
		}
	}

	const phrases = [
		""if (complete === this.queue.length) {▓"",
		""[Math.floor(Math.random()▓"",
		""$('html').animate({scrollTop:0},1000);▓"",
		""} else {▓"",
		""output += `<span class=>${char}</span>`;▓""
	];

	const el = document.querySelector("".text"");
	const fx = new TextScramble(el);

	let ");
            WriteLiteral("counter = 0;\r\n\tconst next = () => {\r\n\t\tfx.setText(phrases[counter]).then(() => {\r\n\t\t\tsetTimeout(next, 800);\r\n\t\t});\r\n\t\tcounter = (counter + 1) % phrases.length;\r\n\t};\r\n\r\n\tnext();\r\n</script> <!--скрипт для красивой самопечатаюзейся надписи-->");
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
