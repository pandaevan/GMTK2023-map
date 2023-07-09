using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class statsdegrade : MonoBehaviour
{
    public KnightMovement KnightMovement;
    public int BaseSPD;
    public int BaseATK;
    public int BaseHP;
    public int SPD;
    public int ATK;
    public int HP;
    public int statdown;
    public int statresettimer;
    public int lowerby;
    // Start is called before the first frame update
    void Start()
    {
        HP =  BaseHP;
        ATK = BaseATK;
        SPD = BaseSPD;
    }
  void Awake() 
    {
    StartCoroutine(Debuff());
    }
    // Update is called once per frame
    void Update()
    {
        if(SPD <= 24)
        {
            SPD=25;
        }
        BaseHP = HP;
        BaseATK = ATK;
        BaseSPD = SPD;
        if(ATK <= 15 && SPD <= 25 && HP <= 15)
        {
            StopCoroutine(Debuff());
        }
    }
    IEnumerator Debuff()
    {
        while(true)
        {
            
            statdown = Random.Range(1,4);
            statresettimer = Random.Range(30, 60);
            lowerby = Random.Range(1,15);
            if(HP <= 15 && statdown == 1)
            {
                statdown = Random.Range(2,4);
                Debug.Log("1");
            }
            if(ATK <= 15 && statdown == 2)
            {
                statdown = Random.Range(1,4);
                Debug.Log("2");
            }
            if(SPD <= 25 && statdown == 3)
            {
                statdown = Random.Range(2,3);
                Debug.Log("3");
            }
            yield return new WaitForSeconds (statresettimer);
            if(statdown == 1 && HP>= 15)
            {
                HP -= lowerby;
                Debug.Log("4");
            }
            if(statdown == 2 && ATK>= 15)
            {
                ATK -= lowerby;
                Debug.Log("5");
            }
            if(statdown == 3 && SPD>= 15)
            {
                SPD -= lowerby;
                Debug.Log("6");
            }
        }
    }
}
