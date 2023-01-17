using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slideshow : MonoBehaviour
{
    private Material slide1;
    public Material slide2;
    public Material slide3;
    public Material slide4;
    public Material slide5;
    public Material slide6;
    public Material slide7;
    public Material slide8;
    public Material slide9;
    public Material slide10;
    private float num = 1;
    // Start is called before the first frame update
    void Start()
    {
        slide1 = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextSlide()
    {
        num = num + 1;
        if(num == 2)
        {
            GetComponent<MeshRenderer>().material = slide2;
        }
        else if(num == 3)
        {
            GetComponent<MeshRenderer>().material = slide3;
        }
        else if (num == 4)
        {
            GetComponent<MeshRenderer>().material = slide4;
        }
        else if (num == 5)
        {
            GetComponent<MeshRenderer>().material = slide5;
        }
        else if (num == 6)
        {
            GetComponent<MeshRenderer>().material = slide6;
        }
        else if (num == 7)
        {
            GetComponent<MeshRenderer>().material = slide7;
        }
        else if (num == 8)
        {
            GetComponent<MeshRenderer>().material = slide8;
        }
        else if (num == 9)
        {
            GetComponent<MeshRenderer>().material = slide9;
        }
        else if (num == 10)
        {
            GetComponent<MeshRenderer>().material = slide10;
        }
        else
        {
            GetComponent<MeshRenderer>().material = slide1;
            num = 1;
        }
    }
}
