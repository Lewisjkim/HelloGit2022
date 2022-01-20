using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ReStart()
    {
        Debug.Log("Restart game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
