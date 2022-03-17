namespace animalfactory;

class AustraliaFactory : ContinentFactory
{
    public override Herbivore[] CreateHerbivores()
    {
        return new Herbivore[2]
            {new Kangaroo(), new Possum()};
    }
    public override Carnivore[] CreateCarnivores()
    {
        return new Carnivore[2]
            {new Thylacine(), new TasmanianDevil()};
    }
}
