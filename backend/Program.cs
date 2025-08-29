//1)
var builder = WebApplication.CreateBuilder(args);

//2)
// we may need to configure builder before building  (as an example, add controllers etc.)

//3)
var app = builder.Build();
// 4)
// MAP. ENDPOINT <- > metodi()
app.MapGet("/", () => "Hello NET24S!"); //  using "anonomous function
app.MapGet("hellous/", GetHello);

// 5). after run .... program will stop here to wait for Get/POST/UPDATE calls
app.Run();
//--------------------------------------------------

Console.WriteLine("This should never happen ... (is impossible, should be at least)");
// we will never get here..

// what about these??
string GetHello()
{
	var helloFolder = new DirectoryInfo(Directory.GetCurrentDirectory());
	var hellopath = Path.Combine(helloFolder.FullName, "hello.txt");

	// check that file exists, otherwise it may result into HTTP ERROR CODE 500

	// print to console absolute path (fullname)
	Console.WriteLine($"Reading hello from :{hellopath}");

	var message = File.ReadAllText(hellopath);
	return "Read from FILE:\n\n" + message;

}

