using animalfood;

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
    public override Dictionary<int, Animal> CreateAllAnimals()
    {
        Dictionary<int, Animal> animals = new Dictionary<int, Animal>();
        animals[0] = new Gibbon();
        animals[1] = new Rhino();
        animals[2] = new Tiger();
        animals[3] = new Lynx();
        return animals;
    }
}
