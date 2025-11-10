using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillOnParticleHit : MonoBehaviour
{
    public string playerTag = "Player";
    public float reloadDelay = 0.05f;
    bool reloading;

    void OnParticleCollision(GameObject other)
    {
        if (!reloading && other.CompareTag(playerTag))
        {
            reloading = true;
            Invoke(nameof(ReloadLevel), reloadDelay);
        }
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
