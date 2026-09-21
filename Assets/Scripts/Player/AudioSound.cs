using UnityEngine;

public class AudioSound : MonoBehaviour
{
    AudioSource Gunshot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Gunshot = GetComponent<AudioSource>();
        Gunshot.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        play();
    }

    void play()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Gunshot.UnPause();
        }
        else
        {
            Gunshot.Pause();
        }
    }
}
