using UnityEngine;

public class LetterBGM : MonoBehaviour
{
    [SerializeField] private AudioClip _audioToPlay;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("enter");
            AudioManager.Instance.Play(_audioToPlay);
        }
    }
}