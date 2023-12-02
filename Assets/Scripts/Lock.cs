using TMPro;
using UnityEngine;
public class Lock : MonoBehaviour
{
    public string _lookingFor;
    private int _txtLock = 0;
    [SerializeField] private TextMeshProUGUI _needKeys;
    [SerializeField] private GameObject _arrowImg;
    private void Start()
    {
        _arrowImg.SetActive(false);
        _needKeys.text = "";
    }
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
                        if(_pm._keyValue == "1")
                        {
                            SecretRoom.key1 = true;
                            _pm._key.transform.parent = transform;
                            _pm._key.transform.position = transform.position;
                        }
                        if(_pm._keyValue == "2")
                        {
                            SecretRoom.key2 = true;
                            _pm._key.transform.parent = transform;
                            _pm._key.transform.position = transform.position;
                        }
                        _pm._hasKey = false;
                    }
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMove _pm = other.gameObject.GetComponent<PlayerMove>();
        if (other.CompareTag("Player") && (!_pm._hasKey) && (_txtLock == 0)){
            _needKeys.text = "Need something to put in these maybe?";
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        PlayerMove _pm = other.gameObject.GetComponent<PlayerMove>();
        if (other.CompareTag("Player") && (!_pm._hasKey))
        {
            _needKeys.text = "";
        }
    }
    public void Updatetext(string txt)
    {
        _txtLock = 1; // _txtLock = 1
        _needKeys.text = txt;
    }
    public void ShowArrow()
    {
        _arrowImg.SetActive(true);
    }
}