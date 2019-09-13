using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string nume)
    {
        Debug.Log("se incarca level" + nume);
        Application.LoadLevel(nume);
    }
    
    public void inchidere()
    {
        Debug.Log("se inchide");
        Application.Quit () ;
    }
}
