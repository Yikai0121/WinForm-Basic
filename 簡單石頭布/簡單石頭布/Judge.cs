using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 簡單石頭布
{
    public enum Result
        {
        電腦贏,
        玩家贏,
        平手
        }
    class Judge
    {
      
        public static  Result Judgenum(int playernumber,int computernumber)
        {
            if (playernumber - computernumber == -1 || playernumber - computernumber == 2)
            {
                return Result.玩家贏;
            }
            else if (playernumber - computernumber == 0)
            {
                return Result.平手;
            }
            else
            {
                return Result.電腦贏;
            }
        }

    }
}
