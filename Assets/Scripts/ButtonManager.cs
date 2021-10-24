using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    private Button btn;
    [SerializeField]private RawImage buttonImage;
   
    private int _itemId;

    private Sprite _buttontexture;
    
    public Sprite ButtonTexture
    {
        set
        {
            _buttontexture = value;
            buttonImage.texture = _buttontexture.texture;
        }
    }

    public int ItemId
    {
        set
        {
            _itemId = value;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SelectObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (UIManager.Instance.OnEntered(gameObject))
        {
            transform.DOScale(Vector3.one * 2, 0.3f);
        }
        else
        {
            transform.DOScale(Vector3.one, 0.3f);
        }
    }

    private void SelectObject()
    {
        DataHandler.Instance.SetFurniture(_itemId);
    }
}
