using Raylib_cs;
using System.Numerics;
using System.Reflection.Metadata;

namespace Raylib_controller
{

    public class control
    {
        float positionX;
        float positionY;
        float speedX = 100;
        float speedY = 100;
       

            if IsKeyDown(KeyboardKey kEY_W)
            {
                positionY -= speedY;
            return positionY;
            }

            if IsKeyDown(KeyboardKey kEY_S)
            {
                positionY += speedY;
            return positionY;
            }
            if IsKeyDown(KeyboardKey kEY_A)
            {
                positionX -= speedX;
            return positionX;
            }
            if IsKeyDown(KeyboardKey KEY_D)
            {
                positionX += speedX;
            return positionX;
            }
        
    }
}