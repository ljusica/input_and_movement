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
        Vector2 moveCorrect = new Vector2(Input.GetAxis("Horizontal"), (Input.GetAxis("Vertical")));
        moveCorrect.Normalize();

        if (moveCorrect.magnitude != 0)

        {
            char1Position = char1Position + speed1 * moveCorrect * Time.deltaTime;

            if (speed2 <= maxSpeed)
            {
                speed2 += speed2 + acceleration;
                char2Position = char2Position + speed2 * moveCorrect * Time.deltaTime;
            }

            else
            {
                char2Position = char2Position + speed2 * moveCorrect * Time.deltaTime;

                if (moveCorrect.magnitude == 0 && speed2 != 0)
                {
                    speed2--;
                }
            }

        }

    }
}
