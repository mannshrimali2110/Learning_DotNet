using System;

Console.WriteLine("Properties Example");

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    private string _email;
    public string Email
    {
        get { return _email; }
        set
        {
            if (value.Contains("@"))
                _email = value;
            else
                _email = "Invalid Email";
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name + ", Age " + Age + ", Email: " + Email);
    }
}

Person mann = new Person();
mann.Name = "Mann Shrimali";
mann.Age = 21;
mann.Email = "mann@example.com";
mann.ShowInfo();

Person amit = new Person();
amit.Name = "Rohit Ezu";
amit.Age = 23;
amit.Email = "some__invalid-email";
amit.ShowInfo();
