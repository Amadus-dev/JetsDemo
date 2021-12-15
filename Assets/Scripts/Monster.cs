using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed = 1.0f;
    
    public GameObject prefabBullet;
    private float interval = 0.5f;
    private float count = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.Translate(0,-step,0,Space.Self);

        count += Time.deltaTime;
        if (count>interval)
        {
            count = 0;
            Fire();
        }


        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y < 0)
        {
            Destroy(this.gameObject);
        }
        
        
    }

    private void Fire()
    {
        Vector3 pos = transform.position - new Vector3(0, 1, 0);
        GameObject.Instantiate(prefabBullet, pos, transform.rotation);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("MyBullets"))
        {
            GameUI.UpdateScore(5);
        }
    }
}
