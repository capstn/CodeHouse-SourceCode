using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public Transform player;
    public GameObject dialogueSystem;
    public TMP_Text characterNameHolder;
    public TMP_Text characterDialogueHolder;

    public float range; // how far can the character detect
    public string characterName = ""; // character name
    public string[] text = new string[5]; // string of dialogues
    private bool dialogueClosed; // if the dialogue is closed
    private bool canDialogue; // if the player is within reach for conversation
    private bool dialogue; // if the conversation is ongoing
    private bool nextDialogue; // if the player clicked next
    private byte dialogueNum = 0; // for the number of dialogues in the string
    public byte dialogueMax; // just minus 1 to the total string of dialogues

    private void Start() {

        dialogueClose();

    }

    private void Update() {

        if (Vector3.Distance(player.position, transform.position) <= range) {
            
            canDialogue = true;

        } else {

            canDialogue = false;

        }

        if (canDialogue == true) {

            if (Input.GetKeyDown("f") && dialogue == false) {
                dialogueClosed = false;
                setName();
                setDialogue(dialogueNum);
                dialogueOpen();

            } else if (Input.GetKeyDown("f") && dialogue == true) {

                dialogueClose();

            }

            if (dialogueClosed == false && Input.GetMouseButtonDown(0)) {

                nextDialogue = true;

                if (nextDialogue == true) {
                    if (dialogueNum < dialogueMax) {
                        dialogueNum += 1;
                        setDialogue(dialogueNum);
                    } else {
                        dialogueNum = 0;
                        dialogueClosed = true;
                        dialogueClose();
                    }
                } else if (dialogueClosed == true) {
                    dialogueNum = 0;
                }
            }

        } else {

            if (dialogueClosed == false) {
                dialogueClose();
                dialogueClosed = true;
            }

        }

    }

    private void setName() {
        characterNameHolder.SetText(characterName);
    }

    private void setDialogue(byte dialogueNum) {
        characterDialogueHolder.SetText(text[dialogueNum]);
    } 

    public void dialogueOpen() {

        this.dialogue = true;

        if (this.dialogue == true) {

            dialogueSystem.SetActive(true);

        }
    }

    public void dialogueClose() {

        this.dialogue = false;

        if (this.dialogue == false) {

            dialogueSystem.SetActive(false);

        }
    }
    
}
