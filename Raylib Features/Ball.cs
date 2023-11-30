using System.Numerics;
using Raylib_cs;

namespace Raylib_Features
{
    public class Ball
    {
        Vector2 position;
        float radius;
        float speed_x = 1;
        float speed_y = 1;  

        public Ball ()
        {
            // get screen parameters 
            position.X = Raylib.GetScreenWidth() / 2;
            position.Y = Raylib.GetScreenHeight() / 2;
            // set size of the ball 
            radius = 5;
        }

        public void draw()
        {
            // set up draw. Chose Yellow as an objective
            Raylib.DrawCircleV(position, radius, Color.YELLOW);
        }
        public void move()
        {
            position.X += speed_x;
            position.Y += speed_y;
            speed_x *= 1.1;
            speed_x = Math.Max(speed_x, 2.0);
            speed_x = Math.Min(speed_x, -2.0);
            speed_y *= 1.1;
            speed_y = Math.Max(speed_y, 2.0);
            speed_y = Math.Min(speed_y, -2.0);
        }
    }
    

}
