using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovementScript : MonoBehaviour
{
    public float score = 0;
    public float speed;

    public Text scoreText;

    AudioSource healthyCollect;
    AudioSource unhealthyCollect;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;

        AudioSource[] audios = GetComponents<AudioSource>();

        healthyCollect = audios[0];
        unhealthyCollect = audios[1];
    }

    // Update is called once per frame
    void Update()
    {

      float horizontalInput = Input.GetAxis("Horizontal");

      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);


        // Checks if score is 100
        if (score >= 100)
        {

            // Game goes to level 2 when score is 100
            SceneManager.LoadScene("GamePlay_Level 2");
        }
       

    }

    // Check if basket collides with object with Healthy or Unhealthy tag

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Healthy"))
        {
            healthyCollect.Play();
            score+=10;
            scoreText.text = "Score: " + score;
        }
        else if (collision.gameObject.CompareTag("Unhealthy"))
        {
            unhealthyCollect.Play();
            SceneManager.LoadScene("GameLoseScene");
        }
        Destroy(collision.gameObject);
    }


}
