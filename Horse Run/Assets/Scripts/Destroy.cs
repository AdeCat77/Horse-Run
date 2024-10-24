using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    private float exitGame = -25;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < exitGame)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
        

    }
}
