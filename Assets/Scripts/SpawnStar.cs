using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject star;
    public GameObject ball;
    float randomPositionX;
    float randomPositionY;
    public float jarak;
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
    public IEnumerator Spawn()
    {
        yield return new WaitForSeconds(3f);
        //Max nilai X = 8f, Min nilai X = -8f
        //Max nilai Y = 4f, Min nilai Y = -4f
        randomPositionX = Random.Range(-8f, 8f);
        randomPositionY = Random.Range(-4f, 4f);
        transform.position = new Vector2(randomPositionX, randomPositionY);
        jarak = Vector2.Distance(ball.transform.position,transform.position);
        if(jarak >= 1f)
        {
            Instantiate(star, transform.position, Quaternion.identity);
        }
            
       
    }
}
