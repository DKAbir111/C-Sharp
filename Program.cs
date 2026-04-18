// var builder = WebApplication.CreateBuilder(args);
// // Swagger services
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.MapGet("/", () =>
// {
//     return "Hello Server is running successfully...";
// });

// app.MapGet("/hello", () =>
// {
//     var response = new
//     {
//         message = "Successfully called the /hello endpoint",
//         success = true
//     };
//     return response;
// });


// var products = new List<Product>
// {
//     new Product(1, "Laptop", 999.99m),
//     new Product(2, "Smartphone", 499.99m),
//     new Product(3, "Headphones", 199.99m)

// };

// app.MapGet("/products", () =>
// {
//     return Results.Ok(products);
// });

// app.Run();
// var oop = new OOP();
// oop.Run();

// public record Product(int Id, string Name, decimal Price);


// class Person
// {
//     public string name;
//     public int age;

// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         var person = new Person();
//         person.name = "John Corner";
//         person.age = 30;
//         Console.WriteLine($"Name:{person.name}, Age: {person.age}");
//     }
// }


//OOP- Object Oriented Programming

class Person
{

    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name:{name}, Age: {age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John Corner", 30);
        person.Display();
    }
}

