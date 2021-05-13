using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
	public Dialogue dialogue;
    public DialogueManager _DialogueManager;
    public GameObject _Cavas;

    private void Start()
    {
        _Cavas.SetActive(true);
        TriggerDialogue();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.gameObject.CompareTag("Player"))
        {
            _Cavas.SetActive(true);
            TriggerDialogue();

        }
    }

    public void TriggerDialogue()
	{
		_DialogueManager.StartDialogue(dialogue);
	}

    public void ShowDialogue()
    {
        _Cavas.SetActive(true);
        TriggerDialogue();
    }

}
