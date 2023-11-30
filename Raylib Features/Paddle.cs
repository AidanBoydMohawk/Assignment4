using Raylib_cs;
using System.Numerics;

namespace Raylib_Features
{
    internal class Paddle
    {
        Vector2 position;
        Vector2 size;
        Color color;
        public Paddle(int positionX, int positionY, Color color)
        {
            //size of paddle
            size.X = 10;
            size.Y = Raylib.GetScreenHeight() / 8;

            //get position of paddle
            position.X = positionX;
            position.Y = positionY;

            //setting color for paddle 
            this.color = color;


        }

        public void draw()
        {
            Raylib.DrawRectangleV(position, size, color);
        }
    }
}
