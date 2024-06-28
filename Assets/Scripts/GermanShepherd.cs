public class GermanShepherd : Dog
{
    private void Awake()
    {
        Breed = "German Shepherd";
        LifeSpan = "+10 years";
        Size = "Large";
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