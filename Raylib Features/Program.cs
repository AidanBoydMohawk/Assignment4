﻿using Raylib_cs;
using System.Numerics;
using System.Security.AccessControl;

namespace Raylib_Features
{
    internal class Program
    {
        static string title = "PONG";
        static Ball ball;
        static Paddle leftPaddle;
        static Paddle rightPaddle;
        static int scoreleftPaddle = 0;
        static int scorerightPaddle = 0;
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
            leftPaddle = new Paddle(0, Raylib.GetScreenHeight()/2 -45, Color.BLUE);
            rightPaddle = new Paddle(Raylib.GetScreenWidth() - 10, Raylib.GetScreenHeight() / 2 - 45, Color.RED);
            
        }
        
        


        static void Update()
        {
            
            ball.draw();
            ball.move();
            ball.collide();
            leftPaddle.draw();
            rightPaddle.draw();

            //score tracker 
            if (ball.IsPastLeftSide())
            {
                scorerightPaddle++;
                ball.reset();
            }
            if (ball.IsPastRightSide())
            {
               scoreleftPaddle++;
                ball.reset();
            }

            Raylib.DrawText(scoreleftPaddle.ToString(), 75, 20, 32, Color.WHITE);
            Raylib.DrawText(scorerightPaddle.ToString(), -75, 20, 32, Color.WHITE);
            

        }
    }
}
