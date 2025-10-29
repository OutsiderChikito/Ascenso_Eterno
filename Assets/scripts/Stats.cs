using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{
    public int monedas = 0;
    [Header("TextosUI")]
    public TextMeshProUGUI monedastxt;
    [Header("Configuración")]
    public GameObject objetoPortal; // El objeto 3D que se activará
    public int monedasPorRecolectar = 10;

    void Start()
    {
        // Aseguramos que el objeto comience desactivado
        if (objetoPortal != null)
            objetoPortal.SetActive(false);
    }

    private void Update()
    {
        monedastxt.text = "MONEDAS: " + monedas.ToString();

        if (objetoPortal != null && monedas >= monedasPorRecolectar)
        {
            objetoPortal.SetActive(true);
        }
    }
    
}
