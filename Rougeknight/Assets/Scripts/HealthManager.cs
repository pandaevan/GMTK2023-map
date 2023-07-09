using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    statsdegrade std;
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int currentHealth;

    [SerializeField] Slider slider;

    //Audio
    [SerializeField] AudioSource audioSource;

    //walk, eat, drink, weapon, sharpen, armor equip. 
    //SFX
    [SerializeField] AudioClip eat;
    [SerializeField] AudioClip drink;
    [SerializeField] AudioClip armorEquip;
    [SerializeField] AudioClip hurt;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = maxHealth;
    }

    //Physics2D.OverlapCircleAll();
    //Event Camera 	The camera that will generate rays for this raycaster.?

    void FixedUpdate()
    {
        slider.value = currentHealth;
        slider.maxValue = maxHealth;
        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    // Update is called once per frame
    void Update()
    { 
    currentHealth = std.BaseHP;
    }
}
