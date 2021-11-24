using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARFoundation.Samples;
using UnityEngine.XR.ARSubsystems;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject ui;
    [SerializeField] Text text;
    [SerializeField] PlaceOnPlane pop;
    [SerializeField] private GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        ui.SetActive(false);
    }

    public void DK()
    {
        panel.SetActive(true);
        ui.SetActive(true);
        text.text = ("Country: Denmark");
    }

    public void NL()
    {
        panel.SetActive(true);
        ui.SetActive(true);
        text.text = ("Country: Netherlands");
    }

    public void SetGlobe()
    {
        pop.placeglobe = true;
        //Invoke("setglobetrue", 1f);
    }

    public void CloseUI()
    {
        panel.SetActive(false);
        ui.SetActive(false);
    }

    public void setglobetrue()
    {
        pop.placeglobe = true;
    }
}
