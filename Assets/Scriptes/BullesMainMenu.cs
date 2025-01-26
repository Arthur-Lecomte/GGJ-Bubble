using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullesMainMenu : MonoBehaviour
{
    public float gravityScale = 0.1f; // Gravit� faible
    public float minSpeed = 1.0f; // Vitesse minimale pour �viter l'arr�t complet

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.useGravity = false; // D�sactiver la gravit� par d�faut
        rb.constraints = RigidbodyConstraints.FreezePositionZ; // Bloquer le mouvement sur l'axe Z
    }

    // Update is called once per frame
    void Update()
    {
        // Appliquer une gravit� personnalis�e
        rb.AddForce(Physics.gravity * gravityScale, ForceMode.Acceleration);

        // Assurer une vitesse minimale pour �viter l'arr�t complet
        if (rb.velocity.magnitude < minSpeed)
        {
            rb.velocity = rb.velocity.normalized * minSpeed;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Inverser la direction de la vitesse en fonction de la normale de la collision
        Vector3 velocity = rb.velocity;
        Vector3 normal = collision.contacts[0].normal;
        Vector3 reflectedVelocity = Vector3.Reflect(velocity, normal);
        rb.velocity = reflectedVelocity.normalized * velocity.magnitude;

        // Ajouter une petite force al�atoire pour �viter l'arr�t complet
        rb.AddForce(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0) * 0.1f, ForceMode.Impulse);
    }
}