using UnityEngine;
using TMPro;

public class BasketSimple : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fruit")
        {
            score++;
            Destroy(other.gameObject);
            scoreText.text = "Fruits: " + score;
        }
    }
}
