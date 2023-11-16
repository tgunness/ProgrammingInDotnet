using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class mainLoop_Lab1 : MonoBehaviour
{
    public GameObject Ship;
    public float shipSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            moveShip(new Vector2(0, 1));
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            moveShip(new Vector2(0, -1));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            moveShip(new Vector2(1, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveShip(new Vector2(-1, 0));
        }

    }

    void moveShip(Vector2 direction)
    {
        Ship.transform.Translate(direction * shipSpeed * Time.deltaTime);
    }

}
