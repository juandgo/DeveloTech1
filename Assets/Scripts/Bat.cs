using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] public Transform jugador;
    [SerializeField] private float distancia;


    public Vector3 puntoInicial;
    private Animator animator;

    private SpriteRenderer spriteRenderer;

    private void Start(){
        animator = GetComponent<Animator>();
        puntoInicial = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update(){
        distancia = Vector2.Distance(transform.position, jugador.position);
        animator.SetFloat("Distancia", distancia);
    }

    private void Girar(Vector3 objetivo){
        if(transform.position.x < objetivo.x){
            spriteRenderer.flipX = true;
        }else{
            spriteRenderer.flipX = false;
        }
    }
}
