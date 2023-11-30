using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    GameObject _player;
    [Range(0, 100)]
    [SerializeField] int _laziness;

    [SerializeField] Vector3 _offset;
    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _player.transform.position + _offset, _laziness * Time.deltaTime);
    }
}