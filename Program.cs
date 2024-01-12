// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("This Current Time is" + DateTime.Now);
Console.WriteLine($"Current Date: {DateTime.Now.ToString("yyyy-MM-dd")}\nDays Until Next Christmas: {(new DateTime(DateTime.Now.Year, 12, 25) - DateTime.Now).Days}");
