﻿using UnityEngine;


namespace TMPro.Examples
{
    public class TMP_TextEventCheck : MonoBehaviour
    {

        public TMP_TextEventHandler TextEventHandler;

        void OnEnable()
        {
            if (TextEventHandler != null)
            {
                TextEventHandler.onCharacterSelection.AddListener(OnCharacterSelection);
                TextEventHandler.onSpriteSelection.AddListener(OnSpriteSelection);
                TextEventHandler.onWordSelection.AddListener(OnWordSelection);
                TextEventHandler.onLineSelection.AddListener(OnLineSelection);
                TextEventHandler.onLinkSelection.AddListener(OnLinkSelection);
            }
        }


        void OnDisable()
        {
            if (TextEventHandler != null)
            {
                TextEventHandler.onCharacterSelection.RemoveListener(OnCharacterSelection);
                TextEventHandler.onSpriteSelection.RemoveListener(OnSpriteSelection);
                TextEventHandler.onWordSelection.RemoveListener(OnWordSelection);
                TextEventHandler.onLineSelection.RemoveListener(OnLineSelection);
                TextEventHandler.onLinkSelection.RemoveListener(OnLinkSelection);
            }
        }


        void OnCharacterSelection(char c, int index)
        {
            ////debug.log("Character [" + c + "] at Index: " + index + " has been selected.");
        }

        void OnSpriteSelection(char c, int index)
        {
            ////debug.log("Sprite [" + c + "] at Index: " + index + " has been selected.");
        }

        void OnWordSelection(string word, int firstCharacterIndex, int length)
        {
            ////debug.log("Word [" + word + "] with first character index of " + firstCharacterIndex + " and length of " + length + " has been selected.");
        }

        void OnLineSelection(string lineText, int firstCharacterIndex, int length)
        {
            ////debug.log("Line [" + lineText + "] with first character index of " + firstCharacterIndex + " and length of " + length + " has been selected.");
        }

        void OnLinkSelection(string linkID, string linkText, int linkIndex)
        {
            ////debug.log("Link Index: " + linkIndex + " with ID [" + linkID + "] and Text \"" + linkText + "\" has been selected.");
        }

    }
}