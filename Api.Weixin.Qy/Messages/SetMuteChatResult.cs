﻿using Api.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Weixin.Qy
{
    /// <summary>
    /// 
    /// </summary>
    public class SetMuteChatResult : JsonResult
    {
        /// <summary>
        /// 列表中不存在的成员会返回在invaliduser里，剩余合法成员会继续执行。
        /// </summary>
        public string[] invaliduser { get; set; }
    }
}
