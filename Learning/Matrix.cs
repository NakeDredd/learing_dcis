using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    public class Matrix
    {
        private float[,] matrix;
        private int sizeVertical;
        private int sizeHorizontal;

        public Matrix(int size)
        {
            this.sizeHorizontal = size;
            this.sizeVertical = size;
            matrix = new float[size, size];
        }

        public Matrix(int sizeHorizontal, int sizeVertical)
        {
            this.sizeHorizontal = sizeHorizontal;
            this.sizeVertical = sizeVertical;
            matrix = new float[sizeHorizontal, sizeVertical];
        }

        public void Show()
        {
            for (int hIndex = 0; hIndex < sizeHorizontal; hIndex++)
            {
                for (int vIndex = 0; vIndex < sizeVertical; vIndex++)
                {
                    Console.Write($" {matrix[hIndex, vIndex] }");
                }
                Console.WriteLine();
            }
        }

        public float[,] GetMatrix()
        {
            return matrix;
        }
        public int GetHorizontalSize()
        {
            return sizeHorizontal;
        }
        public int GetVerticalSize()
        {
            return sizeVertical;
        }

    }
}
