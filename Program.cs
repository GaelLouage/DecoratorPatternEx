using DecoratorPatternEx.Classes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    ICoffee coffee = new BasicCoffee();
    coffee = new MilkDecorator(coffee);  // Add milk
    coffee = new SugarDecorator(coffee); // Add sugar
    return coffee.Cost();
});

app.Run();
