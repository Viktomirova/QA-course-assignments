int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
bool isValid = true;
if (n1 + n2 <= n3)
  isValid = false;
else if (n1 + n3 <= n2)
  isValid = false;
else if (n2 + n3 <= n1)
    isValid = false;

if (isValid)
    Console.WriteLine("Valid Triangle");
else Console.WriteLine("Invalid Triangle");
