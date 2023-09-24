int examH = int.Parse(Console.ReadLine());
int examM = int.Parse(Console.ReadLine());
int arrH = int.Parse(Console.ReadLine());
int arrM = int.Parse(Console.ReadLine());

int examTotalM = examH * 60 + examM;
int arrTotalM = arrH * 60 + arrM;

string status;   // "Late" or "On time"
string comparison; // "before" or "after"

int diff = examTotalM - arrTotalM;

if (diff >= 0 && diff <= 30)
{
    status = "On time";
    comparison = "before";
}
else if (diff < 0)
{
    status = "Late";
    comparison = "after";
    diff = -diff;
}
else
{
    status = "Early";
    comparison = "before";
}

int compH = diff / 60;
int compM = diff % 60;

Console.WriteLine(status);

if (compH > 0)
    Console.WriteLine($"{compH}:{compM:D2} hours {comparison} the start");
else if(compM > 0)
    Console.WriteLine($"{compM} minutes {comparison} the start");

