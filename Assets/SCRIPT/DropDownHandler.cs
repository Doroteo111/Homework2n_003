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
    public TextMeshProUGUI confirmText;

    //Lists
    List<string> dayNames = new List<string>() { "Plase select day","1", "5", "10", "15", "20", "25", "30", "35", "40"};
    List<string> monthNames = new List<string>() { "Plase select month", "january","february", "mes40", "march","april", "may","spookymonth","mes40" };
    List<string> yearNames = new List<string>() { "Plase select year", "02", "-14", "2010", "2016", "2036", "300"};

    //son años bisiestos aquellos divisibles por 4
    //tener en cuenta la fecha de febrero!!

    ///he puesto nombre y nuemeros raros usarlos como ejemplos a la hora de hacer la comapración de la fecha valida o no

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

     } */  //solucioné este código porque me hacia movidas raísimas, el bueno el de abajo

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
        if (Input.GetKeyDown(KeyCode.Return)) //The enter calculates the valid date and takes you to the confirmation panel
        {
            SelectedText();
            confirmationPanel.SetActive(true);
            //confirmText.text = "esto es una prueba lol";
        
        }

        if (Input.GetKeyDown(KeyCode.Space)) //disable the panel
        {
            confirmationPanel.SetActive(false);
        }
    }
    //add the elements to each list
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


    public string dayDropDownOptions; //varaible para englobar el options de abajo

    public void SelectedText()
    {
        dayDropDownOptions = (dayDropDown.options[dayDropDown.value].text);
        confirmText.text = "You date is valid (example)";

        ///CONSEGUIR QUE ME LO MUESTRE EN PANTALLA
        Debug.Log(dayDropDown.options[dayDropDown.value].text);
        Debug.Log(monthDropDown.options[monthDropDown.value].text);
        Debug.Log(yearDropDown.options[yearDropDown.value].text);
    }

    /*public string dayDropDownOptions;
    private void isValid(string string)
    {
        dayDropDownOptions = (dayDropDown.options[dayDropDown.value].text);
        if ((dayDropDownOptions != "35" && "40") )
        {

        }
    }*/ //como consigo que me identifique la variable dayDropDownOptions para así poder leer el elemento seleccionado

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
