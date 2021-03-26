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

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output != null)
            {
                IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
                TagBuilder pagination = new TagBuilder("ul");
                pagination.AddCssClass("pagination");
                for (int i = 1; i <= PageModel.TotalPages; i++)
                {
                    TagBuilder listItemTag = new TagBuilder("li");
                    listItemTag.AddCssClass("page-item");
                    TagBuilder linkTag = new TagBuilder("a");
                    linkTag.AddCssClass("page-link");
                    linkTag.Attributes["href"] = urlHelper.Action(PageAction, new { page = i });
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
