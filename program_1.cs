using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số hàng của mảng: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Nhập số cột của mảng: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, columns];

        // Nhập giá trị cho mảng
        Console.WriteLine("Nhập giá trị cho mảng:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Nhập giá trị cho phần tử [{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Tìm giá trị lớn nhất
        int max = array[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }

        Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
    }
}
