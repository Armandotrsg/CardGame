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
    private List<CardScriptable> _dataList;

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

    private CardScriptable _currentCard;

    void Start()
    {
        Assert.IsNotNull(_dataList, "LA LISTA DE DATOS NO PUEDE SER NULA");
        _currentCard = GetRandomCard(_dataList);
        _name.text = _currentCard._name.ToUpper();
        _type.text = string.Format("[{0}]", _currentCard._type.ToUpper());
        _description.text = _currentCard._description;
        _attack.text = _currentCard._attack;
        _defense.text = _currentCard._defense;
        _image.sprite = _currentCard._sprite;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnMouseEnter() {
        transform.position = new Vector3(transform.position.x, transform.position.y + _moveOnHover, transform.position.z);
    }

    void OnMouseDown() {
        _guiManager._name.text = _currentCard._name;
        _guiManager._type.text = _currentCard._type;
        _guiManager._description.text = _currentCard._description;
        _guiManager._attack.text = _currentCard._attack;
        _guiManager._defense.text = _currentCard._defense;
    }

    void OnMouseExit() {
        transform.position = new Vector3(transform.position.x, transform.position.y - _moveOnHover, transform.position.z);
    }

    private CardScriptable GetRandomCard(List<CardScriptable> cards)
    {
        int randomIndex = Random.Range(0, cards.Count);
        return cards[randomIndex];
    }
}
