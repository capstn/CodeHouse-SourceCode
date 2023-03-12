using System.Collections;
using System.Collections.Generic;
using Character;
using Character.Behaviour.Conversation;
using UnityEngine;
using TMPro;

namespace Character.Systems.Quest {

    public class Quest : Dialogue 
    {
        private int missionCount;

        public Quest() {

            Debug.Log("Quest system loaded.");

        }

        Characters myCharacter = new Characters();

        public void initiateQuest()  {

            Debug.Log("Quest added");

        }


    }

}