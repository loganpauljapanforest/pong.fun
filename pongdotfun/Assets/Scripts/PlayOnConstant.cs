using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class PlayOnConstant : MonoBehaviour
{
    readonly AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {

        }
        if (SceneManager.GetActiveScene().name == "game")
        {

        }
        if (SceneManager.GetActiveScene().name == "winscreen")
        {

        }
        if (SceneManager.GetActiveScene().name == "winscreen2")
        {

        }
    }
}
