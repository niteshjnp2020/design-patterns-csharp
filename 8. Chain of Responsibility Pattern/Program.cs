// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var managerHandler = new ManagerHandler();
var teamLeadHandler = new TeamLeadHandler();
var departmentHeadHandler = new DepartmentHeadHandler();
var directorHandler = new DirectorHandler();
managerHandler.SetNext(teamLeadHandler);
teamLeadHandler.SetNext(departmentHeadHandler);
departmentHeadHandler.SetNext(directorHandler);
var expenseRequest1 = new ExpenseRequest { Amount = 75000 };
managerHandler.Handle(expenseRequest1);