using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    public AudioClip collectSound;
    private AudioSource playerAudio;

    //private int targetRange;
    //private float speed = 7;
    //private float maxTorque = 3;
    //private float yRange = 5;
    //private float xSpawnPos = 25;
    //public float torque;
    private GameManager gameManager;
    public int point = 1;
    //public ParticleSystem explosionParticle;
    
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        //targetRb.AddForce(Force(), ForceMode.Impulse);
        //targetRb.AddTorque(Rotate(), Rotate(), Rotate(), ForceMode.Impulse);
        //int targetRange = Random.Range(0,5);
        //transform.position = Position();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //float turn = Input.GetAxis("Horizontal");
        //targetRb.AddTorque(transform.up * torque * turn, ForceMode.Acceleration);  //Drehungen der Sammelobjekte
        //transform.Rotate(Vector3.up * Time.deltaTime * 5);
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (targetRb != null)
        {
            playerAudio.PlayOneShot(collectSound, 1.0f);
        }
        Destroy(targetRb);
        gameManager.UpdateScore(point);
        //Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        if (gameObject.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }
    }

    //Vector3 Force()
    //{
        //return Vector3.forward * speed;
    //}

    //float Rotate()
    //{
        //return Random.Range(-maxTorque, maxTorque);
    //}

    //Vector3 Position()
    //{
        //return new Vector3(xSpawnPos, Random.Range(0, yRange));
    //}
   
}
