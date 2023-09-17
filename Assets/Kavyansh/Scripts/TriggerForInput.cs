 using UnityEngine;

public class TriggerForInput : MonoBehaviour
{
    [SerializeField] GameObject _inputField;

    private void Start()
    {
        _inputField.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (_inputField != null)
            {
                _inputField.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (_inputField != null)
            {
                _inputField.SetActive(false);
            }
        }
    }
}
