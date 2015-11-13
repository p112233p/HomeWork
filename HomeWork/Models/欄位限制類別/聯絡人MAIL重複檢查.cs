using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork.Models.欄位限制類別
{
    public class 聯絡人MAIL重複檢查 : DataTypeAttribute
    {
        public 聯絡人MAIL重複檢查() : base(DataType.Text)
        {
            this.ErrorMessage = "Mail不得重複";
        }

        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);
            var num = 0;

            //var data = db.客戶聯絡人.AsQueryable();
            //num = (from p in data
            //    where p.Email == str.
            //    select p).Count();

            return (num == 0);
        }
    }
}