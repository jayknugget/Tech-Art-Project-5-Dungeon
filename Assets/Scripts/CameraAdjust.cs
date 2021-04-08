using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAdjust : MonoBehaviour
{
    public Camera camera;

    void Update()
    {
        if((GameObject.Find("Room_N(Clone)")) || (GameObject.Find("Room_E(Clone)")) || (GameObject.Find("Room_S(Clone)")) || (GameObject.Find("Room_W(Clone)"))){
            camera.orthographicSize = 7.0f;
        }else{
            camera.orthographicSize = 5.0f;
        }
    }
}
