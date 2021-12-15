using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyJet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float moveSpeed = 2.5f;

    private float interval = 0.2f;
    private float count = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count > interval)
        {
            count = 0;
            Fire();
        }

        float step = moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-step, 0,0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(step, 0,0);
        }
        

    }

    private void Fire()
    {
        Vector3 pos = transform.position + new Vector3(0, 1f, 0);
        GameObject.Instantiate(bulletPrefab, pos, transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (int.Parse(GameUI.lifescoreText.text) <= 1)
        {
            //Destroy(this.gameObject);
            SceneManager.LoadScene("Scenes/GameOver", LoadSceneMode.Single);
        }
        if (collision.tag.Equals("EnemyBullets"))
        {
            GameUI.UpdateLifeScore(1);
        }
    }
}
