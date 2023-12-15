int[] numbers = new int[]{ 64, 24, 10, 42, 24, 58};
Console.WriteLine(numbers.First());
Console.WriteLine(numbers[3] >= numbers[1]); // True
Console.WriteLine(numbers[5] == numbers[2]); // False
Console.WriteLine(numbers[1] + numbers[4]); // 48
Console.WriteLine(numbers[6] - numbers[3]); // IndexOutOfRangeException