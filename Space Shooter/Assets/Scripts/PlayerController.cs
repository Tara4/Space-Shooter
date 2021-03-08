using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerSpeed;
    public int laserSpeed;

    //Connect prefab to player
    public GameObject laserPrefab;
    public AudioSource laserSFX;
    public AudioSource SpaceMusic;


    // Start is called before the first frame update
    void Start()
    {
        SpaceMusic.Play();
    }

    void OnTriggerEnter2D(Collider2D collide) 
    {
        if (collide.tag == "Enemy")
        {
            SpaceMusic.Stop();
            
            //Destroy(collide.gameObject, 0.0f);
            SceneManager.LoadScene("End");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        transform.Translate(movement * Time.deltaTime * playerSpeed);

        //Is spacebar pressed?
        if (Input.GetKeyDown ("space")) {

            //Create bullet
            GameObject laser = Instantiate(laserPrefab, transform.position, Quaternion.identity);

            //Play bullet sound effect
            laserSFX.Play();

            //Send the bullet
            laser.GetComponent<Rigidbody2D>().velocity = Vector2.up * laserSpeed;

            //Destory bullet
            Destroy(laser, 2);
        }
    }
}
  

