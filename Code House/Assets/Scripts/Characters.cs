using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character {

    public class Characters
    {
        private string characterName;
        private byte range;
        private bool questGiver;
        private GameObject player;

        public Characters() {
            characterName = "Default";
            range = 0;
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

        public void setPlayer() {
            player = GameObject.Find("Player");
        }

        public Vector3 getPlayerPostion() {
            return player.transform.position;
        }

        public GameObject Player {
            get => player = player;
        }

    }

}
