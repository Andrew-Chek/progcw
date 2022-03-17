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
}
