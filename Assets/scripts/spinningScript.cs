using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinningScript : MonoBehaviour
{
    public GameObject spinningObject;
    public float spinSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spinningObject.transform.Rotate(0, 0, spinSpeed);
    }
}
