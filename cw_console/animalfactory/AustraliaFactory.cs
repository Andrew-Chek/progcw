using animalfood;

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
    public override Dictionary<int, Animal> CreateAllAnimals()
    {
        Dictionary<int, Animal> animals = new Dictionary<int, Animal>();
        animals[0] = new Kangaroo();
        animals[1] = new Possum();
        animals[2] = new Thylacine();
        animals[3] = new TasmanianDevil();
        return animals;
    }
}
