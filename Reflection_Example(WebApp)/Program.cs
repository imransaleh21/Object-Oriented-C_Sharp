using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text;
using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// this middleware is an example of how to use reflection to get types and properties from an assembly
app.Use(async (context, next) =>
{
    string path = "G:\\ASP.NET Core\\BasicWebApps\\Assignment_for_Learning\\4_Bank_Apps_Using_Controller\\bin\\Debug\\net8.0\\4_Bank_Apps_Using_Controller.dll";
    Assembly aase = Assembly.LoadFrom(path);
    var types = aase.GetTypes();

    var output = new StringBuilder();

    foreach (var type in types)
    {
        output.AppendLine($"Type: {type.Name}");

        var properties = type.GetProperties();
        foreach (var property in properties)
        {
            output.AppendLine($"Property: {property.Name}, Type: {property.PropertyType}");
        }
    }
    await context.Response.WriteAsync(output.ToString()); 
    await next(context);
});

app.Run(async (context) => {
    await context.Response.WriteAsync("\n Program Terminate");
});
app.Run();
