using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UIElements;

public class light_off : MonoBehaviour
{
    // Start is called before the first frame update
    public  Light lightt;
    int x = 0;
    void Start()
    {
       lightt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(x < 10)
        {
            lightt.range = 10;
            x = x + 1;
        }
        else
        {
            lightt.range = 0;
            x = 0;
        }
    }
}
