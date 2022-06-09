using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class label : MonoBehaviour
{
    public Sprite check;
    public Sprite question;
    public Sprite nothing;
    public Sprite nope;
    public GameObject it;
    private Image myIMGcomponent;
    // Start is called before the first frame update

    public void set(int l)
    {
        myIMGcomponent = it.GetComponent<Image>();
        if (l == 0)
        {
            myIMGcomponent.sprite = nothing;
            Color temp = myIMGcomponent.color;
            temp.a=0f;
            myIMGcomponent.color = temp;
        }
        if (l == 1)
        {
            myIMGcomponent.sprite = check;
            Color temp = myIMGcomponent.color;
            temp.a=250f;
            myIMGcomponent.color = temp;
        }
        if (l == 2)
        {
            myIMGcomponent.sprite = question;
            Color temp = myIMGcomponent.color;
            temp.a=250f;
            myIMGcomponent.color = temp;
        }
        if (l == 3)
        {
            myIMGcomponent.sprite = nope;
            Color temp = myIMGcomponent.color;
            temp.a=250f;
            myIMGcomponent.color = temp;
        }
    }
    // Update is called once per frame
    
}
