using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    public GameObject monsterPrefab;

    public Sprite[] image;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateMonster", 0.1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateMonster()
    {
        float x = Random.Range(-2, 2);
        float y = 5;

        GameObject monster = Instantiate(monsterPrefab);
        monster.transform.position = new Vector3(x, y, 0);
        //随机选取一个头像
        int index = Random.Range(0, image.Length);
        SpriteRenderer renderer = monster.GetComponent<SpriteRenderer>();
        renderer.sprite = image[index];
        
        //头像大小设置为100px
        Sprite sprite = this.image[index];
        float imageWidth = sprite.rect.width;
        float scale = 100 / imageWidth;
        monster.transform.localScale = new Vector3(scale, scale, scale);
    }
}
