using UnityEngine;

public class ReverseDirectionObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CharacterMovement2 movement = collision.gameObject.GetComponent<CharacterMovement2>();

            if (movement != null)
            {
                movement.ReverseDirection();
            }
        }
    }
}