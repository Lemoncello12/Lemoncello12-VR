using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHands : MonoBehaviour
{
    public InputActionProperty pinch;
    public InputActionProperty grip;
    public Animator animate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinch.action.ReadValue<float>();
        animate.SetFloat("Trigger", triggerValue);
        float gripValue = grip.action.ReadValue<float>();
        animate.SetFloat("Grip", gripValue);
    }
}
