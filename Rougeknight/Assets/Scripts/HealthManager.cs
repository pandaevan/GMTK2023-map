using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int currentHealth = 50;

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

    }

    //Increases health by set amount, meant to be accessed by item
    public void IncreaseHealth(int modifier)
    {
        if (!(currentHealth + modifier > maxHealth))
        {
            currentHealth += modifier;
        } //issue: will add no health if modifier brings health up to maxhealth
    }

    //Increases max health by set amount, meant to be accessed by item
    public void IncreaseMaxHealth(int modifier)
    {
        if (!(maxHealth + modifier > 100))
        {
            currentHealth += modifier;
        }
    }

    public void TakeDamage(int damage)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(hurt);
        }
        currentHealth -= damage;
    }
}
