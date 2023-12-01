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
            //moves the ball
            position.X += speed_x;
            position.Y += speed_y;
            speed_x *= 1.1;
            speed_x = Math.Max(speed_x, 2.0);
            speed_x = Math.Min(speed_x, -2.0); //adds momentum with a maximum/minimum
            speed_y *= 1.1;
            speed_y = Math.Max(speed_y, 2.0);
            speed_y = Math.Min(speed_y, -2.0); //adds momentum with a maximum/minimum
        }
        public void bump()
        {
            //inverts ball direction and then halves momentum
            speed_x *= -0.5;
            speed_y *= -0.5;
            //sound for bumping should go here as well.
        }
        public void collide()
        {
            if (position.X == Paddle1.position.X && position.Y == Paddle1.position.Y)//check for collision against paddle 1
            {
                bump();
            }
            if (position.X == Paddle2.position.X && position.Y == Paddle2.position.Y)//check for collision against paddle 2
            {
                bump();
            }
            if (position.Y >= 800 || position.Y <= 0) //bounce against ceiling
            {
                speed_y *= -1;
            }
        }

        public bool IsPastLeftSide()
        {
            float leftEdge = 0;
            bool isPastLeftEdge = position.X < leftEdge;
            return isPastLeftEdge;
        }

        public bool IsPastRightSide()
        {
            float rightEdge = Raylib.GetScreenWidth();
            bool isPastRightEdge = position.X > rightEdge;
            return isPastRightEdge;
        }

        public void reset()
        {
            //reset ball to the centre
            position.X = Raylib.GetScreenWidth() / 2;
            position.Y = Raylib.GetScreenHeight() / 2;
            radius = 5;
            speed_x *= 1.1;
            speed_y *= 1.1;

        }
    }
    

}
