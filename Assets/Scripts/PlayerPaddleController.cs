using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerPaddleController : MonoBehaviour
{
    public float speed = 5f;
    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;
    public string movementAxisName = "Vertical";
    private void Start()
    {
        if (isPlayer)
            spriteRenderer.color = SaveController.Instance.colorPlayer;
        else
            spriteRenderer.color = SaveController.Instance.colorEnemy;
    }
    void Update()
    {
        // Captura da entrada vertical (seta para cima, seta para baixo, teclas W e S)
        float moveInput = Input.GetAxis(movementAxisName);
        // Calcula a nova posi��o da raquete baseada na entrada e na velocidade
        Vector3 newPosition = transform.position + Vector3.up * moveInput * speed *
       Time.deltaTime;
        // Limita a posi��o vertical da raquete para que ela n�o saia da tela
        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);
        // Atualiza a posi��o da raquete
        transform.position = newPosition;
    }
}
