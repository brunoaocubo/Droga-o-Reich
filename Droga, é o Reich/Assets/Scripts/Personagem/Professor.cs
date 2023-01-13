using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Professor : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] float speed;
    private bool box;
    [SerializeField] 
    private GameObject Player;

    private Vector3 movement;


    void Start()
    { 
    }


    void Update()
    {
        Move();
  
        if (box) // Se box for true e o bot�o F for pressionado o personagem ser� desativado fazendo-o sumir.
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Player.SetActive(false);
                box = false;
            }
        }
    }
    //Mecanica para identificar a tag do objeto que ser� ''Box''. E logo ap�s definindo box como true.
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.CompareTag("Box")) 
        {
            box = true;
            box = collision.gameObject;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        box = false;
    }

    void Move()
    {
        // Movimenta��o do personagem na vertical e horizontal; Anima��o setada baseada no seu estado atual criada no animator.
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position = transform.position + movement * speed * Time.deltaTime;
      
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.magnitude);
    }
}

