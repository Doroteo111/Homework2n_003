using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    //variable
    public Button buttonBack;
    public GameObject confirmationPanel;

    private DropDownHandler dropDownHandler;
    void Start()
    {
        buttonBack = GetComponent<Button>();
        buttonBack.onClick.AddListener(GoBackToSelection);
    }

   private void GoBackToSelection()
    {
        dropDownHandler.confirmationPanel.SetActive(false);
    }
}
