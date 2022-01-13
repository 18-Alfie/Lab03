using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketMovementScript : MonoBehaviour
{
    public float score = 0;
    public float speed;

    public Text scoreText;
   
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {

      float horizontalInput = Input.GetAxis("Horizontal");

      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        
       

    }

    // Check if basket collides with object with Healthy or Unhealthy tag

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Healthy"))
        {
            score+=10;
            scoreText.text = "Score: " + score;
        }
        else if (collision.gameObject.CompareTag("Unhealthy"))
        {

        }
        Destroy(collision.gameObject);
    }


}
