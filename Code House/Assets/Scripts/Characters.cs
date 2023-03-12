using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character {

    public class Characters
    {
        private string characterName;
        private byte range;
        private bool inRange;
        private bool canDialogue;
        private bool questGiver;
        private GameObject player;

        public Characters() {
            characterName = "Default";
            range = 0;
            inRange = false;
            canDialogue = false;
            questGiver = false;
        }

        public string CharacterName {
            set => characterName = value;
            get => characterName;
        }

        public byte Range {
            set => range = value;
            get => range;
        }

        public bool InRange {
            set => inRange = value;
            get => inRange;

        }
        
        public bool QuestGiver {
            set => questGiver = value;
            get => questGiver;

        }

        public void setPlayer() {
            player = GameObject.Find("Player");
        }

        public Vector3 getPlayerPostion() {
            return player.transform.position;
        }

        public GameObject Player {
            get => player;
        }

    }

}
