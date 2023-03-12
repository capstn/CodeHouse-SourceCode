using System.Collections;
using System.Collections.Generic;
using Character;
using UnityEngine;
using TMPro;

namespace Character.Behaviour.Conversation {

        public class Dialogue : MonoBehaviour {

            private Transform playerLocation;
            public string characterName;
            public bool canDialogue;
            public byte characterDialogueNumber;
            public string[] characterDialogue = new string[5];
            private int dialogueCount = 1;
            public byte range;
            private bool inDialogue;

            public GameObject dialogueSystem;
            public TMP_Text characterNameHolder;
            public TMP_Text characterDialogueHolder;

            Characters myCharacter = new Characters();

            private void Start() {
                myCharacter.Range = this.range;
                myCharacter.setPlayer();

            }

            private void Update() {

                if (this.canDialogue == false) {

                    this.enabled = false;

                } else {

                    if (Vector3.Distance(myCharacter.getPlayerPostion(), transform.position) <= myCharacter.Range) {

                        if (Input.GetKeyDown("f") && this.inDialogue == false) {

                            dialogueOpen();

                        } else if (Input.GetKeyDown("f") && this.inDialogue == true) {

                            dialogueClose();

                        }

                        if (Input.GetMouseButtonDown(0) && this.inDialogue == true) {

                            setDialogue(this.dialogueCount);

                        }
                    
                    } else {

                        dialogueClose();

                    }

                }
                
            }

            private void dialogueOpen() {

                myCharacter.CharacterName = this.characterName;
                this.characterNameHolder.SetText(myCharacter.CharacterName);
                this.dialogueSystem.SetActive(true);
                this.inDialogue = true;

                setDialogue(this.dialogueCount);

            }

            private void setDialogue(int dialogueCount) {

                if (dialogueCount < this.characterDialogueNumber) {

                    this.characterDialogueHolder.SetText(characterDialogue[dialogueCount]);
                    this.dialogueCount += 1;

                } else {

                    dialogueClose();

                }
            }

            private void dialogueClose() {

                this.dialogueCount = 0;
                this.dialogueSystem.SetActive(false);
                this.inDialogue = false;

            }

    }

}

