public class GermanShepherd : Dog
{
    protected override void Awake()
    {
        Breed = "German Shepherd";
        LifeSpan = "+10 years";
        Size = "Large";
        base.Awake();
    }

    public override void Bark()
    {
        Animator.SetInteger(AnimationID, 6);
    }

    public override void MoveTail()
    {
        Animator.SetInteger(AnimationID, 1);
    }

    public override void SitDown()
    {
        Animator.SetInteger(AnimationID, 7);
    }
}