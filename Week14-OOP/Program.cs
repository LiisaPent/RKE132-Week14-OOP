Console.WriteLine("Name your dog:");
string myDogsName = Console.ReadLine();

Dog myDog = new Dog(myDogsName);
Dog neighboursDog = new Dog("good girl");

Console.WriteLine($"My dog's name is {myDog.Name}.");
Console.WriteLine($"My neighbour's dog's name is {neighboursDog.Name}");

myDog.Rename("bad boy");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();
class Dog
{
    private string _name;  // field
    private int _levelOfHappiness;

    // constructor
    public Dog(string name) // name - let's the user name their dog 
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    // getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness;}
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"My dog has been renamed to: {newName}.");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}
