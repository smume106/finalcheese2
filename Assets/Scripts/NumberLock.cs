using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberLock : MonoBehaviour
{
    public string Password;

    public Sprite[] numberSprites;

    public int[] currentIndividualIndex = { 0, 0, 0 };

    private bool isOpen;

    void Start()
    {
        isOpen = false;
        LoadAllNumberSprites();  
    }

    void Update()
    {
        OpenLock();
    }

    void LoadAllNumberSprites()
    {
        numberSprites = Resources.LoadAll<Sprite>("Sprites/numbers");
    }

    bool VerifyCorrectCode()
    {
        bool correct = true;

        for(int i = 0; i < 3; i++)
        {
            if(Password[i] != transform.GetChild(i).GetComponent<SpriteRenderer>().sprite.name.Substring(transform.GetChild(i).GetComponent<SpriteRenderer>().sprite.name.Length - 1)[0])
            {
                correct = false;
            }
        }
        return correct;
    }

    void OpenLock()
    {
        if (isOpen) return;

        if(VerifyCorrectCode())
        {
            isOpen = true;
            Debug.Log("Password correct! You are awesome!");
        }
    }
}
