namespace animalfood;

public abstract class Animal
{
    public string name = "name of animal";
    protected Food food;
    public abstract void ImplementFood(Food food);
    public abstract string GetInterestingFact();
    public Food GetFood()
    {
        return this.food;
    }
}