using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objplace : MonoBehaviour
{
    public GameObject ghost; 
    public GameObject placement;
    private int switch1;
    // Start is called before the first frame update
    void Start()
    {
        switch1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("i"))
        {
            if(switch1 == 1)
            {
            switch1 = 0;
            ghost.SetActive(false);
            }
            else
            {
            switch1 += 1;
            ghost.SetActive(true);
            }                
        }
        objpl();
        
    }

    void objpl()
    {
        
        if(switch1 == 1)
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity));
            {
                ghost.transform.position = hit.point;
                if(Input.GetMouseButtonDown(0))
                {
                    Instantiate(placement, ghost.transform.position, ghost.transform.rotation);
                }
            }
        }
    }

    public int getswitch()
    {
        return switch1;
    }
    
}


