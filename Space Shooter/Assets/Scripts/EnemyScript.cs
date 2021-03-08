using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
     // Public variable that contains the speed of the enemy
    public int asteroidSpeed;

    //Connect prefab to spawner
    public GameObject asteroidPrefab; 

    // Start is called before the first frame update
    void Start()
    {
        // Call the spawnAsteroid function in 0 second
        // Then every 1 second
        InvokeRepeating("spawnAsteroid", 0, 1);
    }

    void spawnAsteroid() 
    {
        int rand = Random.Range (-8, 9);

        //Generate asteroid spawn point
        Vector2 pos = new Vector2(rand, 6);
        transform.position = pos;

         //Create asteroid
         GameObject asteroid = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);

         //Send the asteroid
        asteroid.GetComponent<Rigidbody2D>().velocity = Vector2.down * asteroidSpeed;

        //Destory Asteroid
        Destroy(asteroid, 3);
    }

    // Update is called once per frame
    void Update()
    {
              
    }
}