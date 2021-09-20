using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        PlayerInstructions();
        
    }

    void PlayerInstructions()
    {
        Debug.Log("Welcome To The Game Use WASD To Move The Player");
        Debug.Log("Dont Hit The Wall");
    }

    void movePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(x, 0, z);
    }
    void Update()
    {
        movePlayer();
    }
}
