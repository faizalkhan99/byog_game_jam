using TMPro;
using UnityEngine;
using System.Collections.Generic;
public class NPC_Dialogues : MonoBehaviour
{
    TextMeshProUGUI _npcDialogueText, _playerDialogueText;
    [SerializeField] GameObject _npcDialogueBox, _playerDialogueBox;



    [SerializeField] List<string> Dialogues = new List<string>();

    private void Awake()
    {
        _npcDialogueText = GetComponentInChildren<TextMeshProUGUI>();
        _playerDialogueText = GameObject.FindGameObjectWithTag("Player").GetComponent<TextMeshProUGUI>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

        }
    }
}