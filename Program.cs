// int size1 = 3;
// int size2 = 3;

// string[,] CreateXOMassiv(int size1, int size2)
// {
//     string[,] xo_massiv = new string[size1, size2];
//     for (int i = 0; i < size1; i++)
//     {
//         for (int j = 0; j < size2; j++)
//         {
//             xo_massiv[i, j] = ".";
//         }
//     }
//     return xo_massiv;
// }
// // Функция для заполнения двумерного массива

// void Print3dArray(string[,] xo_massiv)
// {
//     for (int i = 0; i < xo_massiv.GetLength(0); i++)
//     {
//         for (int j = 0; j < xo_massiv.GetLength(1); j++)
//         {
//             Console.Write($"{xo_massiv[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// // Функция для вывода массива на экран

// void PlayersMoves(string[,] xo_massiv)
// {
//     int index = 1;
//     string Player1 = String.Empty;
//     string Player2 = String.Empty;
//     if (Player1 != "Victory - Player 1" || Player2 != "Victory - Player 2")
//     {
//         index++;
//         for (int k = 0; k <= index; k++)
//         {
//             Console.Write("x1: ");
//             int x1 = Convert.ToInt32(Console.ReadLine());
//             Console.Write("x2: ");
//             int x2 = Convert.ToInt32(Console.ReadLine());
//             xo_massiv[x1, x2] = "x";
//             Console.WriteLine();
//             Print3dArray(xo_massiv);
//             Console.Write("y1: ");
//             int y1 = Convert.ToInt32(Console.ReadLine());
//             Console.Write("y2: ");
//             int y2 = Convert.ToInt32(Console.ReadLine());
//             xo_massiv[y1, y2] = "o";
//             for (int i = 0; i < xo_massiv.GetLength(0); i++)
//             {
//                 for (int j = 0; j < xo_massiv.GetLength(1); j++)
//                 {
//                     if (xo_massiv[0, 0] == "x"
//                         && xo_massiv[0, 1] == "x"
//                         && xo_massiv[0, 2] == "x"
//                         || xo_massiv[1, 0] == "x"
//                         && xo_massiv[1, 1] == "x"
//                         && xo_massiv[1, 2] == "x"
//                         || xo_massiv[2, 0] == "x"
//                         && xo_massiv[2, 1] == "x"
//                         && xo_massiv[2, 2] == "x"
//                         || xo_massiv[0, 0] == "x"
//                         && xo_massiv[1, 0] == "x"
//                         && xo_massiv[2, 0] == "x"
//                         || xo_massiv[0, 1] == "x"
//                         && xo_massiv[1, 1] == "x"
//                         && xo_massiv[2, 1] == "x"
//                         || xo_massiv[0, 2] == "x"
//                         && xo_massiv[1, 2] == "x"
//                         && xo_massiv[2, 2] == "x"
//                         || xo_massiv[0, 0] == "x"
//                         && xo_massiv[1, 1] == "x"
//                         && xo_massiv[2, 2] == "x"
//                         || xo_massiv[0, 2] == "x"
//                         && xo_massiv[1, 1] == "x"
//                         && xo_massiv[2, 0] == "x")
//                     {
//                         Player1 = "Victory - Player 1";
//                         break;
//                     }
//                     if (xo_massiv[0, 0] == "o"
//                         && xo_massiv[0, 1] == "o"
//                         && xo_massiv[0, 2] == "o"
//                         || xo_massiv[1, 0] == "o"
//                         && xo_massiv[1, 1] == "o"
//                         && xo_massiv[1, 2] == "o"
//                         || xo_massiv[2, 0] == "o"
//                         && xo_massiv[2, 1] == "o"
//                         && xo_massiv[2, 2] == "o"
//                         || xo_massiv[0, 0] == "o"
//                         && xo_massiv[1, 0] == "o"
//                         && xo_massiv[2, 0] == "o"
//                         || xo_massiv[0, 1] == "o"
//                         && xo_massiv[1, 1] == "o"
//                         && xo_massiv[2, 1] == "o"
//                         || xo_massiv[0, 2] == "o"
//                         && xo_massiv[1, 2] == "o"
//                         && xo_massiv[2, 2] == "o"
//                         || xo_massiv[0, 0] == "o"
//                         && xo_massiv[1, 1] == "o"
//                         && xo_massiv[2, 2] == "o"
//                         || xo_massiv[0, 2] == "o"
//                         && xo_massiv[1, 1] == "o"
//                         && xo_massiv[2, 0] == "o")
//                     {
//                         Player2 = "Victory - Player 2";
//                         break;
//                     }
//                 }
//             }
//             Console.WriteLine();
//             Print3dArray(xo_massiv);
//         }
//     }
//     if (Player1 == "Victory - Player 1") Console.WriteLine(Player1);
//     else if (Player2 == "Victory - Player 2") Console.WriteLine(Player2);
//     else Console.WriteLine("Draw!");
// }




// string[,] xo_massiv = CreateXOMassiv(size1, size2);
// Print3dArray(xo_massiv);
// PlayersMoves(xo_massiv);