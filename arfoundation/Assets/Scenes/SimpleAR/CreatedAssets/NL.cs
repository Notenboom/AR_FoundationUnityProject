using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NL : MonoBehaviour
{
    [SerializeField] UIManager uim;

    void Start()
    {
        uim = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    private void OnMouseDown()
    {
        uim.NL();
    }
}
