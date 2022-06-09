using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class labelmaker : MonoBehaviour
{
    public int currlabel;
    private int empty = 0;
    private int check = 1;
    private int question = 2;
    private int nope = 3;

    public label label;
    // Start is called before the first frame update
    void Start()
    {
        currlabel = empty;
        label.set(currlabel);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            switchlabel();
        }
    }

    void switchlabel()
    {
        currlabel += 1;
        label.set(currlabel % 4);
    }
}
