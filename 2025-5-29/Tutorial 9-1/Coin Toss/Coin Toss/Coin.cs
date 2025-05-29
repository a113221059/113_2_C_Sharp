using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Coin_Toss
{
    internal class Coin
    {
        private string sideUp; // 硬幣正面朝上的面

        // 建構子：預設硬幣正面朝上
        public Coin()
        {
            sideUp = "正面"; // 預設硬幣正面朝上
        }

        // Toss 方法：隨機決定硬幣正反面
        public void Toss()
        {
            Random rand = new Random(); // 用於生成隨機數的實例
                                        // 隨機生成一個數字，0 或 1，來決定硬幣的正反面
            if (rand.Next(2) == 0)
            {
                sideUp = "正面"; // 0 表示正面
            }
            else
            {
                sideUp = "反面"; // 1 表示反面
            }
        }

        // 傳回目前硬幣正面朝上的面
        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
