using UnityEngine;

// INHERITANCE
[RequireComponent(typeof(Animator))]
public abstract class Dog : MonoBehaviour
{
    protected Animator Animator;
    protected string Breed;
    protected string LifeSpan;
    protected string Size;

    protected readonly int AnimationID = Animator.StringToHash("AnimationID");

    protected virtual void Awake()
    {
        Animator = GetComponent<Animator>();
    }

    // POLYMORPHISM
    public string PrintInformation()
    {
        return $"Breed: {Breed}\nLife span: {LifeSpan}\nSize: {Size}";
    }

    // POLYMORPHISM
    public abstract void Bark();
    public abstract void MoveTail();
    public abstract void SitDown();
}