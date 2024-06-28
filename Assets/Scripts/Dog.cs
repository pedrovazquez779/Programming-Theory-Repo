using UnityEngine;

// INHERITANCE
public abstract class Dog : MonoBehaviour
{
    protected string Breed;
    protected string LifeSpan;
    protected string Size;

    // POLYMORPHISM
    public string PrintInformation()
    {
        return $"Breed: {Breed}\nLife span: {LifeSpan}\nSize: {Size}";
    }
    
    // POLYMORPHISM
    public virtual string Bark()
    {
        return " is barking";
    }

    // POLYMORPHISM
    public virtual string MoveTail()
    {
        return " is moving his tail";
    }

    // POLYMORPHISM
    public virtual string SitDown()
    {
        return " is sitting down";
    }
}