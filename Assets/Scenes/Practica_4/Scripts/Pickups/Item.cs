using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace P4
{
    public class Item : ScriptableObject
    {
        
        public string itemName;
        public Sprite icon;
        // Start is called before the first frame update

        public virtual void Use()
        {
           
        }

    }
}