using System.Collections.Generic;
using Raylib_cs;


while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.SKYBLUE);
    Raylib.EndDrawing();
}

List<Rectangle> rects = new List<Rectangle>();
Rectangle tmp = rects[1];
tmp.x = 5;
rects[1] = tmp;