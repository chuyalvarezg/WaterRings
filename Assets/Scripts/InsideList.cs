using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideList : MonoBehaviour
{
    private List<GameObject> rings;
    // Start is called before the first frame update
    void Start()
    {
        rings = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<GameObject> getRings()
    {
        List<GameObject> temp = new List<GameObject>(rings);
        rings.Clear();
       
        return temp;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject parent = other.transform.parent.gameObject;
        if (!rings.Contains(parent))
        {
            
            rings.Add(parent);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject parent = other.transform.parent.gameObject;
        if (!rings.Contains(parent))
        {

            rings.Remove(parent);
        }

    }
}
