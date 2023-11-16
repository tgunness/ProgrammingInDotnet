using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRock_Lab2 : MonoBehaviour
{
    public Vector2 boundary;
    private mainLoop mainLoopScript;

    public int minSpeed;
    public int maxSpeed;
    public int rockSpeed;


    // Start is called before the first frame update
    void Start()
    {
        var screenVector = new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z);
        boundary = Camera.main.ScreenToWorldPoint(screenVector);

        mainLoopScript = GameObject.Find("Main Camera").GetComponent<mainLoop>();

        minSpeed = 1;
        maxSpeed = 8;        
        rockSpeed = Random.Range(minSpeed, maxSpeed);               
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < -boundary.x)
        {
            mainLoopScript.removeRock();
            Destroy(gameObject);
        }
        else
        {
            move(new Vector2(-1, 0));
        }
    }

    void move(Vector2 direction)
    {
        gameObject.transform.Translate(direction * rockSpeed * Time.deltaTime);
    }
}
