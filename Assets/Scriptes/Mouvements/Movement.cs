using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float velocite;
    public bool invertedGravity = false;
    private Vector3 gravity = Physics.gravity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(velocite,0);
    }

    // Update is called once per frame
    void Update()
    {
       if (invertedGravity)
        {
            rb.AddForce(-gravity, ForceMode.Force);
        }
        
    }
    

}
