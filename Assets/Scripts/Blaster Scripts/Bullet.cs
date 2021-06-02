using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public Rigidbody2D rb;
    public AudioSource audioSplat;
    public float despawnTime;
    private float despawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * bulletSpeed;
        audioSplat = GetComponent<AudioSource>();

        despawnTimer = Time.time + despawnTime;
        //Debug.Log("Spawned bullet");
    }

    void Update() {
        if (despawnTimer < Time.time) {
            Destroy(gameObject);
            //Debug.Log("DESPAWN BULLET");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            audioSplat.Play();
            Destroy(col.gameObject);
            Destroy(gameObject);
            scoreScript.scoreValue += 1;
            //Debug.Log("hit");
        }
    }
}

/**
    void OnTriggerEnger2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
**/
