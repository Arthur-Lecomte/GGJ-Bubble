using UnityEngine;

public class Music : MonoBehaviour {
    public static Music Instance { get; private set; }
    
    public AudioSource musicSource;
    
    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
        } else {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    
    public void SetVolume(float volume) {
        musicSource.volume = volume;
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }
}
