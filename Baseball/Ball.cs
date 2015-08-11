using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public class Ball
    {
        public event EventHandler BallInPlay;

        public BallEventArgs ballEventArgs = new BallEventArgs();

        public void OnBallInPlay(BallEventArgs ballEventArgs)
        {
            this.ballEventArgs.Angle = ballEventArgs.Angle;
            this.ballEventArgs.Distance = ballEventArgs.Distance;
            BallInPlay(this, this.ballEventArgs);
        }
    }
}