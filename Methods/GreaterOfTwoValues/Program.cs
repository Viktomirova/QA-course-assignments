string typeOfValues = Console.ReadLine();
string value1 = Console.ReadLine();
string value2 = Console.ReadLine();

CompareTwoValues(typeOfValues, value1, value2);

static void CompareTwoValues(string type, string a, string b)
{
    switch (type)
    {
        case "int":
            int int1 = int.Parse(a);
            int int2 = int.Parse(b);
            if (int1 > int2) Console.WriteLine(int1);
            else Console.WriteLine(int2);
            break;
        case "char":
            char ch1 = char.Parse(a);
            char ch2 = char.Parse(b);
            if (ch1 > ch2) Console.WriteLine(ch1);
            else Console.WriteLine(ch2);
            break;
        case "string":
            int sumA = 0;
            int sumB = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sumA += a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                sumB += b[i];
            }
            if (sumA > sumB || a.Length > b.Length) Console.WriteLine(a);
            else Console.WriteLine(b);
            break;
    }
}