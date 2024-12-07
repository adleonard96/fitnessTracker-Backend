namespace FitnessTracker.Models;

public class User {
    public string? Id {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public UserAttributes? UserAttributes {get; set;}

    public User(string id, string firstName, string lastName, UserAttributes userAttributes)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        UserAttributes = userAttributes;
    }

    public User(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}