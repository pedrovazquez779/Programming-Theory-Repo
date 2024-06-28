using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITitleManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNameInput;
    
    public void UpdatePlayerName()
    {
        MainManager.Instance.PlayerName = playerNameInput.text;
        Debug.Log("Name is: " + MainManager.Instance.PlayerName);
    }
}
