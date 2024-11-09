using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Rigidbody targetRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    private GameManager gameManager;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticleBack;
    public ParticleSystem dirtParticleFront;
    public AudioClip runSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        gameManager.StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            dirtParticleBack.Stop();
            dirtParticleFront.Stop();
            playerAudio.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticleBack.Play();
            dirtParticleFront.Play();
            playerAudio.PlayOneShot(runSound, 0.5f);
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            gameManager.GameOver();
            playerAnim.SetTrigger("Horse_Idle");
            explosionParticle.Play();
            dirtParticleBack.Stop();
            dirtParticleFront.Stop();
            playerAudio.Stop();
        }
    }
}
