using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float posX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0f, 0f, -30f) + new Vector3(target.position.x, target.position.y, 0f);
        //transform.LookAt(new Vector3(target.position.x, posX, -30f));
        
    }
}
