using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionMenu : MonoBehaviour {
    public static LevelSelectionMenu Instance { get; private set; }
    
    [SerializeField] private GameData gameData;

    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(Instance.gameObject);
            Instance = this;
        } else {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeMenu() {
        SceneManager.LoadScene("StartScreen");
    }

    public void GoLvl(int value) {
        gameData.levelToLoad = value;
        SceneManager.LoadScene("Play");
    }
}
    