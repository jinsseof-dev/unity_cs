using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckPoint03
{
    internal class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;

        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);

                    if (j == MAP_Y - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }
        static void UpdateGO(int[] arrIndexX, int[,] map)
        {
            for (int i = 0; i < arrIndexX.Length; i++)
            {
                int indexMaxX = i + 1;
                int indexY = arrIndexX[i];

                int temp = map[indexMaxX, indexY];
                map[indexMaxX, indexY] = map[indexMaxX, indexY + 1];
                map[indexMaxX, indexY + 1] = temp;

                //arrIndexX[i]++;
            }
        }

        static bool UpdateRandomGO(int[] _arrIndexX, int[,] map, Random _rand)
        {
            bool isFinish = false;
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                if (_arrIndexX[i] >= 19)
                {
                    isFinish = true;
                    break;
                }
            }

            int randIndex = _rand.Next(0, 5);

            int indexY = _arrIndexX[randIndex];

            int temp = map[randIndex + 1, indexY];
            map[randIndex + 1, indexY] = map[randIndex + 1, indexY + 1];
            map[randIndex + 1, indexY + 1] = temp;

            _arrIndexX[randIndex]++;
            return isFinish;
        }

        static int[,] initMAP()
        {
            int[,] map = new int[MAP_X, MAP_Y]
            {
                // 0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, // 0
                { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 1
                { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 2
                { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 3
                { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 4
                { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 5
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } // 6
            };
            return map;
        }
        static int[] initArrIndexX()
        {
            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            return arrIndexX;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };
            int[,] map = initMAP();

            int[] arrIndexX = initArrIndexX();
            bool isFinish = false;
            while (true)
            {
                if (isFinish)
                {
                    Console.WriteLine();
                    for (int i=0;i<arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 19)
                        {
                            Console.Write("달리기 결과 => 1등: {0}", (i+1));
                            break;
                        }
                    }
                    Console.Write("\n다시 시작하려면 0을 입력");
                    string inputStr = Console.ReadLine();
                    if (inputStr == "0")
                    {
                        isFinish = false;
                        map = initMAP();
                        arrIndexX = initArrIndexX();
                        continue;
                    }
                    else
                    {
                        Console.Write("\n나가기");
                        break;
                    }
                }
                ClearView();
                UpdateGO(arrIndexX, map);
                isFinish = UpdateRandomGO(arrIndexX, map, rand);
                UpdateView(tile, map);
            }
        }
    }
}
