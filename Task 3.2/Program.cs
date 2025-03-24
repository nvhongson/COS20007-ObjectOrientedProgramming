using System;
using SplashKitSDK;

namespace DrawingShape
{
    public class Program
    {
        public static void Main()
        {
            Drawing myDrawing = new Drawing();

            _ = new Window("Drawing Shape", 800, 600);

            while (!SplashKit.WindowCloseRequested("Drawing Shape") && !SplashKit.KeyTyped(KeyCode.EscapeKey))
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    int x_pos = (int)SplashKit.MouseX();
                    int y_pos = (int)SplashKit.MouseY();
                    Shape newShape = new Shape(x_pos, y_pos);
                    newShape.SetRandomColor(); // Set the color to a random RGB color
                    myDrawing.AddShape(newShape);
                    Console.WriteLine("Mouse Left");
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectShapeAt(SplashKit.MousePosition());
                    Console.WriteLine("Mouse Right");
                }

                // Additional Function
                if (SplashKit.KeyDown(KeyCode.EscapeKey))
                {
                    myDrawing.ChangingShapeColor();
                    Console.WriteLine("ESC");
                }
                // End Additional Function

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                    {
                        Console.WriteLine("Backspace");
                    }
                    if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                    {
                        Console.WriteLine("Delete");
                    }
                    myDrawing.RemoveShape();
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                    Console.WriteLine("SpaceKey");
                }

                myDrawing.Draw();

                SplashKit.RefreshScreen();
            }
        }
    }
}
