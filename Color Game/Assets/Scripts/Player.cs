using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float verticalForece = 400f;
    [SerializeField] private float restarDelay = 1f;

    [SerializeField] private ParticleSystem playerParticles;

    [SerializeField] private Color orangeColor;
    [SerializeField] private Color violetColor;
    [SerializeField] private Color cyanColor;
    [SerializeField] private Color pinkColor;
    private string currentColor;

    Rigidbody2D playerRB;
    SpriteRenderer playerSR;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerRB.AddForce(new Vector2(0, 400));

        playerSR = GetComponent<SpriteRenderer>();

        ChangeColor();
        
        {

        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.velocity = Vector2.zero;
            playerRB.AddForce(new Vector2(0, verticalForece));
        }
    }

    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(!collision.gameObject.CompareTag(currentColor))
        {
            gameObject.SetActive(false);
            Instantiate(playerParticles, transform.position, Quaternion.identity);
            Invoke("RestartScene", restarDelay);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void ChangeColor()
    {
        int randomNumber = Random.Range(0, 4);
        

        if(randomNumber == 0)
        {
            playerSR.color = orangeColor;
            currentColor = "Orange";
        }
        else if(randomNumber == 1)
        {
            playerSR.color = violetColor;
            currentColor = "Violet";
        }
        else if (randomNumber == 2 )
        {
            playerSR.color = cyanColor;
            currentColor = "Cyan";
        }
        else if(randomNumber == 3)
        {
            playerSR.color = pinkColor;
            currentColor = "Pink";
        }
    }
}
