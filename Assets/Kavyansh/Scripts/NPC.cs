using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [TextArea(3, 10)]
    [SerializeField] string[] _dialouges;
    [SerializeField] TextMeshProUGUI _dialougeBox;
    [SerializeField] GameObject _canvas;
    int i = 0;
    bool _lockPlayer;

    private void Start()
    {
        _dialougeBox.text = "";
        _canvas.SetActive(false);
    }
    public void NextDialouge()
    {
        i++;
        if (i < _dialouges.Length)
        {
            _dialougeBox.text = _dialouges[i];
        }
        else
        {
            EndDialogue();
        }
    }
    public void EndDialogue()
    {
        PlayerMove _pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        if (_pm != null)
        {
            _pm._canMove = true;
            _pm.transform.parent = null;
        }
        _lockPlayer = false;
        _canvas.SetActive(false);
    }
    public void DialogueTrigger()
    {
        i = 0;
        if(_dialouges[i] != null)
        {
            _dialougeBox.text = _dialouges[i];
        }
    }
    private void Update()
    {
        PlayerMove _pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        if (_pm != null)
        {
            if (_lockPlayer)
            {
                _pm.transform.localPosition = Vector2.MoveTowards(_pm.transform.localPosition,GetComponent<Collider2D>().offset, Time.deltaTime * 2);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMove _pm = other.gameObject.GetComponent<PlayerMove>();
            if (_pm != null)
            {
                _pm._canMove = false;
            }
            _lockPlayer = true;
            other.transform.parent = transform;
            _canvas.SetActive(true);
            DialogueTrigger();
        }
    }
}