using UnityEngine;

public class PlayerController3D : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(transform.forward, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, -90, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 180, 0);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("è’ìÀÇµÇ‹ÇµÇΩ: " + other.gameObject.name);
    }
}
