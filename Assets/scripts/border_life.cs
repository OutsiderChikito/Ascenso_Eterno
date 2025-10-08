using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.UI;

public class border_life : MonoBehaviour
{
    public Image rellenoStamina;
    private ThirdPersonController playerController;
    private float maxStamina;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("PlayerArmature").GetComponent<ThirdPersonController>();
        maxStamina = playerController.maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        rellenoStamina.fillAmount = playerController.currentStamina / maxStamina;
    }
}
