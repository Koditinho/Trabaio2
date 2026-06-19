using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrounCheck : MonoBehaviour

{
    public bool isOnGround;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Chao"))
        {
            isOnGround = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Chao"))
        {
            isOnGround = false;
        }
    }
}
