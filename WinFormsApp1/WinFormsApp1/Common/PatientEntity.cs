using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Common
{
    public class PatientEntity
    {
        /// <summary>
        /// 患者の一意識別子を取得または設定します。
        /// </summary>
        public string PatientId { get; set; } = string.Empty;

        /// <summary>
        /// 患者の氏名を取得または設定します。
        /// </summary>
        public string PatientName { get; set; } = string.Empty;

        /// <summary>
        /// 性別を示す値を取得または設定します。
        /// </summary>
        public int Gender { get; set; } = 1; // 1: 男性, 2: 女性, 3:不明

        /// <summary>
        /// 年齢を取得または設定します。
        /// </summary>
        public int Age { get; set; } = 0;

        /// <summary>
        /// 診断情報を取得または設定します。
        /// </summary>
        public string Diagnosis { get; set; } = string.Empty;
    }
}
