using System;

class Animal<T>
{
    private T data;

    public Animal(T data)
    {
        this.data = data;
    }

    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // create Animal object with string, string, bool, bool, and int
        Animal<Tuple<string, string, bool, bool, int>> animal = new Animal<Tuple<string, string, bool, bool, int>>(
            new Tuple<string, string, bool, bool, int>("lion", "grasslands", false, false, 15));

        // print out values using getAnimal method
        Tuple<string, string, bool, bool, int> animalData = animal.getAnimal();
        Console.WriteLine("Name: {0}", animalData.Item1);
        Console.WriteLine("Habitat: {0}", animalData.Item2);
        Console.WriteLine("Endangered: {0}", animalData.Item3);
        Console.WriteLine("Extinct: {0}", animalData.Item4);
        Console.WriteLine("Average Lifespan: {0}", animalData.Item5);
    }
}
