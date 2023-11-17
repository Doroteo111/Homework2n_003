using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DropDownHandler : MonoBehaviour
{
    // NO ESTA ASIGANDO PORQUE NO ME DEJA LOL
    
    List<string> names = new List<string>() { "one,two,three, four" };
    // referencia
    public TMP_Dropdown dayDropDown;
    public TMP_Text selectedName;


    public void Dropdown_IndexChanged(int index)
    {
        //which name has been selected , what happend?
        selectedName.text = names[index];
    }
    public void Start()
    {   
        DaysList();
    }

   public void DaysList()
    {       
        dayDropDown.AddOptions(names);
        //var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
    }
    
}
