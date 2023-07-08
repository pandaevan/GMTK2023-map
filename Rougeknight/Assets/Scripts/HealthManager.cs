using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] public int maxhealth = 100;
    [SerializeField] public int currenthealth = 50;

    [SerializeField] Slider slider;

    // Start is called before the first frame update
    void Start()
    {
    slider.maxValue = maxhealth;
    }

    //Physics2D.OverlapCircleAll();
    //Event Camera 	The camera that will generate rays for this raycaster.?

    void FixedUpdate()
    {
        slider.value = currenthealth;
        slider.maxValue = maxhealth;
        if(currenthealth>= maxhealth)
        {
            currenthealth = maxhealth;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
