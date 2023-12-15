using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Course.Protobuf.Test;

Console.WriteLine("Welcome!");
var emp = new Employee();
emp.FirstName = "Anurag";
emp.LastName = "Asthana";
emp.IsRetired = false;
var date = new DateTime(1990, 7, 14);
date = DateTime.SpecifyKind(date, DateTimeKind.Utc);
emp.BirthDate = Timestamp.FromDateTime(date);
emp.MaritalStatus = Employee.Types.MaritalStatus.Single;
emp.PreviousEmployers.Add("DC");
emp.PreviousEmployers.Add("ED");

emp.CurrentAddress = new Address
{
    City = "Pune",
    HouseNumber = 43,
    StreetName = "PS",
    ZipCode = "123"
};

using (var output = File.Create("emp.dat"))
{
    emp.WriteTo(output);
}

Employee empNew;

using (var input = File.OpenRead("emp.dat"))
{
    empNew = Employee.Parser.ParseFrom(input);
}

Console.ReadLine();