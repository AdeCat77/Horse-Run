using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    public AudioClip collectSound;
    private AudioSource playerAudio;
    private GameManager gameManager;
    Vector3 pivotPoint = new Vector3(25,5,0);
    public int point = 1;
    
    //public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(targetRb);
        gameManager.UpdateScore(point);
        if (gameObject.CompareTag("Target"))
        {
            playerAudio.PlayOneShot(collectSound, 1.0f);
        }   
        //Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        if (gameObject.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }
    }

    void RotateAroundPoint() //Drehungen der Sammelobjekte
    {
        //rotates around the pivot point and the Y-Axis by 360 degrees
        transform.RotateAround(pivotPoint, Vector3.up, 360);
    }
   
}
