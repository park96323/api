﻿using Api.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Weixin.Mp
{
    /// <summary>
    /// 发送模板消息请求结果
    /// </summary>
    public class SendTemplateMessageResult : JsonResult
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        public long msgid { get; set; }
    }
}
