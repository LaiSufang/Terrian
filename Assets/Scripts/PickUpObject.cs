using TMPro;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);

            if (scoreText == null)
            {
                Debug.LogWarning("Score Text is not assigned");
                return;
            }

            if (int.TryParse(scoreText.text, out int currentScore))
            {
                currentScore += 100;
                scoreText.text = currentScore.ToString();
            }
            else
            {
                Debug.LogWarning("Failed to parse score text to an integer.");
            }

        }
    }

}
