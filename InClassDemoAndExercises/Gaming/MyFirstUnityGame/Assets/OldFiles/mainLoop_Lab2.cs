using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class mainLoop_Lab2 : MonoBehaviour
{
    public GameObject Ship;
    public float shipSpeed;
    public Vector3 boundary;

    public GameObject Rock;
    public int maxRocks = 15;
    public int currentRocks = 0;
    public int frequency;

    // Start is called before the first frame update
    void Start()
    {
        var shipXHalf = Ship.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        var shipYHalf = Ship.GetComponent<SpriteRenderer>().bounds.size.y / 2;

        shipSpeed = 10;
        frequency = 100;
        var screenVector = new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z);
        boundary = Camera.main.ScreenToWorldPoint(screenVector);

        boundary.x = boundary.x - shipXHalf;
        boundary.y = boundary.y - shipYHalf;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) && Ship.transform.position.y < boundary.y)
        {
            moveShip(new Vector2(0, 1));
        }
        else if(Input.GetKey(KeyCode.DownArrow) && Ship.transform.position.y > -boundary.y)
        {
            moveShip(new Vector2(0, -1));
        }
        else if (Input.GetKey(KeyCode.RightArrow) && Ship.transform.position.x < boundary.x)
        {
            moveShip(new Vector2(1, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Ship.transform.position.x > -boundary.x)
        {
            moveShip(new Vector2(-1, 0));
        }

        //rock stuff
        if (currentRocks < maxRocks && Random.Range(0, frequency) == 0)
        {
            makeRock();
        }

    }

    void moveShip(Vector2 direction)
    {
        Ship.transform.Translate(direction * shipSpeed * Time.deltaTime);
    }

    public void makeRock()
    {
        Instantiate(Rock);
        Rock.transform.position = new Vector2(boundary.x, Random.Range(-boundary.y, boundary.y));
        currentRocks++;
    }

    public void removeRock()
    {
        currentRocks--;
    }

}
