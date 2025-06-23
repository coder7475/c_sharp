// 1D array
int[] arr = new int[10];

for (int i = 0; i < 10; i++) {
  arr[i] = i + 100;
  // Console.WriteLine(arr[i]);
}

// Length
//Console.WriteLine("Length: {0}", arr.Length);

// 2D array - an array of arrays
// array[10][20]
int[][] array = new int[10][];

for (int i = 0; i < 10; i++) {
  array[i] = new int[20];
}

for (int i = 0; i < 10; i++) {
  for (int j = 0; j < 20; j++) {
    array[i][j] = i * j;
  }
}

for (int i = 0; i < 10; i++) {
  for (int j = 0; j < 20; j++) {
    Console.Write(array[i][j] + " ");
  }
Console.WriteLine("");
}


