using System;
using System.Drawing;
using System.Numerics;
using Raylib;
using static Raylib.Raylib;

namespace Controller
{
   


    namespace PongGame
    {
        public class Program
        {
            private const int screenWidth = 800;
            private const int screenHeight = 450;
            private const int PaddleWidth = 20;
            private const int PaddleHeight = 80;
            private const int paddleSpeed = 5;

            private static Rectangle player1Paddle;
            private static Rectangle player2Paddle;
            private static Vector2 ballPositon;
            private static Vector2 ballSpeed;
            public static void Main()
            {
                InitWIndow(screenWidth, screenHeight, "Pong Game");
                player1Paddle = new Rectangle(50, screenHeight / 2 - PaddleHeight / 2, PaddleWidth, PaddleHeight);
                player2Paddle = new Rectangle(screenWidth - 50 - PaddleWidth, screenHeight / 2 - PaddleHeight / 2, PaddleWidth, PaddleHeight);
                ballPositon = new Vector2(screenWidth / 2, screenHeight / 2);
                ballSpeed = new Vector2(5, 5);
                SetTargetFPS(60);
                while (!WindowShouldClose())
                {
                    UpdateGame()
    
                DrawGame();
                }
                CloseWindow();
            }
            private static void UpdateGame()
            {

                /*
                 * MOVE MOVEMENT CONTROLLER START
                 */
                // Controller of player 1
                // if press w, then player1 move up
                if (IsKeyDown(KeyboardKey.KEY_W) && player1Paddle.y > 0)
                {
                    player1Paddle.y -= paddleSpeed;
                }
                //if press s , then player 1 move down
                if (IsKeyDown(KeyboardKey.KEY_S) && player1Paddle.y + paddleHeight < screenHeight)
                {
                    player1Paddle.y += paddleSpeed;
                }
                //if press a, then player 1 move left
                if (IsKeyDown(KeyboardKey.KEY_A) && player1Paddle.x > 0)
                {
                    player1Paddle.x -= paddleSpeed;
                }
                //if press s , then player 1 move down, attention the player 1 need to move at the left half
                if (IsKeyDown(KeyboardKey.KEY_D) && player1Paddle.x + paddleWidth < screenWidth / 2)
                {
                    player1Paddle.x += paddleSpeed;
                }

                // Controller of the player 2
                // if press up,  then player 2 move up
                if (IsKeyDown(KeyboardKey.KEY_UP) && player2Paddle.y > 0)
                {
                    player2Paddle.y -= paddleSpeed;
                }
                //if press s , then player 2 move down
                if (IsKeyDown(KeyboardKey.KEY_DOWN) && player2Paddle.y + paddleHeight < screenHeight)
                {
                    player2Paddle.y += paddleSpeed;
                }
                // if press left, then player 2 move left, attention the player 2 need to move in the right half
                if (IsKeyDown(KeyboardKey.KEY_LEFT) && player2Paddle.x > screenWidth / 2)
                {
                    player2Paddle.x -= paddleSpeed;
                }
                //if press right , then player 2 move right
                if (IsKeyDown(KeyboardKey.KEY_RIGHT) && player2Paddle.x + paddleWidth < screenWidth)
                {
                    player2Paddle.x += paddleSpeed;
                }
                /*
                * MOVE MOVEMENT CONTROLLER END
                */





                // update the ball position
                ballPosition.x += ballSpeed.x;
                ballPosition.y += ballSpeed.y;

                //Ball colision with the walls, the reset the y direction to -y
                if ((ballPositon.y >= screenHeight) || (ballPositon.y) <= 0)
                {
                    ballSpeed.y * = -1;
                }
                // ball collision with the pedal
                if (CheckCollisionCircleRec(ballPosition, 10, player1Paddle) || CheckCollisionCircleRec(ballPositon, 10, player2Paddle))
                {
                    ballSpeed.x *= -1;
                }
                // Ball out of bounds
                if (ballPosition.x > screenWidth || ballPositon.x < 0)
                {
                    ballPositon = new Vector2(screenWidth / 2, screenHeight / 2);
                }

            }
        }

    }
}