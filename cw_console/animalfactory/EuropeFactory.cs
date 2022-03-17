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
}
