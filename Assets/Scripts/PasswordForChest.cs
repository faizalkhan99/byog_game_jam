using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PasswordForChest : MonoBehaviour
{
    [SerializeField] TMP_InputField _passwordThatwillPlayerPut;
    [SerializeField] GameObject _inputField;
    [SerializeField] GameObject _submitButton , key;
    [SerializeField] string _actualPassword;
    [SerializeField] private AudioClip _KeyDrop;


    public void PasswordSystem()
    {
        if (gameObject != null)
        {
            if (_passwordThatwillPlayerPut.text == _actualPassword)
            {
                _inputField.SetActive(false);
                _submitButton.SetActive(false);
                key.SetActive(true);
                AudioManager.Instance.OneShotPlay(_KeyDrop);
                Destroy(gameObject);
            }
        }
        
        _passwordThatwillPlayerPut.text = string.Empty;
    }
}
