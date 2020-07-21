using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.GraphicalEditor.Reciver
{
    public class Image
    {
        private string[,] _image = null;
        private int n = 0;
        private int m = 0;
        private string pixelColor = "O";

        public void CreateImage(int n, int m) 
        {
            this.n = n;
            this.m = m;
            _image = new string[n,m];
            LoopArray((i, j) => _image[i, j] = "O");
        }

        public int GetCountRows() => n;
        public int GetCountColumns() => m;

        public void ShowContentImage()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", _image[i, j]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        public void ColorPixel(int x, int y, string color)
        {
            _image[y,x] = color;
        }

        public void ClearImage()
        {
            LoopArray((i, j) => _image[i, j] = "O");
        }

        public void GetPixelColor(int x, int y)
        {
            pixelColor = _image[x, y];
        }

        public void FloodFill(int x, int y, string newColor)
        {
            if(IsValidFillPixel(x,y) && _image[x, y].Equals(pixelColor))
            {
                _image[x, y] = newColor;

                FloodFill(x + 1, y, newColor);

                FloodFill(x - 1, y, newColor);

                FloodFill(x, y + 1, newColor);

                FloodFill(x, y - 1, newColor);
            }
        }

        private bool IsValidFillPixel(int x, int y)
        {
            return x >= 0 && x < GetCountRows() && y >= 0 && y < GetCountColumns();
        }

        private void LoopArray(Action<int, int> action)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    action(i, j);
                }
            }
        }

        public void VerticalFill(int x, int y1, int y2, string color)
        {
            int begin = y1 > y2 ? y2 : y1;
            int end = y1 > y2 ? y1 : y2;

            for (int i = begin; i <= end; i++)
            {
                _image[i, x] = color;
            }
        }

        public void HorizontalFill(int x1, int x2, int y, string color) 
        {
            int begin = x1 > x2 ? x2 : x1;
            int end = x1 > x2 ? x1 : x2;

            for (int i = begin; i <= end; i++)
            {
                _image[y,i] = color;
            }
        }
    }
}
