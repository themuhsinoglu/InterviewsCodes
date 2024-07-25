using System.Reflection;
using Reflection;

Type type = typeof(Person);

        // Tipin tam adını yazdırma
        Console.WriteLine("Class Name: " + type.Name);

        // Özellikleri listeleme
        PropertyInfo[] properties = type.GetProperties();
        foreach (var property in properties)
        {
            Console.WriteLine("Property: " + property.Name + ", Type: " + property.PropertyType.Name);
        }

        // Metotları listelemeÍ
        MethodInfo[] methods = type.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine("Method: " + method.Name);
        }

        // Dinamik olarak nesne oluşturma ve metod çağırma
        object? personInstance = Activator.CreateInstance(type);
        MethodInfo? sayHelloMethod = type.GetMethod("SayHello");
        type.GetProperty("Name")!.SetValue(personInstance, "John Doe");
        sayHelloMethod!.Invoke(personInstance, null);

