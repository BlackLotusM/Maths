using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {
            float x = this.Position.x - circle.Position.x;
            float y = this.Position.y - circle.Position.y;

            float distance = (float)Math.Sqrt(x * x + y * y);

            if (distance <= this.Radius + circle.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
