// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var UserBuilder = new UserBuilder();
var user = UserBuilder.SetName("John Doe")
                      .SetEmail("john.doe@example.com")
                      .SetPhoneNumber("123-456-7890")
                      .Build();

Console.WriteLine($"User Details: Name={user.Name}, Email={user.Email}, Phone={user.PhoneNumber}");