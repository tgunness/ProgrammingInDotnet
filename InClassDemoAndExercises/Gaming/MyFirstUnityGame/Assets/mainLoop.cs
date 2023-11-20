using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class mainLoop : MonoBehaviour
{
    public GameObject Ship;
    public float shipSpeed;
    public Vector3 boundary;

    public GameObject Rock;
    public int maxRocks = 15;
    public int currentRocks = 0;
    public int frequency;

    public GameObject Shot;
    public int maxShots;
    private int currentShots;

    public GameObject starfield_a;
    public GameObject starfield_b;
    private int starfieldSpeed;
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

        maxShots = 10;
        currentShots = 0;

        starfieldSpeed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && Ship.transform.position.y < boundary.y)
        {
            moveShip(new Vector2(0, 1));
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Ship.transform.position.y > -boundary.y)
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

        if (Input.GetKey(KeyCode.Space) && currentShots < maxShots)
        {
            makeShot();
        }


        moveStarfield();

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

    public void makeShot()
    {
        GameObject temp = Instantiate(Shot);
        temp.transform.position = Ship.transform.position;
        currentShots++;
    }

    public void removeShot()
    {
        currentShots--;
    }

    public void moveStarfield()
    {
        if(starfield_a.transform.position.x < -29)
        {
            starfield_a.transform.Translate(new Vector2(60, 0));
        }

        if (starfield_b.transform.position.x < -29)
        {
            starfield_b.transform.Translate(new Vector2(60, 0));
        }

        starfield_a.transform.Translate(new Vector2(-1, 0) * starfieldSpeed * Time.deltaTime);
        starfield_b.transform.Translate(new Vector2(-1, 0) * starfieldSpeed * Time.deltaTime);
    }

}
