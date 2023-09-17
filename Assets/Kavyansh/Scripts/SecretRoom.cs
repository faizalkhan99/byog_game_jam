using UnityEngine;

public class SecretRoom : MonoBehaviour
{
    public static bool key1;
    public static bool key2;
    [SerializeField] GameObject secretDoor;

    private void Start()
    {
        key1 = false;
        key2 = false;
        secretDoor.SetActive(false);

    }
    private void Update()
    {
        if (key1 && key2) 
        {
            secretDoor.SetActive(true);
        }
    }
}
