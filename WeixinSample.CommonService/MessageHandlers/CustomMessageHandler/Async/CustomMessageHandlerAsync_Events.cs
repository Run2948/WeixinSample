﻿/*----------------------------------------------------------------
    Copyright (C) 2019 Senparc
    
    文件名：CustomMessageHandler_Events.cs
    文件功能描述：自定义MessageHandler
    
    
    创建标识：Senparc - 20150312
----------------------------------------------------------------*/

using System.Threading.Tasks;
using Senparc.NeuChar.Entities;
using Senparc.Weixin.MP.Entities;

namespace WeixinSample.CommonService.CustomMessageHandler
{
    /// <summary>
    /// 自定义MessageHandler
    /// </summary>
    public partial class CustomMessageHandler
    {
        public override Task<IResponseMessageBase> OnEvent_ClickRequestAsync(RequestMessageEvent_Click requestMessage)
        {
            return Task.Factory.StartNew<IResponseMessageBase>(() =>
            {
                var syncResponseMessage = OnEvent_ClickRequest(requestMessage);//这里为了保持Demo的连贯性，结果先从同步方法获取，实际使用过程中可以全部直接定义异步方法
                //常识获取Click事件的同步方法
                if (syncResponseMessage is ResponseMessageText)
                {
                    var textResponseMessage = syncResponseMessage as ResponseMessageText;
                    textResponseMessage.Content += "\r\n\r\n  -- 来自【异步MessageHandler】的回复";
                }

                return syncResponseMessage;
            });
        }
    }
}