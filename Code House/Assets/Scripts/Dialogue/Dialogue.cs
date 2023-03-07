using System.Collections;
using System.Collections.Generic;
using Character;
using UnityEngine;
using TMPro;

namespace Character.Behaviour.Conversation {

        public class Dialogue : MonoBehaviour {

            private Transform playerLocation;
            public string characterName;
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
                
                if (Vector3.Distance(myCharacter.getPlayerPostion(), transform.position) <= myCharacter.Range) {

                    if (Input.GetKeyDown("f") && this.inDialogue == false) {

                        dialogueOpen();

                    } else if (Input.GetKeyDown("f") && this.inDialogue == true) {

                        dialogueClose();

                    }
                    
                } else {

                    dialogueClose();

                }
                
            }

            private void dialogueOpen() {

                myCharacter.CharacterName = this.characterName;
                this.characterNameHolder.SetText(myCharacter.CharacterName);
                this.dialogueSystem.SetActive(true);
                this.inDialogue = true;

            }

            private void dialogueClose() {

                this.dialogueSystem.SetActive(false);
                this.inDialogue = false;

            }

    }

}

