Decorator Pattern Example in C#

This repository demonstrates the use of the Decorator design pattern in C# to enhance the functionality of a basic coffee object by adding different ingredients such as milk and sugar. The example is implemented using ASP.NET Core, where the final cost of the coffee is calculated and returned via a simple API endpoint.
Overview

The Decorator pattern allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class. In this example, we have a basic coffee class that can be decorated with additional features (like milk and sugar) without modifying the base class.
Classes

    ICoffee: An interface that defines the Cost method, which returns the cost of the coffee.
    BasicCoffee: A concrete implementation of ICoffee representing a basic coffee with a fixed base price.
    CoffeeDecorator: An abstract class implementing ICoffee, used as the base class for all coffee decorators. It wraps an ICoffee instance and allows derived classes to add additional costs.
    MilkDecorator: A concrete decorator class that adds the cost of milk to the coffee.
    SugarDecorator: A concrete decorator class that adds the cost of sugar to the coffee.

Code Example

The following example demonstrates how to use the classes to create a coffee with milk and sugar and get its final cost:

csharp

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

In this example:

    A BasicCoffee instance is created with a base cost.
    The coffee is then wrapped with a MilkDecorator, adding the cost of milk.
    Finally, the coffee is wrapped with a SugarDecorator, adding the cost of sugar.
    The final cost is calculated and returned by the API.

Running the Application

    Clone the repository:

    bash

git clone https://github.com/yourusername/decorator-pattern-example.git
cd decorator-pattern-example

Build the project:

bash

dotnet build

Run the application:

bash

    dotnet run

    Access the API: Open your browser and navigate to http://localhost:5000/ to see the final cost of the coffee with milk and sugar.

Key Takeaways

    The Decorator pattern is useful for adding responsibilities to objects without modifying their class.
    It provides a flexible alternative to subclassing for extending functionality.
