// O builder � o contrutor da aplica��o, voc� pode configurar todos os servi�os que voc� ir� utilizar
using AulaRazorPages.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//Essa instru��o levanta todos os servi�os, instancias e classes pra funcionar o Razor Pages
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MoviesContext>(option =>
    option.UseInMemoryDatabase("MyFirstAppDB"));


var app = builder.Build();

app.UseStatusCodePagesWithReExecute("/errors/{0}"); //Recomend�vel utilizar este m�todo
//app.UseStatusCodePagesWithRedirects("/errors/{0}"); //N�o � recomend�vel utilizar, por quest�es de indexa��o nos buscadores, como google e bing

//app.MapGet("/", () => "Hello World!"); // significa que nesta rota "/" ele chama este m�todo.
//A linha anterior cont�m uma lambda expression, isso significa um m�todo, como se fosse o seguinte:
//string HelloWorld()
//{
//    return "Hello World!";
//}

//Antes do build configura-se os servi�os, e aqui � para o aplicativo funcionar:
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();


app.Run();