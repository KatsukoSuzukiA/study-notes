using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Common
{
    public class StaffAssignment
    {
        /// <summary>
        /// 執刀医
        /// </summary>
        public string Surgeon { get; set; } = string.Empty;

        /// <summary>
        /// 助手
        /// </summary>
        public string Assistant { get; set; } = string.Empty;

        /// <summary>
        /// 麻酔担当者
        /// </summary>
        public string Anesthetist { get; set; } = string.Empty;
    }
}
