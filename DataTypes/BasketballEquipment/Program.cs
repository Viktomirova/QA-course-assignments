int trainingFee = int.Parse(Console.ReadLine());
double sneackers = trainingFee * 0.6;
double team = sneackers * 0.8;
double basketball = team / 4;
double accessories = basketball /5;
double totalPrice = trainingFee + sneackers + team + basketball + accessories;
Console.WriteLine(totalPrice);