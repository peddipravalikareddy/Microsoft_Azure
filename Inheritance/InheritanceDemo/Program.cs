using InheritanceDemo;

Developer dev = new Developer("John", 30, 101);
dev.DoWork();

Tester test = new Tester();
test.DoWork();

Manager man = new Manager("Ramesh", 45, 202);
man.DisplayInfo();
man.DoWork();
man.Manage();