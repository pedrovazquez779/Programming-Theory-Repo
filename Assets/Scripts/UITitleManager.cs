using TMPro;
using UnityEngine;

public class UITitleManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNameInput;

    private void Start()
    {
        playerNameInput.text = MainManager.Instance.PlayerName;
    }

    // UpdatePlayerName updates player's name onEndEdit method from the input
    public void UpdatePlayerName()
    {
        MainManager.Instance.PlayerName = playerNameInput.text;
    }

    // OnStart is called when "Start" button is clicked to go to the main scene
    public void OnStart()
    {
        MainManager.Instance.LoadMainScene();
    }

    // OnExit is called when "Exit" button is clicked to exit the application
    public void OnExit()
    {
        MainManager.Instance.Exit();
    }
}