// Source Code
// Section Common Variables
// Type Conversions trail

Console.WriteLine("           Welcome to the Type Conversion HomeWork assignment.");
Console.WriteLine("Please be so kind to review this app and leave your comments for improvement. ");
Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("        For this assignment I try to calculate a persons year salary.");
Console.WriteLine();

// Declare variables.
int maandenGewerkt;
decimal maandSalaris;
decimal jaarSalaris;

// Ask the user for his salary.
Console.Write("What is your monthly income: ");
bool isValidDecimal = decimal.TryParse(Console.ReadLine(), out maandSalaris);
Console.WriteLine($"Is this valid? The input is {isValidDecimal}. The montly income is {maandSalaris.ToString("0,##.00")} in euro's.");
Console.WriteLine();

// Ask the user how many months he did work this year.
Console.Write("How many months did you work this year: ");
bool isValidInt = int.TryParse(Console.ReadLine(), out maandenGewerkt);
Console.WriteLine($"Is this valid? The input is {isValidInt}. You have worked {maandenGewerkt} months this year. ");
Console.WriteLine();

// Get the yearsalary by multipying monthSalary by monthsWorked.
jaarSalaris = maandSalaris * maandenGewerkt;

// Write the result to the Console.
Console.WriteLine($"You urned this year { jaarSalaris.ToString("0,##.00")} euro.");
Console.WriteLine();

// Ask the user to Close the Console.
Console.WriteLine("Press ENTER to close the Console.");
Console.ReadLine();
