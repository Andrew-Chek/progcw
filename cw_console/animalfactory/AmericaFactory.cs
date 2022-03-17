namespace animalfactory;

class AmericaFactory : ContinentFactory
{
    public override Herbivore[] CreateHerbivores()
    {
        return new Herbivore[5]
            {new WoodBison(), new Elk(), new Beaver(),
                new Rabbit(), new WhiteTailedDeer()};
    }
    public override Carnivore[] CreateCarnivores()
    {
        return new Carnivore[5]
            {new Wolf(), new ArcticFox(), 
                new BlackBear(), new Coyote(), new Jaguar()};
    }
}
