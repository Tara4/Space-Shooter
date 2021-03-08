using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject ExplosionPrefab;

    public AudioSource ExplosionSFX;

    void OnTriggerEnter2D(Collider2D collide) 
    {
        if (collide.tag == "Enemy")
        {
            ScoreScript.scoreValue += 1;
            GameObject Explosion = Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
            ExplosionSFX.Play();
            Destroy(Explosion, 0.5f);
            Destroy(collide.gameObject, 0.0f);
        }
    }
}


