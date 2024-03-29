using UnityEngine;

public class DeplacementPersonnage : MonoBehaviour
{
    public float vitesseDeplacement = 5f; // Vitesse de déplacement du personnage

    void Update()
    {
        // Déplacement horizontal
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        float deplacementVertical = Input.GetAxis("Vertical");

        // Déplacement vers la droite
        if (deplacementHorizontal != 0f)
        {
            transform.Translate(Vector3.right * deplacementHorizontal * vitesseDeplacement * Time.deltaTime);
        }

        // Déplacement vers le haut
        if (deplacementVertical != 0f)
        {
            transform.Translate(Vector3.forward * deplacementVertical * vitesseDeplacement * Time.deltaTime);
        }
    }
}

