using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 簡單石頭布
{
    class Player
    {
           public int ShowFist(string str)
        {
            int num = 0;
            switch (str)
                {
                    case "石頭":
                        num = 1;
                        break;
                    case "剪刀":
                        num = 2;
                        break;
                    case "布":
                        num = 3;
                        break;
                }
            return num;
        }
    }
}
