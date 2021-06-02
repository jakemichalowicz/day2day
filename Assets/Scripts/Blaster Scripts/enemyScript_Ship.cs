using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemyScript_Ship : MonoBehaviour
{

    public float enemySpeed = 20f;
    public Rigidbody2D rigidEnemy;
    public GameObject enemBullet;
    private float shootTimer;
    public float shootIncr;
    private float shipShootPosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidEnemy.velocity = -transform.right * enemySpeed;
        //shootIncr = 0.01f;
        //gameObject.tag = "Enemy";
        Vector3 shipPosition = transform.position;
    }

    void Update()
    {
        Vector3 shipPosition = transform.position;
        if (shootTimer < Time.time) {
             //Debug.Log(string.Format("{0:N2}", randX));
             GameObject tmpBullet = Instantiate(enemBullet, new Vector3(0.0f, 7.0f, 0.0f), Quaternion.identity);
             tmpBullet.transform.position = new Vector3(shipPosition.x-0.32f, shipPosition.y-0.93f, 0.0f);

             GameObject tmpBullet2 = Instantiate(enemBullet, new Vector3(0.0f, 7.0f, 0.0f), Quaternion.identity);
             tmpBullet2.transform.position = new Vector3(shipPosition.x+0.1f, shipPosition.y-0.93f, 0.0f);

             GameObject tmpBullet3 = Instantiate(enemBullet, new Vector3(0.0f, 7.0f, 0.0f), Quaternion.identity);
             tmpBullet3.transform.position = new Vector3(shipPosition.x+0.52f, shipPosition.y-0.93f, 0.0f);

             shootTimer = Time.time + shootIncr;
         }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject.tag == "Enemy") {
        //    Physics2D.IgnoreCollision(GetComponent<Collider2D>(), col.gameObject.GetComponent<Collider2D>(), true);
        //}
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Debug.Log("Hit enemy");
            rigidEnemy.velocity = -transform.right * enemySpeed;
        }
        if (col.gameObject.tag == "Whale")
        {
            Destroy(col.gameObject);
            rigidEnemy.velocity = -transform.right * enemySpeed;
        }
        if (col.gameObject.tag == "PlatformHealth")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Platform")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }

}
