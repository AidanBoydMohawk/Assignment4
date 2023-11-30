using Raylib_cs;
using System.Numerics;
using System.Security.AccessControl;
using static Raylib_cs.Raylib;


namespace Raylib_Features
{
    internal class Program_controller
    {
        // If you need variables in the Program class (outside functions), you must mark them as static
        static string title = "PONG";
        static Ball ball;
        static Paddle leftPaddle;
        static Paddle rightPaddle;
        //player controller speed start
        static float speedX = 0.02F;
        static float speedY = 0.02F;
        //player controller speed end
        static void Main(string[] args)
        {

            // Create a window to draw to. The arguments define width and height
            Raylib.InitWindow(800, 600, title);
            // Set the target frames-per-second (FPS)
            Raylib.SetTargetFPS(60);

            // Setup your game. This is a function YOU define.
            Setup();

            // Loop so long as window should not close
            while (!Raylib.WindowShouldClose())
            {
                // Enable drawing to the canvas (window)
                Raylib.BeginDrawing();
                // Clear the canvas with one color
                Raylib.ClearBackground(Color.BLACK);

                // Your game code here. This is a function YOU define.
                Update();

                // Stop drawing to the canvas, begin displaying the frame
                Raylib.EndDrawing();
            }
            // Close the window
            Raylib.CloseWindow();
        }

        static void Setup()
        {
            // Your one-time setup code here
            ball = new Ball();
            leftPaddle = new Paddle(0, Raylib.GetScreenHeight() / 2 - 45, Color.BLUE);
            rightPaddle = new Paddle(Raylib.GetScreenWidth() - 10, Raylib.GetScreenHeight() / 2 - 45, Color.RED);

        }



        static void Update()
        {
            // Your game code run each frame here
            ball.draw();
            leftPaddle.draw();
            rightPaddle.draw();

        }
        //player controller start
        static void player_control()
        {
            //The player controller of leftPaddle and rightPaddle w,a,s,d and up down right left arrow
            if (IsKeyDown(KeyboardKey.KEY_D && leftPaddle.position.X < Raylib.GetScreenWidth() / 2))
            {
                leftPaddle.position.X += speedX;

            }

            if (IsKeyDown(KeyboardKey.KEY_A && leftPaddle.position.X > 0))
            {
                //positionX -= 2.0f;
                leftPaddle.position.X -= speedX;
            }

            if (IsKeyDown(KeyboardKey.KEY_W && leftPaddle.position.Y > 0))
            {
                //positionY -= 2.0f;
                leftPaddle.position.Y += speedY;
            }

            if (IsKeyDown(KeyboardKey.KEY_S && leftPaddle.position.Y < Raylib.GetScreenHeight()))
            {
                //positionY += 2.0f;
                leftPaddle.position.Y -= speedY;
            }
            //Right

            if (IsKeyDown(KeyboardKey.KEY_RIGHT && rightPaddle.position.X < Raylib.GetScreenWidth()))
            {
                rightPaddle.position.X += speedX;

            }

            if (IsKeyDown(KeyboardKey.KEY_LEFT && rightPaddle.position.X > Raylib.GetScreenWidth() / 2))
            {
                //positionX -= 2.0f;
                rightPaddle.position.X -= speedX;
            }

            if (IsKeyDown(KeyboardKey.KEY_UP && rightPaddle.position.Y > 0))
            {
                //positionY -= 2.0f;
                rightPaddle.position.Y += speedY;
            }

            if (IsKeyDown(KeyboardKey.KEY_DOWN && rightPaddle.position.Y < Raylib.GetScreenHeight()))
            {
                //positionY += 2.0f;
                rightPaddle.position.Y -= speedY;
            }

        }
        //player controller end
    }
}