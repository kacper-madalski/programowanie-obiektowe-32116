namespace Lab2;

internal class Person
{
    public string Name = "";
    public int Age;
    public void IntroduceYourself()
    {
        Console.WriteLine($"I'm {Name} and I'm {Age} years old!");
    }
}

internal static class Program
{
    public static void Main()
    {
        Person person1 = new Person();
        person1.Name = "John";
        person1.Age = 31;

        Person person2 = new Person();
        person2.Name = "Mike";
        person2.Age = 47;

        Person person3 = new Person();
        person3.Name = "Rob";
        person3.Age = 20;

        person1.IntroduceYourself();
        person2.IntroduceYourself();
        person3.IntroduceYourself();
    }
}