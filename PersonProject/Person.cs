class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _height;

    public Person (string firstName, string lastName, int age, int height)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _height= height;
    }

    public string DisplayPersoninfo()
    {
        return $"First name: {_firstName}\nLast name: {_lastName}\nAge: {_age}\nHeight: {_height}";
    }

}