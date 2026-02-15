using UnityEngine;

public class DeplacementHexagone : MonoBehaviour
{

    public float vitesseRotation = 0.01f;
    public float vitesseX = 0.1f;
    public float vitesseY = 0.1f;
    public float tauxReduction = 0.01f;

    public float vitesse;
    public Vector2 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position;

        float positionXAleatoire = Random.Range(-5f, 6f);
        float positionYAleatoire = Random.Range(-6f, -12f);

        transform.position = new Vector2(positionXAleatoire, positionYAleatoire);
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, vitesseRotation);

         transform.Translate(vitesseX, vitesseY, 0);

         float nouvelleTaille = transform.localScale.y - tauxReduction;
         
         if (nouvelleTaille < 1 || nouvelleTaille > 3)
         {
            tauxReduction *= -1;
         }
         
         transform.localScale = new Vector2(nouvelleTaille, nouvelleTaille);



        float nouvellePositionX = transform.position.x + vitesse;
        float nouvellePositionY = transform.position.y;

        transform.position = new Vector2(nouvellePositionX, nouvellePositionY);


        if (transform.position.y > 8f) 
        {
            transform.position=new Vector2(nouvellePositionX, nouvellePositionY);

            float positionXAleatoire = Random.Range(-5f, 6f);
            float positionYAleatoire = Random.Range(-6f, -12f);

            transform.position = new Vector2(positionXAleatoire, positionYAleatoire);
        }

        

    }
}
