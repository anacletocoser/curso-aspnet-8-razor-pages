// O builder � o contrutor da aplica��o, voc� pode configurar todos os servi�os que voc� ir� utilizar
var builder = WebApplication.CreateBuilder(args);


//Essa instru��o levanta todos os servi�os, instancias e classes pra funcionar o Razor Pages
builder.Services.AddRazorPages();




var app = builder.Build();



//app.MapGet("/", () => "Hello World!"); // significa que nesta rota "/" ele chama este m�todo.
//A linha anterior cont�m uma lambda expression, isso significa um m�todo, como se fosse o seguinte:
//string HelloWorld()
//{
//    return "Hello World!";
//}

//Antes do build configura-se os servi�os, e aqui � para o aplicativo funcionar:
app.UseHttpsRedirection();
app.UseRouting();
app.MapRazorPages();


app.Run();