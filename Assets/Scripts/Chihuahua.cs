public class Chihuahua : Dog
{
    protected override void Awake()
    {
        Breed = "Chihuahua";
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