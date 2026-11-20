using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class radioDialogueManager : MonoBehaviour
{
    public List<audioLineEntry> radioLineEntry = new(); //on créé une liste
    public TextMeshProUGUI radioSubUI;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(radioScriptLoop());
    }

    IEnumerator radioScriptLoop()
    {
        Restart:
        foreach(audioLineEntry line in radioLineEntry)
        {   
            Debug.Log("Tentative de passer un dialogue");
            if(line.lineTxt != "")
            {
                if(line.lineTime != 0)
                {
                    Debug.Log("Dialogue correct");
                    radioSubUI.text = line.lineTxt;
                    yield return new WaitForSeconds(line.lineTime); // attends lineTime secondes avant de passer à la prochaine ligne
                }
            }
            else goto Restart;            
        }
    }

    // public void displayRadioLine()
    // {
        
    // }
}