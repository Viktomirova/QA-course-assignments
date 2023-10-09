int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n; i++)
{
    char vowel = char.Parse(Console.ReadLine());
	switch (vowel)
	{
		case 'a':
			sum++;
			break;
		case 'e':
			sum += 2;
			break;
		case 'i':
			sum += 3;
			break;
		case 'o':
			sum += 4;
			break;
		case 'u':
			sum += 5;
			break;
	}
}
Console.WriteLine(sum);