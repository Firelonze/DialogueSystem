using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogeuManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    private Queue<string> senteces;

    void Start()
    {
        senteces = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        nameText.text = dialogue.name;

        senteces.Clear();
        foreach (string sentece in dialogue.sentances)
        {
            senteces.Enqueue(sentece);
        }

        DisplayNextSentance();
    }

    public void DisplayNextSentance()
    {
        if (senteces.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = senteces.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("Dialogue has ended with");
    }
}
