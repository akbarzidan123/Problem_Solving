using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    float scoerPoint;
    public Text scoreText;
    public SpawnStar spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.CompareTag("Star"))
        {
            scoerPoint+=1;
            scoreText.text = "Score: "+scoerPoint.ToString();
            Destroy(col.gameObject);
            StartCoroutine(spawn.Spawn());
        }
    }
}
