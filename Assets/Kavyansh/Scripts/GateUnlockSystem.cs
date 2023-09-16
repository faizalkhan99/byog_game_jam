using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GateUnlockSystem : MonoBehaviour
{
    GameObject _tempKey;
    [SerializeField] int _maxLenOfWords;
    [SerializeField] int _wordCounter;
    [SerializeField] TextMeshProUGUI _gateUnlocked;
    [SerializeField] int _wordInventory;
    [SerializeField] Vector3 offset;
    [SerializeField] string tag1 = "Word";
    [SerializeField] string tag2 = "Word2";
    [SerializeField] string tag3 = "Word3";
    [SerializeField] string gate_tag = "Gate";
    [SerializeField] string gate_tag2 = "Gate2";
    [SerializeField] string gate_tag3 = "Gate3";


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
                other.gameObject.transform.position = transform.position + offset;
                other.gameObject.transform.parent = transform;
                _tempKey = other.gameObject;
                _wordInventory++;
                _wordCounter++;
            }
        }
        if (other.gameObject.CompareTag("Gate"))
        {
            _wordInventory = 0;
            if (_tempKey == null)
            {
                return;
            }
            if (_tempKey.gameObject.tag == tag1)
            {
                Destroy(_tempKey.gameObject);
            }
            if(_wordCounter == _maxLenOfWords)
            {
                _gateUnlocked.enabled = true;
            }
        }
        
        if (other.gameObject.CompareTag("Word2"))
        {
            if (_wordInventory == 0)
            {
                other.gameObject.transform.position = transform.position + offset;
                other.gameObject.transform.parent = transform;
                _tempKey = other.gameObject;
                _wordInventory++;
                _wordCounter++;
            }
        }

        if (other.gameObject.CompareTag("Gate2"))
        {
            _wordInventory = 0;
            if(_tempKey == null)
            {
                return;
            }
            if (_tempKey.gameObject.tag== tag2)
            {
                Destroy(_tempKey.gameObject);
            }
            if (_wordCounter == _maxLenOfWords)
            {
                _gateUnlocked.enabled = true;
            }
        }

        if (other.gameObject.CompareTag("Word3"))
        {
            if (_wordInventory == 0)
            {
                other.gameObject.transform.position = transform.position + offset;
                other.gameObject.transform.parent = transform;
                _tempKey = other.gameObject;
                _wordInventory++;
                _wordCounter++;
            }
        }
        if (other.gameObject.CompareTag("Gate3"))
        {
            _wordInventory = 0;
            if (_tempKey == null)
            {
                return;
            }
            if (_tempKey.gameObject.tag == tag3)
            {
                Destroy(_tempKey.gameObject);
            }
            if (_wordCounter == _maxLenOfWords)
            {
                _gateUnlocked.enabled = true;
            }
        }
    }
    
}
