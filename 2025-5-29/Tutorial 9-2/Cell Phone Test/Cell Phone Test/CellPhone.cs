using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Test
{
    class CellPhone
    {
        // 私有欄位：儲存手機品牌
        private string brand;

        // 私有欄位：儲存手機型號
        private string _model;

        // 私有欄位：儲存手機價格
        private decimal price;

        // 公開屬性：取得或設定手機品牌
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // 公開屬性：取得或設定手機型號
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // 公開屬性：取得或設定手機價格
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                price = value;
            }
        }
    }
}