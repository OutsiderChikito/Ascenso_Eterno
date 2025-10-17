using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{
    public int monedas = 0;
    [Header("TextosUI")]
    public TextMeshProUGUI monedastxt;

    private void Update()
    {
        monedastxt.text = "MONEDAS: " + monedas.ToString();
    }
    
}
