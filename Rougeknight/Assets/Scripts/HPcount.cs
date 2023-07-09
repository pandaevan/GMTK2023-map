using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPcount : MonoBehaviour
{
    public Slider slide;
    public HealthManager helath;
    public TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
       slide = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = (slide.value) + ("/") + (helath.maxHealth);
    }
}
