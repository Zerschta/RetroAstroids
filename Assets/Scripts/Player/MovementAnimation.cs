using UnityEngine;

public class MovementAni : MonoBehaviour
{

    bool PressedW;
    Animator animation;
    AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        audioSource = GetComponent<AudioSource>();
        animation = GetComponent<Animator>();
        audioSource.Pause();
    }

    // Update is called once per frame
    void Update()
    { 
        CheckButton();
        animation.SetBool("WPressed", PressedW);
        Play();
    }

    void CheckButton() 
    {
        if (Input.GetKeyDown(KeyCode.W)) PressedW = true;
        if (Input.GetKeyUp(KeyCode.W)) PressedW = false;
    }

    void Play()
    {
        if (PressedW)
        {
            audioSource.UnPause();
        }
        else if (!PressedW)
        {
           audioSource.Pause();
        }
    }

}

