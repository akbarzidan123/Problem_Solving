using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerProblem : MonoBehaviour
{
    // Start is called before the first frame update
    public Hint hint;
    public void LoadScene(string name)
    {
        Debug.Log("Clicked");
        SceneManager.LoadScene(name);
    }
    public void showHint()
    {
        hint.show();
    }
    public void closeHint()
    {
        hint.hide();
    }
}
