using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // katsotaan kohta onko tarpeellinan

// �GameGurus - Heikkinen R., Hopeasaari J., Kantola J., Kettunen J., Kommio R, PC, Parviainen P., Rautiainen J.
// Tekij�: Parviainen P
// TODO: 
// - Haba nostaa esineen r�nkytt�m�ll� interact n�pp�int�
// Huom huom huom muista tarkistaa ett� esineell� on tag "Nostettava"

public class Nosto : MonoBehaviour
{
    private CharacterController controller;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    public void onNosto(InputAction.CallbackContext context)
    {
        Debug.Log("Nostetaan!");
    }
}
