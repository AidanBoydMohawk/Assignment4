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
            if (speed_x !> 2 || speed_x !< -2)
            {
                speed_x *= 1.1;
            }
            if (speed_y! > 2 || speed_y! < -2)
            {
                speed_y *= 1.1;
            }
        }
    }
    

}
