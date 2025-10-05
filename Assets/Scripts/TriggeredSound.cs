using UnityEngine;

public class TriggeredSound : MonoBehaviour
{
    public AudioSource soundEffect;
    bool audioPlayed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!audioPlayed && other.CompareTag("Player"))
        {
            soundEffect.Play();
            audioPlayed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioPlayed = false;
        }
    }
}
