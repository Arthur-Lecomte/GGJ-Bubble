using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffect : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 2f); // D�truit l'effet apr�s 2 secondes
    }
}
