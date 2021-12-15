using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundCtrl : MonoBehaviour
{
    private Transform bg1;

    private Transform bg2;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        bg1 = GameObject.Find("/背景/bg1").transform;
        bg2 = GameObject.Find("/背景/bg2").transform;
        
        bg1.position = new Vector3(0, 0, 0);
        bg2.position = new Vector3(0, 9.99f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        bg1.Translate(0,-step,0);
        bg2.Translate(0, -step,0);

        if (bg1.position.y <= -10)
        {
            bg1.position = new Vector3(0, 9.99f, 0);
            bg2.position = new Vector3(0, 0, 0);
        }

        if (bg2.position.y<=-10)
        {
            bg1.position = new Vector3(0, 0, 0);
            bg2.position = new Vector3(0, 9.99f, 0);
        }
        
    }
}
