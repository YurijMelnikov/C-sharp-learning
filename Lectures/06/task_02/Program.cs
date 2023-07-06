void DrawText (string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    System.Console.WriteLine(text);
}
DrawText("Текст", 1, 1);