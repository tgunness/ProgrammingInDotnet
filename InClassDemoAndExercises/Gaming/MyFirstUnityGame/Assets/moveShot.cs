using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShot : MonoBehaviour
{
    public float speed;
    private Vector2 boundary;
    private mainLoop mainLoopScript;

    // Start is called before the first frame update
    void Start()
    {
        var screenVector = new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z);
        boundary = Camera.main.ScreenToWorldPoint(screenVector);
        mainLoopScript = GameObject.Find("Main Camera").GetComponent<mainLoop>();

        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x < boundary.x)
        {
            gameObject.transform.Translate(new Vector2(1, 0) * speed * Time.deltaTime);
        }
        else
        {
            mainLoopScript.removeShot();
            Destroy(gameObject);
        }
    }
}
