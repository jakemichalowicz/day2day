using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class spreadBull_R : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public float bulletHorz = 2.5f;
    public Rigidbody2D rb;
    public AudioSource audioSplat;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * bulletSpeed + transform.right*bulletHorz;
        audioSplat = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            audioSplat.Play();
            Destroy(col.gameObject);
            Destroy(gameObject);
            scoreScript.scoreValue += 1;
            Debug.Log("hit");
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
