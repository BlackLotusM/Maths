using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        }

        public float Acceleration 
        { 
            get; private set; 
        }

        public float mass = 1.0f;

        public float frictionCoefficient;
        public float normalForce;

        public void UpdateVelocityWithForce(Vector2 forceDirection, float forceNewton, float deltaTime)
        {
            float friction = frictionCoefficient * normalForce;
            float forcenett = forceDirection.Magnitude * forceNewton - friction;

            if (forceDirection.Magnitude == 0)
            {
                if (Velocity.Magnitude < 0.01f)
                {
                    Velocity = new Vector2(0, 0);
                    Acceleration = 0;
                }
                else
                {
                    Acceleration = -friction / mass * deltaTime;
                    Velocity -= Velocity.Normalized * friction / mass * deltaTime;
                }
            }
            else
            { 
                if(forcenett < 0)
                {
                    forcenett = 0;
                }
                Acceleration = (forceNewton - friction) / mass * deltaTime;
                Velocity += (forceDirection * (forcenett / mass) * deltaTime);
            }            
        }
    }
}
