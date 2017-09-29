using System;

namespace CSharpPerformanceTricks
{
	class MainClass
	{
		private static void DrawLine(int x1, int y1, int x2, int y2)
		{
			// TODO: put line drawing code here
		}

		private static void DrawSquare(int x, int y, int w, int h)
		{
			int xw = x + w; 
			int yh = y + h;

			DrawLine (x, y, xw, y);
			DrawLine (xw, y, xw, yh);
			DrawLine (xw, yh, x, yh);
			DrawLine (x, yh, x, y);
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Console.WriteLine ("Going to draw a square...");
			DrawSquare (100, 100, 50, 50);
			Console.WriteLine("All done!");
            Console.ReadLine();
        }
    }
}
