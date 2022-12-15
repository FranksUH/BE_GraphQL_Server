using BLL.Definitions;
using DAL.Definitions;
using DAL.Entities;
using GraphQL_Example;
using Microsoft.AspNetCore.OData.Query;

var builder = WebApplication.CreateBuilder(args);
builder.AddRequiredServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseWebSockets();
app.MapGraphQL("/graphql");

app.MapControllers();
app.Run();