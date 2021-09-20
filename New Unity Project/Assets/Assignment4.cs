using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment4 : ProcessingLite.GP21
{

    public Vector2 char1Position;
    public Vector2 char2Position;
    public Vector2 input;
    float diameter = 2;
    float speed1 = 5f;
    float speed2 = 3.5f;
    float acceleration = 2;
    float maxSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        char1Position.x = Width / 2;
        char1Position.y = Height / 1.5f;
        
        char2Position.x = Width / 2;
        char2Position.y = Height / 3;
    }

    // Update is called once per frame
    void Update()
    {
        Background(0);
        Circle(char1Position.x, char1Position.y, diameter);
        Circle(char2Position.x, char2Position.y, diameter);
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (input.magnitude != 0)

        {
            char1Position.x = char1Position.x + (speed1 * Input.GetAxis("Horizontal")) * Time.deltaTime;
            char1Position.y = char1Position.y + (speed1 * Input.GetAxis("Vertical")) * Time.deltaTime;

            if (speed2 <= maxSpeed)
            {
                speed2 += speed2 + acceleration;
                char2Position.x = char2Position.x + (speed2 * Input.GetAxis("Horizontal")) * Time.deltaTime;
                char2Position.y = char2Position.y + (speed2 * Input.GetAxis("Vertical")) * Time.deltaTime;
            }

            else
            {
                char2Position.x = char2Position.x + (speed2 * Input.GetAxis("Horizontal")) * Time.deltaTime;
                char2Position.y = char2Position.y + (speed2 * Input.GetAxis("Vertical")) * Time.deltaTime;
            }

        }

    }
}
