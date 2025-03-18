class PoliceMan : Person
{

    private string _weapon;

    public PoliceMan (string weapon, string firstName, string lastName, int age, int height)
    : base (firstName, lastName, age, height)
    {
        _weapon = weapon;
    }

    public string DisplayPoliceManInfo()
    {
        return $"Weapon: {_weapon}\n{DisplayPersoninfo()}";
    }
}