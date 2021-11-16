using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private DisplayImage currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DispalyImage>();
    }


}
