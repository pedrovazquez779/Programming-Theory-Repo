public class Pug : Dog
{
    private void Awake()
    {
        Breed = "Pug";
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