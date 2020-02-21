using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelVRManager : MonoBehaviour
{

    public GameObject PanelViseur;
    public GameObject PanelObjectif;

    // Start is called before the first frame update
    void Start()
    {
        PanelViseur.SetActive(false);
        PanelObjectif.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetPanelActive(string nomPanelActif)
    {
        switch (nomPanelActif)
        {
            case "InfoPanelViseur":
                PanelViseur.SetActive(true);
                PanelObjectif.SetActive(false);
                break;

            case "InfoPanelObjectif":
                PanelViseur.SetActive(false);
                PanelObjectif.SetActive(true);
                break;

            default:
                PanelViseur.SetActive(false);
                PanelObjectif.SetActive(false);
                Debug.Log("Dommage :" + nomPanelActif);
                break;
        }
    }

}
