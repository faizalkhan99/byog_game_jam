using UnityEngine;
public class Lock : MonoBehaviour
{
    public string _lookingFor;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMove _pm = other.gameObject.GetComponent<PlayerMove>();
            if (_pm != null)
            {
                if (_pm._hasKey)
                {
                    if (_lookingFor == _pm._keyValue)
                    {
                        _pm._hasKey = false;
                        Destroy(_pm._key);
                    }
                }
            }
        }
    }
}