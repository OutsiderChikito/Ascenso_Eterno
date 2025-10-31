using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GuillotinaKill : MonoBehaviour
{
    [Tooltip("Si true, reinicia inmediatamente. Si > 0, espera esa cantidad de segundos antes de reiniciar.")]
    public float delayBeforeRestart = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aquí puedes añadir efectos: sonido, anim, partículas...
            if (delayBeforeRestart <= 0f)
            {
                RestartScene();
            }
            else
            {
                StartCoroutine(RestartAfterDelay(delayBeforeRestart));
            }
        }
    }

    private System.Collections.IEnumerator RestartAfterDelay(float t)
    {
        yield return new WaitForSeconds(t);
        RestartScene();
    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
