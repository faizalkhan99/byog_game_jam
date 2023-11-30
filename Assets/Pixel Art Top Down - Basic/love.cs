using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class love : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _love;
    void Start()
    {
        _love.text = "";
        StartCoroutine(Lovetxt());
    }

    public IEnumerator Lovetxt()
    {
        yield return new WaitForSeconds(2.0f);
        _love.text = "OF LOVE <3";
    }


}
