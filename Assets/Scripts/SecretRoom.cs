using UnityEngine;

public class SecretRoom : MonoBehaviour
{
    public static bool key1;
    public static bool key2;
    [SerializeField] GameObject secretDoor;
    [SerializeField] private AudioClip _BothkeysCollected;
    private int _counter = 0;

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
            _counter = 1;
        }
    }
}
