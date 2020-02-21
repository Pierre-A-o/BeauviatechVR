using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosButton : MonoBehaviour
{

    public GameObject camera;
    private Vector3 StartPos;
    private Quaternion StartRot;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = camera.transform.position;
        StartRot = camera.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(StartPos);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "main")
        {
            camera.transform.rotation = StartRot;
            camera.transform.position = StartPos;
        }
        Debug.Log(other);
    }
}
