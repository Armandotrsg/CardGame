using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using TMPro;

public class CardLoader : MonoBehaviour
{
    [SerializeField]
    private CardScriptable _data;

    [SerializeField]
    private TMP_Text _name;

    [SerializeField]
    private TMP_Text _type;

    [SerializeField]
    private TMP_Text _description;

    [SerializeField]
    private TMP_Text _attack;

    [SerializeField]
    private TMP_Text _defense;

    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        Assert.IsNotNull(_data, "LOS DATOS DEL PREFAB NO PUEDEN SER NULOS");
        _name.text = _data._name.ToUpper();
        _type.text = string.Format("[{0}]", _data._type.ToUpper());
        _description.text = _data._description;
        _attack.text = _data._attack;
        _defense.text = _data._defense;
        _spriteRenderer.sprite = _data._sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
