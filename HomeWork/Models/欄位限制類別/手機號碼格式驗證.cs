using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork.Models.欄位限制類別
{
    public class 手機號碼格式驗證 : DataTypeAttribute
    {
        public 手機號碼格式驗證() : base(DataType.Text)
        {
            this.ErrorMessage = "手機號碼必須輸入正確格式 Ex:0911-111111";
        }

        public override bool IsValid(object value)
        {
            string str1 = Convert.ToString(value);

            //@檢查
            var num1 = false;
            var num2 = false;
            var v_str = false;
            int num;
            //string str2 = String.Format("\d{4}-\d{6}", str1);
            if (str1.Substring(4, 1) == "-")
            {
                v_str = true;
            }
            if (int.TryParse(str1.Substring(0, 4), out num) == false)
            {
                num1 = true;
            }
            if (int.TryParse(str1.Substring(5, str1.Length), out num) == false)
            {
                num2 = true;
            }
            return (num1 && num2 && v_str);
        }
    }
}