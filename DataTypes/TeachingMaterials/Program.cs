double pensPackagePrice = 5.80;
double markersPackagePrice = 7.20;
double boardCleanerPerLiterPrice = 1.20;
int numberOfPensPackages = int.Parse(Console.ReadLine());
int numberOfMarkersPackages = int.Parse(Console.ReadLine());
int litersOfBoardCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());
double price = numberOfPensPackages * pensPackagePrice 
    + numberOfMarkersPackages * markersPackagePrice 
    + litersOfBoardCleaner * boardCleanerPerLiterPrice;
double totalPrice = price - (price * discount * 0.01);
Console.WriteLine(totalPrice);