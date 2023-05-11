using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    //reference to the player camera position
    public Transform playerCamera;
    //reference that this portal that this camera belongs too
    public Transform portal;
    //refernce to the other portal
    public Transform otherPortal;

    // Update is called once per frame
    void Update()
    {
        //this calculates the distance between player and he portal, the offset
        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        //then sets the portal position to itself plus the offset we just calculated
        transform.position = portal.position + playerOffsetFromPortal;

        //portal moves with the player, now needs to rotate with the player.

        //first get the correct angle
        float portalCamAngle = Quaternion.Angle(portal.rotation, otherPortal.rotation);
        //then have to convert this angle back into a quaterion
        Quaternion angletoQuaternion = Quaternion.AngleAxis(portalCamAngle, Vector3.up);
        //then calculate which direction to point torwads (should face the same way as player)
    }
}
