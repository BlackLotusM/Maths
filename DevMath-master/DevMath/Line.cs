using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Line
    {
        public Vector2 Position
        {
            get; set;
        }

        public Vector2 Direction
        {
            get; set;
        }

        public float Length
        {
            get; set;
        }

        public bool IntersectsWith(Circle c)
        {
            //https://www.scratchapixel.com/lessons/3d-basic-rendering/minimal-ray-tracer-rendering-simple-shapes/ray-sphere-intersection
            Vector2 L = c.Position - Position;
            float Tca = Vector2.Dot(L, Direction);
            float d = (float)Math.Sqrt(L.Magnitude * L.Magnitude - Tca * Tca);

            float Thc = (float)Math.Sqrt(c.Radius * c.Radius - d * d);
            float T0 = Tca - Thc;

            if (Length < T0 || T0 < 0) { return false; }
            if (d < 0 || d > c.Radius)
            {
                return false;
            }
            else
            {
                if (c == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
