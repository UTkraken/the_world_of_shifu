using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DataObject
{
    [System.Serializable]
    public class Card : MonoBehaviour
    {
        public int id;
        public string symbol;
        public TextMeshProUGUI textSymbol;

        //private Sprite ThisImage;

        public Card() { }

        public Card(int id, string symbol, string textSymbol)
        {
            this.id = id;
            this.symbol = symbol;
            this.textSymbol = textSymbol;
            //this.ThisImage = ThisImage;
        }

    }
}