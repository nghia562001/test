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

        // Gọi hàm nhập mảng
        InputArray(array);

        // Gọi hàm tìm giá trị lớn nhất
        int max = FindMax(array);

        Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
    }

    // Hàm nhập mảng
    static void InputArray(int[,] arr)
    {
        Console.WriteLine("Nhập giá trị cho mảng:");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"Nhập giá trị cho phần tử [{i},{j}]: ");
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Hàm tìm giá trị lớn nhất
    static int FindMax(int[,] arr)
    {
        int max = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
        }
        return max;
    }
}
