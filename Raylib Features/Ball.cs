using System.Numerics;
using Raylib_cs;

namespace Raylib_Features
{
    public class Ball
    {
        Vector2 position;
        float radius; 

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

    }
    

}
