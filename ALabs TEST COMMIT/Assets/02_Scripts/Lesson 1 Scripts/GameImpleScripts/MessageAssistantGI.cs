using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessageAssistantGI : MonoBehaviour
{
    [SerializeField] private TMP_Text messageText;
    [SerializeField] private TextWriter textWriter;
    [SerializeField] private float msgspeed = 0.05f;
    [SerializeField] private GameObject nextButton;
    [SerializeField] private GameObject start;

    public int messagechoiceinc = 0;

    private string[] messagesArray =
        {"Welcome to the Finite State Machine Factory!\n\nA place where you will start your journey in learning all about Automata Theory!",

         "Before we jump right into the game, let's talk about what Automata Theory is all about.",

         "Imagine you are dealing with building blocks for computers and programming...\n\n" +
         "Automata Theory is like exploring the rules and structures that controls these building blocks!",

         "In this case, lets explore how Automata theory works in a Factory Setting!"
    };
    private void Start()
    {
        MessageChoice(0);
        start.SetActive(false);
    }

    private void Update()
    {

    }

    public void Message(string message, TMP_Text text)
    {
        textWriter.AddWriter(text, message, msgspeed, true);

    }

    public void MessageChoice(int choice)
    {
        Message(messagesArray[choice], messageText);
        return;
    }

    public void nextButtonFunc()
    {
        if(messagechoiceinc >= messagesArray.Length - 1)
        {
            start.SetActive(true);
            Destroy(nextButton);
        }

        if(messagechoiceinc < messagesArray.Length - 1)
        {
            messagechoiceinc++;
            MessageChoice(messagechoiceinc);
            Debug.Log("Message choice Inc on: # " + messagechoiceinc);
        }

    }
}
