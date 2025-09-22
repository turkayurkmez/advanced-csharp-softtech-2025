// See https://aka.ms/new-console-template for more information
using Variance;

Console.WriteLine("Hello, World!");

var reportService = new ReportService();
var managerReader = new ManagerReader();
var directorReader = new DirectorReader();

//eğer out olmasaydı: IDataReader<Manager> ile IDataReader<Director> arasında doğrudan ilişki kuramayacaktı.
reportService.GenerateReport(managerReader);
reportService.GenerateReport(directorReader);

var manager = new Manager { Name = "Türkay", TeamSize = 8 };
var validator = new EmployeeValidator();
ManagerService managerService = new ManagerService();

managerService.ProcessManager(manager, validator);
