using animalfood;

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
    public override Dictionary<int, Animal> CreateAllAnimals()
    {
        Dictionary<int, Animal> animals = new Dictionary<int, Animal>();
        animals[0] = new WoodBison();
        animals[1] = new Elk();
        animals[2] = new Beaver();
        animals[3] = new Rabbit();
        animals[4] = new WhiteTailedDeer();
        animals[5] = new Wolf();
        animals[6] = new ArcticFox();
        animals[7] = new BlackBear();
        animals[8] = new Coyote();
        animals[9] = new Jaguar();
        return animals;
    }
}
