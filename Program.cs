using UserCase3;

Console.WriteLine("Enter the Email");
string Email = Console.ReadLine();
if(UC3Email.validate(Email))
{
    Console.WriteLine("valid Email");
}
else
{
    Console.WriteLine("invalid Email");
}