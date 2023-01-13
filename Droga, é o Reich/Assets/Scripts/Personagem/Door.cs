using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Transform posGo;
    private AudioSource audio;

    private bool playerDetected; // Vari�vel para detectar se o player est� tocando o objeto.
    GameObject playerGO; // Vari�vel da qual o player ir� se deslocar.


    void Start()
    {
        playerDetected = false;
        audio = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        // Adicionando um Input (Acionador / Gatilho) atrav�s da tecla 'E'.
        if (playerDetected)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerGO.transform.position = posGo.position;
                playerDetected = false;
                audio.Play();
            }
        }
    }
     
    // O sistema b�sico de entrada de colis�o com Trigger.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Nesta linha diz exatamente que se o objeto com a tag ''Player'' colidir com o objeto que ir� ser usado, ative a vari�vel de detec��o.
        // 
        if (collision.CompareTag("Player"))
        {
            playerDetected = true;
            playerGO = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerDetected = false;
    }
}
