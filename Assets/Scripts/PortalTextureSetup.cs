using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    //stores the orange room camera
    public Camera CameraOrange;
    //stores the blue room rexture that stores the camera of orange room
    public Material CameraBlueMat;
    //same for other portal
    public Camera CameraBlue;
    public Material CameraOrangeMat;
    void Start()
    {
        //checks if there already is a texture
        if (CameraOrange.targetTexture != null)
        {
            //if there is than it clears the texture
            CameraOrange.targetTexture.Release();
        }
        //now creates a new texture, this way we can set the width and heigh to whatever we want
        CameraOrange.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        //now can set that new texture to our portal
        CameraBlueMat.mainTexture = CameraOrange.targetTexture;

        //need to do this again with other portal

        if (CameraBlue.targetTexture != null)
        {
            CameraBlue.targetTexture.Release();
        }
        CameraBlue.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        CameraOrangeMat.mainTexture = CameraOrange.targetTexture;

    }

}
