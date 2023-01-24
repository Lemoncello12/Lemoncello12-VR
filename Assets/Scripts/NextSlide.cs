using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSlide : MonoBehaviour
{
    public Slideshow slide;
    private bool contact = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickNext()
    {
        if (contact)
        {
            slide.NextSlide();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            contact = true;
            Debug.Log("Contact Detected");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            contact = false;
        }
    }
}
