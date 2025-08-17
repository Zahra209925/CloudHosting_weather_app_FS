var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); //  using "anonomous function
app.MapGet("hellous/", GetHello);

app.Run();

string GetHello()
{
	var helloFolder = new DirectoryInfo(Directory.GetCurrentDirectory());
	var hellopath = Path.Combine(helloFolder.FullName, "hello.txt");

	// print to console absolute path (fullname)

	Console.WriteLine($"reading hello from :{hellopath}");

	var message = File.ReadAllText(hellopath);
	return "Read from FILE:\n\n" + message;

}