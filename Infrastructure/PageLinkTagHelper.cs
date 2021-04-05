using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    [HtmlTargetElement("nav", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }
        public string PageController { get; set; }
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassSelected { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output != null)
            {
                IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
                TagBuilder pagination = new TagBuilder("ul");
                pagination.AddCssClass("pagination");
                for (int i = 1; i <= PageModel.TotalPages; i++)
                {
                    PageUrlValues["page"] = i;

                    TagBuilder listItemTag = new TagBuilder("li");
                    TagBuilder linkTag = new TagBuilder("a");
                    linkTag.AddCssClass("page-link");
                    
                    if (PageController != null)
                    {
                        linkTag.Attributes["href"] = urlHelper.Action(PageAction, PageController, PageUrlValues);
                    } else
                    {
                        linkTag.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);
                    }

                    if (PageClassesEnabled)
                    {
                        listItemTag.AddCssClass(PageClass);
                        //listItemTag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                        if (i == PageModel.CurrentPage)
                        {
                            listItemTag.AddCssClass(PageClassSelected);
                        }
                    }
                    linkTag.InnerHtml.Append(i.ToString());
                    listItemTag.InnerHtml.AppendHtml(linkTag);
                    pagination.InnerHtml.AppendHtml(listItemTag);
                }

                output.Content.AppendHtml(pagination);
            }
            else
            {
                throw new Exception("Output was null when creating TagHelper");
            }
        }
    }
}
