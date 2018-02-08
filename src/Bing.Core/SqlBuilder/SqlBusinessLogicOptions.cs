﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.SqlBuilder
{
    /// <summary>
    /// Sql业务逻辑配置
    /// </summary>
    public static class SqlBusinessLogicOptions
    {
        /// <summary>
        /// 主键字段
        /// </summary>
        public static string FieldId = "Id";

        /// <summary>
        /// 上级字段
        /// </summary>
        public static string FieldParentId = "ParentId";

        /// <summary>
        /// 编号字段
        /// </summary>
        public static string FieldCode = "Code";
    }
}
