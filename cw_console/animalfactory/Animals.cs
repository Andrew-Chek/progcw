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