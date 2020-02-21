using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itwImageScript : MonoBehaviour
{
    public VideoManager manager;

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
        if(other.tag == "main") { manager.ChangeVideo("itw"); }
    }
}
