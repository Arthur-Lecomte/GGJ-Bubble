using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class BubbleSelector : MonoBehaviour, IPointerClickHandler {
    public GameObject prefab;
    public TextMeshProUGUI textMeshPro;

    public void OnPointerClick(PointerEventData eventData) {
        if (Menu.Instance.isPaused || LevelManager.Instance.isPlaying) return;
        
        Cursor.Instance.SetPrefab(prefab);
    }

    void Start() {
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        if (textMeshPro != null && prefab != null) {
            textMeshPro.text = prefab.GetComponent<Bubble>().prix + "L";
        }
    }
}