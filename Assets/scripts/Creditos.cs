using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Creditos : MonoBehaviour
{

    void Start()
    {
        Invoke("WaitForEnd", 49);
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }


    public void WaitForEnd()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
