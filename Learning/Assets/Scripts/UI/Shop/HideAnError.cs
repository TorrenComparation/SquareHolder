using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAnError : MonoBehaviour
{
    [SerializeField] private GameObject errorPanel;

    public void HidePanel()
    {
        errorPanel.SetActive(false);
    }
}
