using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverManager : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isGameOver = false;
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
                isGameOver = false;
            }
        }
    }
    public void Show()
    {
        gameObject.SetActive(true);
        isGameOver = true;
    }
}
