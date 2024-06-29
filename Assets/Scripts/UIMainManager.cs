using TMPro;
using UnityEngine;

public class UIMainManager : MonoBehaviour
{
    [SerializeField] private TMP_Text welcomeText;
    [SerializeField] private TMP_Text informationText;
    [SerializeField] private Dog activeDog;
    [SerializeField] private Dog pug;
    [SerializeField] private Dog chihuahua;
    [SerializeField] private Dog germanShepherd;

    private void Start()
    {
        WelcomeMessage();
    }

    // ABSTRACTION - We don't need all this code in Start method. We just need to know that a welcome message is going to be shown
    private void WelcomeMessage()
    {
        string playerName = MainManager.Instance.PlayerName;
        playerName = playerName != "" ? " " + playerName + " " : " ";
        welcomeText.text = $"Welcome{playerName}to OOP Theory";
    }

    public void BackToMainMenu()
    {
        MainManager.Instance.LoadMenuScene();
    }

    public void OnPugClick() => SwitchActiveDog(pug);
    public void OnChihuahuaClick() => SwitchActiveDog(chihuahua);
    public void OnGermanShepherdClick() => SwitchActiveDog(germanShepherd);

    // ABSTRACTION - This code would have been duplicated in each button that is changing the active dog 
    private void SwitchActiveDog(Dog dog)
    {
        if (activeDog != null) activeDog.gameObject.SetActive(false);
        activeDog = dog;
        activeDog.gameObject.SetActive(true);
        informationText.text = activeDog.PrintInformation();
    }

    public void OnBarkClick() => activeDog.Bark();
    public void OnMoveTailClick() => activeDog.MoveTail();
    public void OnSitDownClick() => activeDog.SitDown();
}