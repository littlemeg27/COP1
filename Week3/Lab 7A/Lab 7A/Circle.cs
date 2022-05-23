//COP1
//Lab 7
//Brenna Pavlinchak

using System;


namespace Lab_7A
{
    public class Circle
    {
        private float x;
        private float y;
        private float radius;


        public Circle(float a, float b, float r)
        {
            x = a;
            y = b;
            radius = r;
        }

            public float GetX() // Get for X
            {
                return x;
            }

            public float GetY() // Get for Y
            {
                return y;
            }

            public float GetRadius() // Get for Radius
            {
                return radius;
            }

            public void SetX(float a) // Set for X
            {
                x = a;
            }

            public void SetY(float b) // Set for y
            {
                y = b;
            }

            public void SetRadius(float r) // Set for Radius
            {
                radius = r;
            }

            public bool Contains(float a, float b) 
            {
                if(Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) > radius)
                {
                    return false;
                }
                return true;
            }

            public float GetArea()
            {
                return (float)Math.PI * radius * radius;
            }

            public float GetCircumference()
            {
                return (float)Math.PI * 2 * radius;
            }
    }
}
    
