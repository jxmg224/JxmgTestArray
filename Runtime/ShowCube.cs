using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCube : MonoBehaviour
{
    float x;
    void Start()
    {
        x = 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        x++;
        gameObject.transform.position = new Vector3(0, x*Time.deltaTime, 0);
            
            
            }
}
