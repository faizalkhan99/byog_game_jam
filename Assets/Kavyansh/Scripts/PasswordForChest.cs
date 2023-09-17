using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PasswordForChest : MonoBehaviour
{
    [SerializeField] TMP_InputField _passwordThatwillPlayerPut;
    [SerializeField] GameObject _inputField;
    [SerializeField] GameObject _submitButton;
    [SerializeField] string _actualPassword;
    [SerializeField] GameObject _chest;
    // Start is called before the first frame update
    void Start()
    {
        _chest.SetActive(false);
    }

    public void PasswordSystem()
    {
        if(_passwordThatwillPlayerPut.text == _actualPassword)
        {
            _chest.SetActive(true);
            _inputField.SetActive(false);
            _submitButton.SetActive(false);
        }
        _passwordThatwillPlayerPut.text = string.Empty;
    }
}
