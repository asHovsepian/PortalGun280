using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    //need to store the position of the player (reference)
    public Transform player;
    //reference to the recieving portal
    public Transform reciever;

    private bool playerIsClipping = false;
    
    void Update()
    {
        //if in portal
        if (playerIsClipping)
        {
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            if (dotProduct < 0f)
            {
                //teleport
                float rotationDiff = Quaternion.Angle(transform.rotation, reciever.rotation);
                //flip player
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = reciever.position + positionOffset;
                //teleported, so set clipping back to false
                playerIsClipping = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //checks to see if the player and portal are overlapping
        if (other.tag == "Player")
        {
            playerIsClipping = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        //same thing as above but opposite, that way it sets itself back to true if its not overlapping
        if (other.tag == "Player")
        {
            playerIsClipping = false;
        }
    }
}
