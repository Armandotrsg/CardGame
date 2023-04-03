using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Carta", menuName = "Mis Scriptable Objects/Carta", order = 1)]

public class CardScriptable : ScriptableObject
{
    public string _name;
    public string _type;
    public string _description;
    public string _attack;
    public string _defense;
    public Sprite _sprite;    
}
