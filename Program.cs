
using UserCase5;

Console.WriteLine("Enter the Password");
string password = Console.ReadLine();
if (UC5.validate(password))
{
    Console.WriteLine("valid password");
}
else
{
    Console.WriteLine("please enter valid password");
}
