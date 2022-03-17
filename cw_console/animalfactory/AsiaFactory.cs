namespace animalfactory;

class AsiaFactory : ContinentFactory
{
    public override Herbivore[] CreateHerbivores()
    {
        return new Herbivore[2]
            {new Gibbon(), new Rhino()};
    }
    public override Carnivore[] CreateCarnivores()
    {
        return new Carnivore[2]
            {new Tiger(), new Lynx()};
    }
}
