﻿using LtiLibrary.Core.Common;
using Microsoft.AspNetCore.Mvc;

namespace LtiLibrary.AspNet.Outcomes.v2
{
    public class LineItemResult : JsonResult
    {
        public LineItemResult(object value) : base(value)
        {
            ContentType = LtiConstants.LineItemMediaType;
        }
    }
}
