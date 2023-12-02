using TMPro;
using UnityEngine;

public class SecretRoom : MonoBehaviour
{
    private int _counter = 0;

    public static bool key1;
    public static bool key2;

    Lock _loc;

    [SerializeField] GameObject secretDoor;
    
    [SerializeField] private AudioClip _BothkeysCollected;
    private void Awake()
    {
        _loc = GameObject.FindGameObjectWithTag("Lock").GetComponent<Lock>();
    }
    private void Start()
    {
        key1 = false;
        key2 = false;
        secretDoor.SetActive(false);

    }
    private void Update()
    {
        if (key1 && key2 && _counter == 0) 
        {
            AudioManager.Instance.OneShotPlay(_BothkeysCollected);
            secretDoor.SetActive(true);
            _loc.ShowArrow();
            _loc.Updatetext("I did it!!!");
            _counter = 1;
        }
    }
}
