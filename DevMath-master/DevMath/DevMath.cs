using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class DevMath
    {
        public static float Lerp(float a, float b, float t)
        {
            return a + (b - a) * t;
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            return startVelocity * time + 0.5f * acceleration * (time * time);
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value.CompareTo(min) < 0) return min;
            else if (value.CompareTo(max) > 0) return max;
            else return value;
        }

        public static float RadToDeg(float angle)
        {
            return angle * (float)(180f / Math.PI);
        }

        public static float DegToRad(float angle)
        {
            return angle * (float)(Math.PI / 180f);
        }
    }
}
