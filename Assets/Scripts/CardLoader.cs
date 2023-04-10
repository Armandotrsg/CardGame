using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using TMPro;
using UnityEngine.UI;

public class CardLoader : MonoBehaviour
{
    [SerializeField]
    private GUIManager _guiManager;

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
    private Image _image;

    private float _moveOnHover = 1f;
    void Start()
    {
        Assert.IsNotNull(_data, "LOS DATOS DEL PREFAB NO PUEDEN SER NULOS");
        _name.text = _data._name.ToUpper();
        _type.text = string.Format("[{0}]", _data._type.ToUpper());
        _description.text = _data._description;
        _attack.text = _data._attack;
        _defense.text = _data._defense;
        _image.sprite = _data._sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter() {
        transform.position = new Vector3(transform.position.x, transform.position.y + _moveOnHover, transform.position.z);
    }

    void OnMouseDown() {
        _guiManager._name.text = _data._name;
        _guiManager._type.text = _data._type;
        _guiManager._description.text = _data._description;
        _guiManager._attack.text = _data._attack;
        _guiManager._defense.text = _data._defense;

    }

    void OnMouseExit() {
        transform.position = new Vector3(transform.position.x, transform.position.y - _moveOnHover, transform.position.z);
    }

}
