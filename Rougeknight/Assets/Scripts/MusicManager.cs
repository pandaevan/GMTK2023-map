using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MusicManager : MonoBehaviour
{
    Scene scene;

    //Audio
    AudioSource audioSource;

    //Songs
    AudioClip menuTheme;
    AudioClip areaOne;
    AudioClip areaTwo;
    AudioClip areaThree;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        switch (scene.buildIndex + 1)
        {
            //menu
            case 0:
                audioSource.Play();
                break;

            //1st area
            case 1:
                audioSource.Play();
                break;

            //2nd area
            case 2:
                audioSource.Play();
                break;

            //3rd area
            case 3:
                audioSource.Play();
                break;
        }
    }
}