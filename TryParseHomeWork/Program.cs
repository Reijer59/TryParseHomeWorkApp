// Source Code
// Section Common Variables
// Type Conversions trail

using System.Threading.Channels;

Console.WriteLine("           Welcome to the Type Conversion HomeWork assignment.");
Console.WriteLine("Please be so kind to review this app and leave your comments for improvement. ");
Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("        For this assignment I use variables from previous lessons,");
Console.Witeline(       "                 and I'm calculating a persons year salary.");
Console.WriteLine();

// Declare variables.
int age;
int maandenGewerkt;  // Months worked.
decimal maandSalaris;  // Months wages.
decimal jaarSalaris;  // Year salary.

// Ask the User for his firstName?
Console.Write("     What is your firstname: ");
string? firstName = Console.ReadLine();

// Ask the User for his lastName?
Console.Write("     What is your lastname: ");
string? lastName = Console.ReadLine();

// Ask the User for his age?
Console.Write("     What is your age: ");
bool isValidInt = int.TryParse(Console.ReadLine(),out age);
Console.WriteLine();
// Ask the User for his salary.
Console.Write("     What is your monthly income: ");
bool isValidDecimal = decimal.TryParse(Console.ReadLine(), out maandSalaris);
Console.WriteLine($"     Is this valid? The input is {isValidDecimal}. The montly income is {maandSalaris.ToString("0,##.00")} in euro's.");
Console.WriteLine();

// Ask the User how many months he did work this year?
Console.Write("     How many months did you work this year: ");
bool isValidInt2 = int.TryParse(Console.ReadLine(), out maandenGewerkt);
Console.WriteLine($"     Is this valid? The input is {isValidInt}. You have worked {maandenGewerkt} months this year. ");
Console.WriteLine();

// Get the yearsalary by multipying monthSalary by monthsWorked?
jaarSalaris = maandSalaris * maandenGewerkt;

// Write the result to the Console.
Console.WriteLine($"     Your firstname is: { firstName}.");
Console.WriteLine($"     Your lastname is: { lastName}.");
Console.WriteLine();
Console.WriteLine($"     Your age is: {age.ToString()} year.");
Console.WriteLine();
Console.WriteLine($"     You urned this year { jaarSalaris.ToString("0,##.00")} euro.");
Console.WriteLine();

// Ask the User to Close the Console?
Console.WriteLine("     Press ENTER to close the Console.");
Console.ReadLine();
