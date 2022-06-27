namespace animalfactory;
using animalfood;
//Carnivores from America
public class ArcticFox : Carnivore
{
    public ArcticFox()
    {
        this.name = "arctic fox";
        this.continent = "America";
    }

    public override string GetInterestingFact()
    {
        return "Arctic foxes are monogamous, meaning they mate for life.";
    }

    public override void ImplementFood(Food food)
    {
        if(food.product == "meat" || food.product == "fish")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class BlackBear : Carnivore
{
    public BlackBear()
    {
        this.name = "black bear";
        this.continent = "America";
    }
    public override string GetInterestingFact()
    {
        return "Black bear cubs weigh less than one pound at birth. They gain 20 to 30 pounds in three months. "+ 
        "Excellent swimmers, black bears can paddle at least a mile and a half in freshwater.";
    }

    public override void ImplementFood(Food food)
    {
        this.food = food;
    }
}
public class Wolf : Carnivore
{
    public Wolf()
    {
        this.name = "wolf";
        this.continent = "America";
    }
    public override string GetInterestingFact()
    {
        return "Length of life: up to 13 years in wild. (usually 6 to 8 years";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class Jaguar : Carnivore
{
    public Jaguar()
    {
        this.name = "jaguar";
        this.continent = "America";
    }
    public override string GetInterestingFact()
    {
        return "The jaguar is the third biggest cat in the world - after the tiger and the lion - and is the largest" + 
        " cat in the Americas. They can grow up to 170cm long, not including their impressive tails which can be up to 80cm.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat" || food.product == "fish")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class Coyote : Carnivore
{
    public Coyote()
    {
        this.name = "coyote";
        this.continent = "America";
    }
    public override string GetInterestingFact()
    {
        return "Coyotes are monogamous animals - meaning they mate for life. Coyotes can breed with wolves or domestic dogs.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat" || food.product == "fish" 
            || food.product == "fruits" || food.product == "vegetables")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
//Herbivores from America
public class Elk : Herbivore
{
    public Elk()
    {
        this.name = "elk";
        this.continent = "America";
    }
    public override string GetInterestingFact()
    {
        return "Elk Are Often Mistaken for Moose. They're the Loudest Members of the Deer Family. Only Males Have Antlers.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "hay" || food.product == "vegetables" 
            || food.product == "fruits" || food.product == "crops" || food.product == "bread")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class Beaver : Herbivore
{
    public Beaver()
    {
        this.name = "beaver";
        this.continent = "America";
    }
    public override string GetInterestingFact()
    {
        return "Beaver teeth are orange.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "tree bark" || food.product == "crops")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class Rabbit : Herbivore
{
    public Rabbit()
    {
        this.name = "rabbit";
        this.continent = "America";
    }
    public override string GetInterestingFact()
    {
        return "A rabbit's teeth never stop growing!";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "crops" || food.product == "hay")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class WhiteTailedDeer : Herbivore
{
    public WhiteTailedDeer()
    {
        this.name = "white-tailed deer";
        this.continent = "America";
    }
    public override string GetInterestingFact()
    {
        return "White-tailed deer are browse for food at dawn and dusk. White-tailed deer have good eyesight and hearing.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "hay" || food.product == "vegetables" 
            || food.product == "fruits" || food.product == "crops" || food.product == "bread")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class WoodBison : Herbivore
{
    public WoodBison()
    {
        this.name = "wood bison";
        this.continent = "America";
    }
    public override string GetInterestingFact()
    {
        return "Wood bison are the largest native terrestrial land mammal in North America.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "hay" || food.product == "vegetables" || food.product == "crops")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
//Carnivores from Africa
public class Lion : Carnivore
{
    public Lion()
    {
        this.name = "lion";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "Lions can get their water from plants";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class Leopard : Carnivore
{
    public Leopard()
    {
        this.name = "leopard";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "Leopards are fast felines and can run at up to 58km/h!";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class Panthera : Carnivore
{
    public Panthera()
    {
        this.name = "panthera";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "Panthera is a genus of the family Felidae. It has five living species, which are the biggest cats in the Felidae.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class Hyena : Carnivore
{
    public Hyena()
    {
        this.name = "hyena";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "Female hyenas possess similar looking reproductive organs to males therefore accurate sexing can be difficult.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class Cheetah : Carnivore
{
    public Cheetah()
    {
        this.name = "cheetah";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "When they do stir, cheetahs can accelerate faster than most sports cars.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
//Herbivores from Africa
public class Wildebeest : Herbivore
{
    public Wildebeest()
    {
        this.name = "wildebeest";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "Wildebeests measure between 5 and 8 feet in length and have a tail length of 14 to 22 inches.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "hay" || food.product == "vegetables" 
            || food.product == "crops" || food.product == "fruits")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
class Zebra : Herbivore
{
    public Zebra()
    {
        this.name = "zebra";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "Zebras can run up to 65km per hour.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "crops" || food.product == "hay" 
            || food.product == "vegetables"|| food.product == "fruits")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
class Giraffe : Herbivore
{
    public Giraffe()
    {
        this.name = "giraffe";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "Giraffes are the tallest mammal in the world.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "compound feed" || food.product == "hay" 
            || food.product == "crops" || food.product == "vegetables")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
class Hippopotamus : Herbivore
{
    public Hippopotamus()
    {
        this.name = "hippopotamus";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "Hippos are the third largest mammals on Earth.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "hay")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
class Elephant : Herbivore
{
    public Elephant()
    {
        this.name = "elephant";
        this.continent = "Africa";
    }
    public override string GetInterestingFact()
    {
        return "Elephants are the world's largest land animals.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "fruits" || food.product == "vegetables" 
            || food.product == "crops" || food.product == "hay")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
//Carnivores from Europe
public class BrownBear : Carnivore
{
    public BrownBear()
    {
        this.name = "brown bear";
        this.continent = "Europe";
    }
    public override string GetInterestingFact()
    {
        return "The brown bear can reach a weight of between 150 and 370 kilogrammes depending on age, sex and season. " +
        "Despite their weight, the animals can cover short distances at speeds of up to 50 km/h.";
    }
    public override void ImplementFood(Food food)
    {
        this.food = food;
    }
}
public class GoldenJackal : Carnivore
{
    public GoldenJackal()
    {
        this.name = "golden jackal";
        this.continent = "Europe";
    }
    public override string GetInterestingFact()
    {
        return "The golden jackal is similar to the gray wolf but is distinguished by its smaller size, lighter weight, more elongated torso,"
        + " less-prominent forehead, shorter legs and tail, and a muzzle that is narrower and more pointed.";
    }
    public override void ImplementFood(Food food)
    {
        this.food = food;
    }
}
//Herbivores from Europe
public class Horse : Herbivore
{
    public Horse()
    {
        this.name = "horse";
        this.continent = "Europe";
    }
    public override string GetInterestingFact()
    {
        return "Horses can't breathe through their mouth.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "hay" || food.product == "crops")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
class EuropeanBison : Herbivore
{
    public EuropeanBison()
    {
        this.name = "European bison";
        this.continent = "Europe";
    }
    public override string GetInterestingFact()
    {
        return "The wild bison generally live for around 14-24 years while European bisons living in captivity can easily live up to 28 years.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "hay" || food.product == "vegetables" || food.product == "crops")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
//Carnivores from Asia
public class Tiger : Carnivore
{
    public Tiger()
    {
        this.name = "tiger";
        this.continent = "Asia";
    }
    public override string GetInterestingFact()
    {
        return "Tigers are the largest wild cats in the world.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class Lynx : Carnivore
{
    public Lynx()
    {
        this.name = "lynx";
        this.continent = "Asia";
    }
    public override string GetInterestingFact()
    {
        return "Lynx are covered with beautiful thick fur that keeps them warm during frigid winters.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
//Herbivores from Asia
public class Rhino : Herbivore
{
    public Rhino()
    {
        this.name = "rhino";
        this.continent = "Asia";
    }
    public override string GetInterestingFact()
    {
        return "Rhinos can weight over 3 tonnes.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "hay" || food.product == "compound feed")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
class Gibbon : Herbivore
{
    public Gibbon()
    {
        this.name = "gibbon";
        this.continent = "Asia";
    }
    public override string GetInterestingFact()
    {
        return "Gibbons are famous for the swift and graceful way they swing through the trees by their long arms.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "fruits" || food.product == "vegetables")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
//Carnivores from Australia
public class Thylacine : Carnivore
{
    public Thylacine()
    {
        this.name = "thylacine";
        this.continent = "Australia";
    }
    public override string GetInterestingFact()
    {
        return "They also called the Tasmanian Tigers because of the stripes on its lower back.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
public class TasmanianDevil : Carnivore
{
    public TasmanianDevil()
    {
        this.name = "tasmanian devil";
        this.continent = "Australia";
    }
    public override string GetInterestingFact()
    {
        return "Their bites are so powerful they could crush your bones.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "meat" || food.product == "fish" || food.product == "fruits")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
//Herbivores from Australia
public class Kangaroo : Herbivore
{
    public Kangaroo()
    {
        this.name = "kangaroo";
        this.continent = "Australia";
    }
    public override string GetInterestingFact()
    {
        return "Thanks to their large feet, kangaroos can leap some 30 feet (9 meters) in a single bound.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "eggs" || food.product == "hay" || food.product == "crops" 
            || food.product == "bread" || food.product == "vegetables")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}
class Possum : Herbivore
{
    public Possum()
    {
        this.name = "possum";
        this.continent = "Australia";
    }
    public override string GetInterestingFact()
    {
        return "Possums can live for up to 11 years.";
    }
    public override void ImplementFood(Food food)
    {
        if(food.product == "vegetables" || food.product == "fruits")
        {
            this.food = food;
        }
        else
        {
            Console.WriteLine($"It isn't allowed to feed {this.name} with {food.product}");
            this.food = null;
        }
    }
}