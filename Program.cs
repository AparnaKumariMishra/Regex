using UserCase4;

Console.WriteLine("Enter the MobileNumber");
string Number = Console.ReadLine();
if (UC4MobileNo.validate(Number))
{
    Console.WriteLine("valid Number");
}
else
{
    Console.WriteLine("invalid Number");
}
