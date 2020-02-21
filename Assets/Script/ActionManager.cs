using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{

    public PanelVRManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "cliquable")
        {
            Debug.Log(other.gameObject);
            Debug.Log(other.tag);

            manager.SetPanelActive(other.name);
        }
    }
}
