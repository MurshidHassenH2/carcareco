// See https://aka.ms/new-console-template for more information
using BCrypt.Net;

var userPassword = "1234@hash"; // password entered by user
var storedHash = "$2a$11$zsTS62pGn5Cfca4CgqRJxebx45je/3nJj.puxIArFwtAjHew67m6i"; // hash stored in DB
bool isValid = BCrypt.Net.BCrypt.Verify(userPassword, storedHash);

if (isValid)
{
    Console.WriteLine("Password is correct!");
}
else
{
    Console.WriteLine("Invalid password!");
}

var employeeId = Guid.NewGuid();

Console.WriteLine("EmployeeID "+ employeeId);
