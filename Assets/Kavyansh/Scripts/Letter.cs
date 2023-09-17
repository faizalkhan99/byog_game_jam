using UnityEngine;
public class Letter : MonoBehaviour
{
    [SerializeField] GameObject _letter;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _letter.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _letter.SetActive(false);
        }
    }
}