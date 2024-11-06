using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    public float torque;
    private GameManager gameManager;
    public int point = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>(); 
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxis("Horizontal");
        targetRb.AddTorque(transform.up * torque * turn);  //Drehungen der Sammelobjekte
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

    //void Rotate()
    //{
        
    //}
   
}
