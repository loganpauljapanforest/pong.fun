using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class PlayOnConstant : MonoBehaviour
{
    public AudioClip[] audios = new AudioClip[4];
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {

            GetComponent<AudioSource>().clip = audios[0];
            GetComponent<AudioSource>().Play();
        }
        if (SceneManager.GetActiveScene().name == "game")
        {
            GetComponent<AudioSource>().clip = audios[1];
            GetComponent<AudioSource>().Play();
        }
        if (SceneManager.GetActiveScene().name == "winscreen")
        {
            GetComponent<AudioSource>().clip = audios[2];
            GetComponent<AudioSource>().Play();
        }
        if (SceneManager.GetActiveScene().name == "winscreen2")
        {
            GetComponent<AudioSource>().clip = audios[3];
            GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
