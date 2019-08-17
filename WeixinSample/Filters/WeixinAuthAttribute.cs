using System.Web.Mvc;

namespace WeixinSample.Filters
{
    public class WeixinAuthAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext == null || filterContext.HttpContext.Session["OpenId"] == null || filterContext.HttpContext.Session["OAuthAccessToken"] == null)
            {
                filterContext.Result = new RedirectResult($"/OAuth2?returnUrl={filterContext.HttpContext.Request.Url}");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}