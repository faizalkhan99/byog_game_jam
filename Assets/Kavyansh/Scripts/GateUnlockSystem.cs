using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GateUnlockSystem : MonoBehaviour
{
    [SerializeField] int _maxLenOfWords;
    [SerializeField] int _wordCounter;
    [SerializeField] TextMeshProUGUI _gateUnlocked;
    public int _wordInventory;

    void Start()
    {
        _gateUnlocked.enabled = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Word"))
        {
            if (_wordInventory == 0)
            {
                other.gameObject.SetActive(false);
                _wordInventory++;
                _wordCounter++;
            }
        }
        if (other.gameObject.CompareTag("Gate"))
        {
            _wordInventory = 0;
            if(_wordCounter == _maxLenOfWords)
            {
                _gateUnlocked.enabled = true;
            }
        }
    }
    
}
