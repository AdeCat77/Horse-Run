using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    //private float maxTorque = 2;
    private GameManager gameManager;
    public int point = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        //targetRb = GetComponent<Rigidbody>();
        //targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);  //Drehungen der Sammelobjekte 
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(targetRb);
        gameManager.UpdateScore(point);
        if (gameObject.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }
    }

    //float RandomTorque()
    //{
        //return Random.Range(-maxTorque, maxTorque);
    //}
   
}
