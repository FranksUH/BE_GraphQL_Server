using GraphQL_Example;

var builder = WebApplication.CreateBuilder(args);
builder.AddRequiredServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGraphQL("/graphql");
app.Run();