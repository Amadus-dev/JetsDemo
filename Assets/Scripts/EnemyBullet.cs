using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 5.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.Translate(0, -step, 0, Space.Self);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);//世界坐标转换为屏幕坐标
        if (sp.y < 0)
        {
            Destroy(this.gameObject);
        }

    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}