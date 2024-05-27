using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOGINMANAGER : MonoBehaviour
{
    //Cuando el usuario presione Btn_Aceptar
    //Debe escribirse un mensaje en la consola
    //si el texto del InputPassword coincide
    //con una contraseña predefinida por ustedes 
    //escribir "Acces Granted"
    //sino escribir "Access Denied"

    public InputField Input_Contraseña;
    public string Password;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void contraseña()
    {
        if (Input_Contraseña.text == Password)
        {
            Debug.Log("Acces Granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
