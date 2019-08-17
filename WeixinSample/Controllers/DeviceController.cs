using System.Web.Mvc;
using Senparc.Weixin;
using Senparc.Weixin.MP.Containers;
using Senparc.Weixin.MP.Helpers;

namespace WeixinSample.Controllers
{
    /// <summary>
    /// 设备能力测试
    /// </summary>
    public class DeviceController : BaseController
    {
        private string appId = Config.SenparcWeixinSetting.WeixinAppId;
        private string secret = Config.SenparcWeixinSetting.WeixinAppSecret;


        public ActionResult Index()
        {
            var accessToken = AccessTokenContainer.TryGetAccessToken(appId, secret);
            TempData["AccessToken"] = accessToken;
            var jssdkUiPackage = JSSDKHelper.GetJsSdkUiPackage(appId, secret, Request.Url.AbsoluteUri);
            return View(jssdkUiPackage);
        }
    }
}