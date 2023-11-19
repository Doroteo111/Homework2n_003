using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DropDownHandler : MonoBehaviour
{
    // reference
    public TMP_Dropdown dayDropDown;
    public TMP_Dropdown monthDropDown;
    public TMP_Dropdown yearDropDown;

    public TMP_Text daySelectedName;
    public TMP_Text monthSelectedName;
    public TMP_Text yearSelectedName;

    //UI
    public GameObject confirmationPanel;

    //Lists
    List<string> dayNames = new List<string>() { "Plase select day","1", "2", "3", "4", "5", "6", "7", "8","9","10" };
    List<string> monthNames = new List<string>() { "Plase select month", "jun","feb","march","april", "may" };
    List<string> yearNames = new List<string>() { "Plase select year", "2010", "2016", "2036", "300" };

    //son años bisiestos aquellos divisibles por 4
    //tener en cuenta la fecha de febrero!!


    /* public void Dropdown_IndexChanged(int index)   
     {
         daySelectedName.text = dayNames[index];
         monthSelectedName.text = monthNames[index];
         yearSelectedName.text = yearNames[index];

         if (index == 0)
         {
             daySelectedName.color = Color.red;
             monthSelectedName.color= Color.red;
             yearSelectedName.color = Color.red;
         }
         else
         {
             daySelectedName.color = Color.white;
             monthSelectedName.color = Color.white;
             yearSelectedName.color = Color.white;
         }

     } */  //solucioné este código porque me hacia movidas raísimas

    //UI display, show if is chose or not
   public void DayDropdown_IndexChanged(int index)
    {
        if (index == 0)
        {
            daySelectedName.color = Color.red;
        }
        else
        {
            daySelectedName.color = Color.white;
        }
    }
   public void MonthDropdown_IndexChanged(int index)
    {
        if (index == 0)
        {
            monthSelectedName.color = Color.red;
        }
        else
        {
            monthSelectedName.color = Color.white;
        }
    }
   public void YearDropdown_IndexChanged(int index)
    {
        if (index == 0)
        {
            yearSelectedName.color = Color.red;
        }
        else
        {
            yearSelectedName.color = Color.white;
        }
    }

    public void Awake()
    {
        confirmationPanel.SetActive(false);
    }
    public void Start()
    {   
        DaysList();
        MounthsList();
        YearsList();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SelectedText();
            confirmationPanel.SetActive(true);
        }
    }

    public void DaysList()
    {       
        dayDropDown.AddOptions(dayNames);
    }
    public void MounthsList()
    {
      monthDropDown.AddOptions(monthNames);
    }
    public void YearsList()
    {
       yearDropDown.AddOptions(yearNames);
    }

    public void SelectedText()
    {
      ///CONSEGUIR QUE ME LO MUESTRE EN PANTALLA
        Debug.Log(dayDropDown.options[dayDropDown.value].text);
        Debug.Log(monthDropDown.options[monthDropDown.value].text);
        Debug.Log(yearDropDown.options[yearDropDown.value].text);
    }
    /*private bool isValid()  //booleano que leerla los elementos asignados y dira si es valido o no
    {
         if(result == 0)
        {
            Debug.Log("This date is valid");  
            return true;

        }
        else
        {
            Debug.Log("This date is not valid");
            return false;
    }*////string to bool no funciona

       ///NOTAS --> al parecer los dropDown solo aceptan strings, los ints no va
}
