using Leonardo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
using (var dataContext = new FibonacciDataContext())
{
	app.MapGet("/Fibonacci",
		async () => await new Fibonacci(dataContext).RunAsync(args));
	app.Run();
}