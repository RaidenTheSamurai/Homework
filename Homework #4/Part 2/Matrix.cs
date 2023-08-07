using Homework__4.Part_1;
using Homework__4.Part_2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework__4.Part_2
{
    public class Matrix
    {
        public int Size { get; set; }
        public int[,] ReMatrix { get; set; }
        public Matrix()
        {
            Random rn = new Random();
            int size = rn.Next(5, 20);
            Size = size;
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rn.Next(-10, 10);
                }
            }
            ReMatrix = matrix;
        }
        public Matrix(int size)
        {
            Size = size;
            Random rn = new Random();
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rn.Next(-10, 10);
                }
            }
            ReMatrix = matrix;
        }
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Size != matrix2.Size) throw new ArgumentException();
            Matrix matrix = new Matrix(matrix1.Size);
            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                        matrix.ReMatrix[i, j] = matrix1.ReMatrix[i, j] + matrix2.ReMatrix[i, j];
                }
            }
         return matrix;
         }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Size != matrix2.Size) throw new ArgumentException();
            Matrix matrix = new Matrix(matrix1.Size);
            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    matrix.ReMatrix[i, j] = matrix1.ReMatrix[i, j] - matrix2.ReMatrix[i, j];
                }
            }
            return matrix;
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Size != matrix2.Size) throw new ArgumentException();
            Matrix matrix = new Matrix(matrix1.Size);
            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < matrix.Size; k++)
                    {
                        temp += matrix1.ReMatrix[i, k] * matrix2.ReMatrix[k, j];
                    }
                    matrix.ReMatrix[i, j] = temp;
                }
            }
            return matrix;
        }
        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            for (int i = 0;i < matrix1.Size; i++)
            {
                for(int j = 0;j < matrix2.Size; j++)
                {
                    if (matrix1.ReMatrix[i, j] != matrix2.ReMatrix[i, j])return false;
                }
            }
            return true;
        }
        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            for (int i = 0; i < matrix1.Size; i++)
            {
                for (int j = 0; j < matrix2.Size; j++)
                {
                    if (matrix1.ReMatrix[i, j] != matrix2.ReMatrix[i, j]) return true;
                }
            }
            return false;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType != obj.GetType) return false;
            Matrix matrix= (Matrix)obj;
            for(int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (matrix.ReMatrix[i, j] != ReMatrix[i, j]) return false;
                }
            }
            return true;
        }
        public void Print()
        {
            for (int i = 0;i < ReMatrix.GetLength(0);i++)
            {
                for(int j = 0;j < ReMatrix.GetLength(1); j++)
                {

                    Console.Write(ReMatrix[i,j] + " ");
                    
                }
                Console.WriteLine();
            }
        }
       
    }
}
