public class UserBuilder
{
    private User _user = new User();

    public UserBuilder SetName(string name)
    {
        _user.Name = name;
        return this;
    }

    public UserBuilder SetEmail(string email)
    {
        _user.Email = email;
        return this;
    }

    public UserBuilder SetPhoneNumber(string phoneNumber)
    {
        _user.PhoneNumber = phoneNumber;
        return this;
    }

    public User Build()
    {
        return _user;
    }
}