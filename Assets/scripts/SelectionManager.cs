using UnityEngine;

public class SelectionManager : MonoBehaviour
{   
    public objplace objplace;
    [SerializeField] private string selectableTag = "selectable";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;
    
    private void Update()
    {
        if(objplace.getswitch() == 0)
        {
            if (_selection != null)
            {
                var selectionRenderer = _selection.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial;
                _selection = null;
            }
            
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.CompareTag(selectableTag))
                {
                    var selectionRenderer = selection.GetComponent<Renderer>();
                    if (selectionRenderer != null)
                    {
                        selectionRenderer.material = highlightMaterial;
                    }

                    _selection = selection;
                }
            }
        }
        else
        {
            if (_selection != null)
            {
                var selectionRenderer = _selection.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial;
                _selection = null;
            }
        }
    }
}