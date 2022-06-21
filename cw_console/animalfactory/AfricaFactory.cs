using animalfood;

namespace animalfactory;

public class AfricaFactory : ContinentFactory
{
    public override Herbivore[] CreateHerbivores()
    {
        return new Herbivore[5]
            {new Wildebeest(), new Zebra(), new Giraffe(),
                new Hippopotamus(), new Elephant()};
    }
    public override Carnivore[] CreateCarnivores()
    {
        return new Carnivore[5]
            {new Lion(), new Leopard(), 
                new Panthera(), new Hyena(), new Cheetah()};
    }

    public override Dictionary<int, Animal> CreateAllAnimals()
    {
        Dictionary<int, Animal> animals = new Dictionary<int, Animal>();
        animals[0] = new Wildebeest();
        animals[1] = new Zebra();
        animals[2] = new Giraffe();
        animals[3] = new Hippopotamus();
        animals[4] = new Elephant();
        animals[5] = new Lion();
        animals[6] = new Leopard();
        animals[7] = new Panthera();
        animals[8] = new Hyena();
        animals[9] = new Cheetah();
        return animals;
    }
}
