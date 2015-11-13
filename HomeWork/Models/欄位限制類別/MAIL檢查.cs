using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork.Models.欄位限制類別
{
    public class MAIL檢查 : DataTypeAttribute
    {
        public MAIL檢查(): base(DataType.Text)
        {
            this.ErrorMessage = "Mail必須輸入正確格式 Ex:test@test.com.tw";
        }

        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);

            //@檢查
            var num1 = (from p in str.ToArray()
                        where p == '@'
                        select p).Count();

            //@檢查
            var com = false;
            for (int i = 0; i <= str.Length-4; i++)
			{
			    if (str.Substring(i, 4) == ".com")
                {
                    com = true;
                }                
			}
            return (num1 == 1 && com);
        }
    }
}