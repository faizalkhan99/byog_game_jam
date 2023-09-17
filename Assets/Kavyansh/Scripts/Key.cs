using UnityEngine;
public class Key : MonoBehaviour
{
    public string _pass;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMove _pm = other.gameObject.GetComponent<PlayerMove>();
            if (_pm != null)
            {
                _pm._hasKey = true;
                _pm._keyValue = _pass;
                _pm._key = gameObject;
            }
            transform.parent = other.gameObject.transform;
            GetComponent<Collider2D>().enabled = false;
            transform.localPosition = Vector2.up;
        }
    }
}