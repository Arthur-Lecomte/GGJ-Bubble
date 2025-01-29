using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionMenu : MonoBehaviour {
    [SerializeField] private GameData gameData;

    private void Awake() {
        StartScreen[] scripts = GetComponents<StartScreen>();
        for (int i = 1; i < scripts.Length; i++) {
            Destroy(scripts[i]);
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
    