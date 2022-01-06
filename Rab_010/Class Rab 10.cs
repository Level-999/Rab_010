using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rab_010
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        //double a = Math.PI / 180;        
              
        public bool isCorrect = true;
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    gradus = value % 360;
                }
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Gradus += value / 60;
                    min = value % 60;
                }
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Min += value / 60;
                    sec = value % 60;
                }
            }
        }

        public Angle(int gradus, int min, int sec )
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;

        }

        public int ToRadians()
        {

            return (((gradus + min + sec) * (int)Math.PI / 180));

        }
    }
}