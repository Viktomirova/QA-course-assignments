int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

int sequenceSize = 1;
int BestSequenceSize = 0;
int BestSequenceNumber = 0;

for (int i = 0; i < arr.Length; i++)
{
    int currentNumber = arr[i];

    for (int j = i + 1; j < arr.Length; j++)
    {
        int rightNumber = arr[j];

        if (currentNumber == rightNumber)
        {
            sequenceSize += 1;
        }
        else
        {
            break;
        }
    }

    if (sequenceSize > BestSequenceSize)
    {
        BestSequenceSize = sequenceSize;
        BestSequenceNumber = arr[i];
    }

    sequenceSize = 1;
}

for (int k = 0; k < BestSequenceSize; k++)
{
    Console.Write($"{BestSequenceNumber} ");
}