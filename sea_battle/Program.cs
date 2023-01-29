// int size_player1 = 11;
// int size_player11 = 11;
// int size_player2 = 11;
// int size_player22 = 11;

// string[,] Create2dArray(int size_player1, int size_player11){
//     string[,] player1Matrix = new string [size_player1, size_player11];
//     for(int i = 0; i < size_player1; i++){
//         for(int j = 0; j < size_player11; j++){
//             player1Matrix[i, 0] = $"{i} "; 
//             player1Matrix[0, j] = $"{j}";
//             if(player1Matrix[i, j] != $"{i} "){
//                 player1Matrix[i, j] = ".";
//             }
//         }
//     }
//     return player1Matrix;
// }

// void PrintMatrix(string[,] player1Matrix){
//     for(int i = 0; i < player1Matrix.GetLength(0); i++){
//         for(int j = 0; j < player1Matrix.GetLength(1); j++){
//             Console.Write($"{player1Matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void PlayersMoves(string[,] player1Matrix){

//     Console.Write("x1: ");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("x2: ");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     if(x1 > 0 && x1 <=10){
//         player1Matrix[x1, x2] = "[]";
//         PrintMatrix(player1Matrix);
//     }
//     for(int i = 1; i < player1Matrix.GetLength(0); i++){
//         for(int j = 1; j < player1Matrix.GetLength(1); j++){

//         }
//     }
// }


// string[,] player1Matrix = Create2dArray(size_player1, size_player11);
// string[,] player2Matrix = Create2dArray(size_player2, size_player22);
// PrintMatrix(player1Matrix);
// PrintMatrix(player2Matrix);
// PlayersMoves(player1Matrix);
