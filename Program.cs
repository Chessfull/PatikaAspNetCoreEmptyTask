var builder = WebApplication.CreateBuilder(args);

// ▼ Task 1- Adds MVC Services and able to use views and controllers ▼
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ▼ Task 2 - Able to use static files such as css, js, img etc. ▼
app.UseStaticFiles();

// ▼ Task 3 - Activating routing mechanism ▼
app.UseRouting();

// ▼ Task 4 -  Defining default route pattern
app.MapControllerRoute( // -> 
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseHttpsRedirection(); // * -> Directing all http request to https so increasing security as well


app.UseAuthorization(); // * -> Authorization activated

//app.MapGet("/", () => "Hello World!");

app.Run();

/* 

Controller: Handles HTTP requests and returns responses. Its a bridge between Models and Views.

Action : Methods in Controller that provide spesific HTTP requests. -> public IActionResult Index()
 
Model: Building data structre and logic of application. We will manage data operations here.

View: Visual part of application. Layout and display of data.

Razor: Its the way combine usable C# codes and HTML in view files. -> .cshtml -> @CSharpCodes with HTML

RazorView: Output of razor codes. -> .cshtml

wwwroot: Folder for static files like js, css, images etc.

builder.Build(): Its the instance for web application that represent HTTP.

app.Run(): Starting method of application and available for http requests.

 */

