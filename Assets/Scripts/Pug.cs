public class Pug : Dog
{
    protected override void Awake()
    {
        Breed = "Pug";
        LifeSpan = "+7 years";
        Size = "Small";
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