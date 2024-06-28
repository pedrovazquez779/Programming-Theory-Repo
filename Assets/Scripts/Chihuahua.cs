public class Chihuahua : Dog
{
    private void Awake()
    {
        Breed = "Chihuahua";
        LifeSpan = "+7 years";
        Size = "Small";
    }

    public override string Bark()
    {
        return Breed + base.Bark();
    }

    public override string MoveTail()
    {
        return Breed + base.MoveTail();
    }

    public override string SitDown()
    {
        return Breed + base.SitDown();
    }
}