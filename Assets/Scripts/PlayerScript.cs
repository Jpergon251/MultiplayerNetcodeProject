using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerScript : NetworkBehaviour
{
    public float speed = 5f;
    private Vector2 moveInput;
    
    // Este método se conecta a la acción "Move" del Input System
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        if (IsOwner)
        {
            Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
            transform.Translate(move * speed * Time.deltaTime);
        }
  
    }
    
    public override void OnNetworkSpawn()
    {
//If this is not the owner, turn of player inputs
        if (!IsOwner) gameObject.GetComponent<PlayerInput>().enabled = false;
    }
    
}