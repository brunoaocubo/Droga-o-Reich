using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivadorLight : MonoBehaviour
{
    [SerializeField]
    private bool Personagem;
    public GameObject Luz;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Nesta linha diz exatamente que se o objeto com a tag ''Player'' colidir com o objeto que ir� ser usado, ative a vari�vel de detec��o.

       if (collision.CompareTag("Player"))
       {
           Luz.SetActive(true);
           Personagem = false;
       }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
