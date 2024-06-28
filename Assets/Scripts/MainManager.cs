using UnityEngine;
# if UNITY_EDITOR
using UnityEditor;
# endif

public class MainManager : MonoBehaviour
{
    // MainManager contains properties and methods used across the whole app 
    public static MainManager Instance;

    // Scenes indexes
    private const int MenuSceneIndex = 0;
    private const int MainSceneIndex = 1;

    // Backing fields
    private string _playerName;

    // Properties
    public string PlayerName
    {
        get => _playerName;
        set => _playerName = value != "" ? value : "Player";
    }

    private void Awake()
    {
        InstantiateMainManagerSingleton();
    }

    // InstantiateMainManagerSingleton is used to create and maintain a singleton instance of MainManager
    private void InstantiateMainManagerSingleton()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // LoadMainScene changes to main scene 
    public void LoadMainScene()
    {
        // TODO change to main scene once created - Make sure main scene index is 1
        Debug.Log("Load main scene");
        // SceneManager.LoadScene(MainSceneIndex);
    }

    // Exit is used to quit the app
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}