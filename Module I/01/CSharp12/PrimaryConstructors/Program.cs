using PrimaryConstructors;

Employee employee = new Employee(30, "John Doe", 1000.00m);
Employee otherEmployee = new Employee(25, "Jane Doe", 2000.00m, new[] { "555-1234", "555-5678" });

employee.DsplayTelephones();
otherEmployee.DsplayTelephones();