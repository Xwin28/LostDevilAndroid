using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
	public Text nameText;
	public Text dialogueText;
	public I18nTextTranslator _i18NText;
	//public Animator animator;

	private Queue<string> sentences;
	public string[] _sentence;
	public string[] _choose_1, _choose_2;
	public int[] _c1, _c2;
	public Text _btnText_1, _btnText_2;
	public int Now_position;// vị trí hiện tạo trong array
	// Use this for initialization
	void Start()
	{
		sentences = new Queue<string>();
		
	}

	public void StartDialogue(Dialogue dialogue)
	{
		//animator.SetBool("IsOpen", true);
		_sentence = new string[dialogue.sentences.Length];
		_choose_1 = new string[dialogue.Choose_one.Length];
		_choose_2 = new string[dialogue.Choose_two.Length];
		_c1 = new int[dialogue.c1.Length];
		_c2 = new int[dialogue.c2.Length];
		nameText.text = dialogue.name;
		
		//sentences.Clear();

	
		for( int i = 0; i < dialogue.sentences.Length; i++)
        {
			_sentence[i] = dialogue.sentences[i];
		}

		for (int i = 0; i < dialogue.Choose_one.Length; i++)
		{
			_choose_1[i] = dialogue.Choose_one[i];
		}

		for (int i = 0; i < dialogue.Choose_two.Length; i++)
		{
			_choose_2[i] = dialogue.Choose_two[i];
		}

		for (int i = 0; i < dialogue.c1.Length; i++)
		{
			_c1[i] = dialogue.c1[i];
		}

		for (int i = 0; i < dialogue.c2.Length; i++)
		{
			_c2[i] = dialogue.c2[i];
		}
		DisplaySentence(0);
		Now_position = 0;
	}


	public void DisplaySentence(int i)
	{

		// Chữ hiện ra dần dần, Cả Sentences lẫn các lựa chọn
		//string sentence = _sentence[i];
		//string c1 = _choose_1[i];
		//string c2 = _choose_2[i];
		string sentence = _i18NText.GetSenten(_sentence[i]);
		string c1 = _i18NText.GetSenten(_choose_1[i]);
		string c2 = _i18NText.GetSenten(_choose_2[i]);
		Now_position = i;
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence,c1,c2));
	}

	// Chữ hiện ra dần dần
	IEnumerator TypeSentence(string sentence, string c1, string c2)
	{
		dialogueText.text = "";
		_btnText_1.text = "";
		_btnText_2.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}

		foreach (char letter in c1.ToCharArray())
        {
			_btnText_1.text += letter;
			yield return null;
		}
		foreach (char letter in c2.ToCharArray())
		{
			_btnText_2.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		//animator.SetBool("IsOpen", false);
	}

}
