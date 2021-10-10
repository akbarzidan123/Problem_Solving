using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject star;
    float randomPositionX;
    float randomPositionY;
    void Start()
    {
        float countSpawn = Random.Range(5,21);
        for(int i = 0; i < countSpawn; i++)
        {
            randomPositionX = Random.Range(-8f, 8f);
            randomPositionY = Random.Range(-4f, 4f);
            transform.position = new Vector2(randomPositionX, randomPositionY);
            Instantiate(star, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
