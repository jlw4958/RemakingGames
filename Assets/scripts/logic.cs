using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * spawn in specifuc number at start
 * specifuc distance apart
 * despawn once past the bottom of the camera
 * spawn in new one at the top
 * list of gameobjects
*/


public class logic : MonoBehaviour
{
    public Camera myCamera;
    public GameObject myBall;
    public GameObject invisiBall;
    int maxHeight;

    GameObject obstacle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // camera movement
        if (maxHeight < myBall.transform.position.y)
        {
            maxHeight = (int)myBall.transform.position.y;
            invisiBall.transform.position = new Vector3(invisiBall.transform.position.x, maxHeight, invisiBall.transform.position.z);
        }

        // removin old obstacles

    }
}
