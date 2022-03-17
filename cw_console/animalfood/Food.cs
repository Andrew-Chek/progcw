using static System.Console;
namespace animalfood;
public abstract class Food
{
    public string product;
    public int mass;
    public abstract string GiveFood(Animal animal);
}
public class Meat : Food
{
    public Meat(int mass)
    {
        this.product = "meat";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class Fish : Food
{
    public Fish(int mass)
    {
        this.product = "fish";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class Eggs : Food
{
    public Eggs(int mass)
    {
        this.product = "eggs";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class Vegetables : Food
{
    public Vegetables(int mass)
    {
        this.product = "vegetables";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class Fruits : Food
{
    public Fruits(int mass)
    {
        this.product = "fruits";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class Crops : Food
{
    public Crops(int mass)
    {
        this.product = "crops";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class Sweets : Food
{
    public Sweets(int mass)
    {
        this.product = "sweets";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class Bread : Food
{
    public Bread(int mass)
    {
        this.product = "bread";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class Hay : Food
{
    public Hay(int mass)
    {
        this.product = "hay";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class Porridge : Food
{
    public Porridge(int mass)
    {
        this.product = "porridge";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class TreeBark : Food
{
    public TreeBark(int mass)
    {
        this.product = "tree bark";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}
public class CompoundFeed : Food
{
    public CompoundFeed(int mass)
    {
        this.product = "compound feed";
        this.mass = mass;
    }
    public override string GiveFood(Animal animal)
    {
        if(animal.GetFood() != null)
        {
            return $"The {animal.name} was feed with {animal.GetFood().product}";
        }
        else return "";
    }
}