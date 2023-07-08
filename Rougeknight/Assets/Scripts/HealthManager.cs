using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Transform Knight;

    [SerializeField] public int maxhealth = 100;
    [SerializeField] public int currenthealth = 50;

    [SerializeField] Slider slider;
    Image fill;
    Gradient gradient;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Physics2D.OverlapCircleAll();
    //Event Camera 	The camera that will generate rays for this raycaster.?

    void FixedUpdate()
    {
        slider = GetComponent<Slider>();
        slider.value = currenthealth;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Knight.position;
    }

    public void SetHealth(int health) 
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetMaxHealth(int health) 
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
