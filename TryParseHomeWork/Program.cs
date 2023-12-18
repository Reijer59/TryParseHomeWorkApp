// Source Code
// Section Common Variables
// Type Conversions trail

using System.Threading.Channels;

Console.WriteLine("\t\t Welcome to the Type Conversion HomeWork assignment.");
Console.WriteLine("Please be so kind to review this app and leave your comments for improvement. ");
Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("\t\t For this assignment I use variables from previous lessons,");
Console.WriteLine("                 and I'm calculating a persons year salary.");
Console.WriteLine();

// Declare variables.
int age;
int maandenGewerkt;  // Months worked.
decimal maandSalaris;  // Months wages.
decimal jaarSalaris;  // Year salary.

// Ask the User for his firstName?
Console.Write("\t What is your firstname: ");
string? firstName = Console.ReadLine();

// Ask the User for his lastName?
Console.Write("\t What is your lastname: ");
string? lastName = Console.ReadLine();

// Ask the User for his age?
Console.Write("\t What is your age: ");
bool isValidInt = int.TryParse(Console.ReadLine(),out age);
Console.WriteLine();
// Ask the User for his salary.
Console.Write("\t What is your monthly income: ");
bool isValidDecimal = decimal.TryParse(Console.ReadLine(), out maandSalaris);
Console.WriteLine($"\t Is this valid? The input is {isValidDecimal}. The montly income is {maandSalaris.ToString("€ 0,##.00")} in euro's.");
Console.WriteLine();

// Ask the User how many months he did work this year?
Console.Write("\t How many months did you work this year: ");
bool isValidInt2 = int.TryParse(Console.ReadLine(), out maandenGewerkt); 
Console.WriteLine($"\t Is this valid? The input is {isValidInt}. You have worked {maandenGewerkt} months this year. ");
Console.WriteLine();

// Get the yearsalary by multipying monthSalary by monthsWorked?
jaarSalaris = maandSalaris * maandenGewerkt;

// Write the result to the Console.
Console.WriteLine($"\t Your firstname is: { firstName}.");
Console.WriteLine($"\t Your lastname is: { lastName}.");
Console.WriteLine();
Console.WriteLine($"\t Your age is: {age.ToString()} year.");
Console.WriteLine();
Console.WriteLine($"\t You urned this year { jaarSalaris.ToString("0,##.00")} euro.");
Console.WriteLine();

// Ask the User to Close the Console?
Console.WriteLine("\t Press ENTER to close the Console.");
Console.ReadLine();
