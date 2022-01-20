using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseHero : MonoBehaviour
{
    //----------------------------------------------------------------------------
    public GameObject ChooseyourHero;
    string[] heroNames = { "dochi", "hamzi" };
    public 
    
    // Start is called before the first frame update---------------------------------------------------------
    void Start()
    {
        this.ChooseyourHero = GameObject.Find("ChooseyourHero");
    }

    // Update is called once per frame----------------------------------------------------------------
    void Update()
    {
        TextMove();
    }

    //Methods--------------------------------------------------------------
    public void TextMove()
    {
        if (transform.position.y > 400f)
        {
            transform.Translate(0, -0.6f, 0);
        }
    }
    public void SelectHero()
    {
        
    }
}
