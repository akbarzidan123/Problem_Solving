using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void show()
    {
        Time.timeScale=0;
        gameObject.SetActive(true);
    }
    public void hide()
    {
        Time.timeScale=1;
        gameObject.SetActive(false);
    }
}
