using animalfood;

namespace animalfactory;

class EuropeFactory : ContinentFactory
{
    public override Herbivore[] CreateHerbivores()
    {
        return new Herbivore[2]
            {new Horse(), new EuropeanBison()};
    }
    public override Carnivore[] CreateCarnivores()
    {
        return new Carnivore[2]
            {new BrownBear(), new GoldenJackal()};
    }
    public override Dictionary<int, Animal> CreateAllAnimals()
    {
        Dictionary<int, Animal> animals = new Dictionary<int, Animal>();
        animals[0] = new Horse();
        animals[1] = new EuropeanBison();
        animals[2] = new BrownBear();
        animals[3] = new GoldenJackal();
        return animals;
    }
}
