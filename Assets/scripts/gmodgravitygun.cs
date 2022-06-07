using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gmodgravitygun : MonoBehaviour
{   
    public objplace objplace;
    [SerializeField] private string selectableTag = "selectable";
    [SerializeField] Camera cam;
    [SerializeField] float maxGrabDistance = 10f, lerpSpeed = 100f;
    [SerializeField] Transform objectHolder;
 
    Rigidbody grabbedRB;
 
    void Update()
    {
        if(objplace.getswitch() == 0)
        {
            if(grabbedRB)
            {
                grabbedRB.MovePosition(Vector3.Lerp(grabbedRB.position, objectHolder.transform.position, Time.deltaTime * lerpSpeed));
    
            }
    
            if(Input.GetMouseButtonDown(0))
            {
                if(grabbedRB)
                {
                    grabbedRB.isKinematic = false;
                    grabbedRB = null;
                }
                else
                {
                    RaycastHit hit;
                    Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
                    if(Physics.Raycast(ray, out hit, maxGrabDistance))
                    {
                        grabbedRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                        var selection = hit.transform;
                        if(grabbedRB && selection.CompareTag(selectableTag))
                        {
                            grabbedRB.isKinematic = true;
                        }
                    }
                }
            }
        }
        else
        {
            if(grabbedRB)
                {
                    grabbedRB.isKinematic = false;
                    grabbedRB = null;
                }
        }
    }
}
