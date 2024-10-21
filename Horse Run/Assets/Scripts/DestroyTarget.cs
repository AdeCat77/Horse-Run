using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    private float exitGame = 20;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > exitGame)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
        

    }
}
