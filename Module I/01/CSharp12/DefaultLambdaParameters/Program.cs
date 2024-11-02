var lambdaDemo = (string name = "User") => Console.WriteLine($"Hello {name}");

lambdaDemo();
lambdaDemo("C# 12.0");

Console.WriteLine(lambdaDemo.Method.GetParameters()[0].DefaultValue);
