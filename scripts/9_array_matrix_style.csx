// 2D array in matrix style
int [,] array = new int[10, 20];


for (int i = 0; i < 10; i++) {
  for (int j = 0; j < 20; j++) {
    array[i, j] = i * j;
  }
}

for (int i = 0; i < 10; i++) {
  for (int j = 0; j < 20; j++) {
    Console.Write(array[i, j] + " ");
  }
Console.WriteLine("");
}


