using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PasswordForChest : MonoBehaviour
{
    [SerializeField] TMP_InputField _passwordThatwillPlayerPut;
    [SerializeField] GameObject _inputField;
    [SerializeField] GameObject _submitButton;
    [SerializeField] string _actualPassword;

    public void PasswordSystem()
    {
        if(_passwordThatwillPlayerPut.text == _actualPassword)
        {
            _inputField.SetActive(false);
            _submitButton.SetActive(false);
        }
        _passwordThatwillPlayerPut.text = string.Empty;
    }
}
