using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//O sistema criado aqui ser� para utiliza��o de vari�veis geral padr�o dentro de objetos interativos, com o intuito de reduzir Scripts.
public class UniversalObj : MonoBehaviour
{
    //Vari�vel de texto dentro do jogo (Instru��o/Fala).
    [SerializeField] GameObject keyTxT;
    

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    //Se o player colidir com um objeto interativo o texto espec�fico ir� aparecer, vice-versa.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            keyTxT.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        keyTxT.SetActive(false);
    }
}
