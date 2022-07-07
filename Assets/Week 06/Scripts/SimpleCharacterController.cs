using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    // Start is called before the first frame update

    // What does this need to do?
    // - Move the character in directions of X and Z axes. (Y axis is for jumping later on)
    // When will our character move?
    // - When the player presses keys or uses a controller. This is the "Input" of the player.

    [SerializeField] private float movementSpeed = 10;

    private void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime);
        // If your game is running at 60 fps, 
        // Time.deltaTime will be equal to 0.167 seconds

    }






}

  