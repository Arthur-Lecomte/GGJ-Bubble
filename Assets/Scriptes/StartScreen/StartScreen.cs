using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour {
    public GameObject settingsPanel;
    public Slider slider;
    
    public void ChangeScene() {
        SceneManager.LoadScene("MenuLvL");
    }

    public void Settings(bool value) {
        slider.value = PlayerPrefs.GetFloat("MusicVolume");
        settingsPanel.SetActive(value);
    }
    
    public void SetVolume(float volume) {
        Music.Instance.SetVolume(volume);
    }

    public void Exit() {
        Application.Quit();
    }
}