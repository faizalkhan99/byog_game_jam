using UnityEngine;
public class Key2Summoner : MonoBehaviour
{
    [SerializeField] GameObject box1;
    [SerializeField] GameObject box2;
    [SerializeField] GameObject box3;
    [SerializeField] GameObject key2;

    private void Update()
    {
        if(box1 == null && box2 == null && box3 == null)
        {
            if(key2 != null)
                key2.SetActive(true);
        }
    }
}