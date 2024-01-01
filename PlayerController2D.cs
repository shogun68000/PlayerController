using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    void Update()
    {
        PlayerInput();
    }

    void PlayerInput()
    {
        Up();
        Down();
        Left();
        Right();
    }

    void Up()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.up;
        }
    }

    void Down()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.down;
        }
    }

    void Left()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
    }

    void Right()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
    }
}
