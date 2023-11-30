using UnityEngine;
public class Teleporter : MonoBehaviour
{
    [SerializeField] Transform _location;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = _location.position;
            Camera.main.transform.position = _location.position;
        }
    }
}