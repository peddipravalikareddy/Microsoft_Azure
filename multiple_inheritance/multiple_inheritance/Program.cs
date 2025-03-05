using multiple_inheritance;

using multiple_inheritance.interfaces;

Developer developer = new Developer("Tina",23,101);
developer.DoWork();

Tester tester = new Tester();
tester.DoWork();

Manager manager = new Manager("Ramesh", 45, 202);
manager.DisplayInfo();
manager.DoWork();
manager.Manage();