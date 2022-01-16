using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectMovement : MonoBehaviour
{
    private float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetSceneByName("GamePlay_Level 1").isLoaded)
        {
            ySpeed = -4f;
        }
        else if (SceneManager.GetSceneByName("GamePlay_Level 2").isLoaded)
        {
            ySpeed = -7.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f, ySpeed * Time.deltaTime, 0f));
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }
}
