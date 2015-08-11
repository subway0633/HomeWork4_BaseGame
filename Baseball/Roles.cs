using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public class Roles
    {
        public string Message { get; set; }
        public string Name { get; set; }

        public Roles(Ball ball, string name, bool played)
        {
            if (played)
            {
                ball.BallInPlay += new EventHandler(this.球迷撿球);
                this.Name = name;
            }
            else
            {
                ball.BallInPlay += new EventHandler(this.裁判判定);
                this.Name = name;
            }
        }

        public void 球迷撿球(object sender, EventArgs e)
        {
            double angle = (e as BallEventArgs).Angle;

            double distance = (e as BallEventArgs).Distance;

            if (distance >= 400 && (angle >= 30 && angle <= 60))
            {
                Message = string.Format("全壘打，這球我接的到，給我撿!\n");
            }
            else
            {
                Message = string.Format("打的不夠遠啦!\n");
            }
        }

        public void 裁判判定(object sender, EventArgs e)
        {
            double angle = (e as BallEventArgs).Angle;

            double distance = (e as BallEventArgs).Distance;

            if (distance >= 400 && (angle >= 30 && angle <= 60))
            {
                Message = string.Format("全壘打，飛出去了!!\n");
            }
            else
            {
                Message = string.Format("這是界外球!!\n");
            }
        }
    }
}