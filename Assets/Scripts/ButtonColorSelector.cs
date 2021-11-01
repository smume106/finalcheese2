using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonColorSelector : MonoBehaviour
{

    private SpriteRenderer theSprite;

    public int thisButtonnumber;

    private ColorGame theGM;

    // Start is called before the first frame update
    void Start()
    {
        theSprite = GetComponent<SpriteRenderer>();
        theGM = FindObjectOfType<ColorGame>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 1f);
    }

    void OnMouseUp()
    {
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 0.5f);
        theGM.ColorPressed(thisButtonnumber);
    }
}
