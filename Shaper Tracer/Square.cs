using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaper_Tracer
{
    class Square
    {
        private Vector2 CentrePosition;
        public readonly float Dimension;

        public Square(Vector2 CentrePosition, float dimension)
        {
            this.CentrePosition = CentrePosition;
            this.Dimension = dimension;
        }

        public Vector2 TopLeft
        {
            get {
                return new Vector2(
                    CentrePosition.x - (Dimension / 2),
                    CentrePosition.y + (Dimension / 2)
              );
            }
            private set { }
        }
        public Vector2 TopRight
        {
            get
            {
                return new Vector2(
                    CentrePosition.x + (Dimension / 2),
                    CentrePosition.y + (Dimension / 2)
              );
            }
            private set { }
        }
        public Vector2 BottomRight
        {
            get
            {
                return new Vector2(
                    CentrePosition.x + (Dimension / 2),
                    CentrePosition.y - (Dimension / 2)
              );
            }
            private set { }
        }
        public Vector2 BottomLeft
        {
            get
            {
                return new Vector2(
                    CentrePosition.x - (Dimension / 2),
                    CentrePosition.y - (Dimension / 2)
              );
            }
            private set { }
        }
    }
}
