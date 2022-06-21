using animalfood;

namespace animalfactory;

public abstract class ContinentFactory
{
    public abstract Herbivore[] CreateHerbivores();
    public abstract Carnivore[] CreateCarnivores();
    public abstract Dictionary<int, Animal> CreateAllAnimals();
}
