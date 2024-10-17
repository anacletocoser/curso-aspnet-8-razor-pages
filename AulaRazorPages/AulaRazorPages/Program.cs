// O builder é o contrutor da aplicação, você pode configurar todos os serviços que você irá utilizar
var builder = WebApplication.CreateBuilder(args);


//Essa instrução levanta todos os serviços, instancias e classes pra funcionar o Razor Pages
builder.Services.AddRazorPages();




var app = builder.Build();



//app.MapGet("/", () => "Hello World!"); // significa que nesta rota "/" ele chama este método.
//A linha anterior contém uma lambda expression, isso significa um método, como se fosse o seguinte:
//string HelloWorld()
//{
//    return "Hello World!";
//}

//Antes do build configura-se os serviços, e aqui é para o aplicativo funcionar:
app.UseHttpsRedirection();
app.UseRouting();
app.MapRazorPages();


app.Run();