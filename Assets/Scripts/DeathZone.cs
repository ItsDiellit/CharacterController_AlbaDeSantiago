using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private Animator animator; // Referencia al Animator

    void Awake()
    {
        // Obtener el componente Animator del personaje
        animator = GameObject.Find("Sad Idle").GetComponent<Animator>();
    }

    // Este método se llama cuando el Collider del personaje entra en otro Collider
    private void OnTriggerEnter(Collider collider)
    {
        // Si el personaje entra en un objeto con la etiqueta "Enemy"
        if (collider.gameObject.CompareTag("Player"))
        {
            // Activar la animación de muerte usando el trigger
            animator.SetTrigger("IsDead");

        }
    }
}
