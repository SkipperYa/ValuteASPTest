using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValuteASPTest.Models;

namespace ValuteASPTest.Helpers
{
    //public static class PagingHelpers
    //{
    //    public static MvcHtmlString PageLinks(this System.Web.Mvc.HtmlHelper html,
    //    PageInfo pageInfo, Func<int, string> pageUrl)
    //    {
    //        StringBuilder result = new StringBuilder();
    //        for (int i = 1; i <= pageInfo.TotalPages; i++)
    //        {
    //            System.Web.Mvc.TagBuilder tag = new System.Web.Mvc.TagBuilder("a");
    //            tag.MergeAttribute("href", pageUrl(i));
    //            tag.InnerHtml = i.ToString();

    //            if (i == pageInfo.PageNumber)
    //            {
    //                tag.AddCssClass("selected");
    //                tag.AddCssClass("btn-primary");
    //            }
    //            tag.AddCssClass("btn btn-default");
    //            result.Append(tag.ToString());
    //        }
    //        return MvcHtmlString.Create(result.ToString());
    //    }
    //}
}
