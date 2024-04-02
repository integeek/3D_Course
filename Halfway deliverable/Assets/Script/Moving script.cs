using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Vitesse de déplacement

    private Rigidbody rb; // Référence au Rigidbody

    void Start()
    {
        // Récupérer la référence au Rigidbody attaché à l'objet
        rb = GetComponent<Rigidbody>();

        // Geler les rotations sur le Rigidbody
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        // Récupérer les entrées horizontales et verticales
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Créer un vecteur de mouvement basé sur les entrées
        Vector3 movement = new Vector3(-moveVertical, 0.0f, moveHorizontal);

        // Appliquer le mouvement au Rigidbody
        rb.velocity = movement * speed;
    }
}