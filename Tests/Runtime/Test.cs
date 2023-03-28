using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JxmgTool.Array;

public class Test : MonoBehaviour
{
    public string[] infoList;
    void Start()
    {
        Debug.Log(infoList.ToOneString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
