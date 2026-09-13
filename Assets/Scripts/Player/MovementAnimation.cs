using UnityEngine;

public class MovementAni : MonoBehaviour
{

    bool PressedW;
    Animator animation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckButton();
        animation.SetBool("WPressed", PressedW);
    }

    void CheckButton() 
    {
        if (Input.GetKeyDown(KeyCode.W)) PressedW = true;
        if (Input.GetKeyUp(KeyCode.W)) PressedW = false;
    }
}
