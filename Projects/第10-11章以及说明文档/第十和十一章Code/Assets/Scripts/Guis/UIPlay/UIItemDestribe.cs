using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Game.GameEntity;
using GameDefine;
using MO.MOBA.Tools;
using Game.Resource;

public class UIItemDestribe : MonoBehaviour
{

    public static UIItemDestribe Instance;

    public GameObject desObj
    {
        private set;
        get;
    }

    private UILabel ItemName = null;
    private UILabel ItemDes = null;
    private UILabel ItemCost = null;

    void Awake()
    {
        Instance = this;

        //desObj = GameObject.Instantiate(Resources.Load(GameDefine.GameConstDefine.ItemDestribe)) as GameObject;
        ResourceUnit desObjUnit = ResourcesManager.Instance.loadImmediate(GameDefine.GameConstDefine.ItemDestribe, ResourceType.PREFAB);
        desObj = GameObject.Instantiate(desObjUnit.Asset) as GameObject;
        
        desObj.transform.parent = transform;
        desObj.transform.localScale = Vector3.one;
        desObj.transform.localPosition = Vector3.zero;

        ItemName = desObj.transform.Find("Item_Name").GetComponent<UILabel>();
        ItemDes = desObj.transform.Find("Item_Describe").GetComponent<UILabel>();
        ItemCost = desObj.transform.Find("Item_Gold").GetComponent<UILabel>();

        SetSelfActive(false);
    }

    void SetSelfActive(bool value)
    {
        gameObject.SetActive(value);
    }

    public void OpenItemDestribe(bool show, int id)
    {
        if (show)
        {
            if (ConfigReader.ItemXmlInfoDict.ContainsKey(id))
            {
                ItemConfigInfo item = ConfigReader.ItemXmlInfoDict[id];
                ItemName.text = item.sNameCh;
                ItemCost.text = item.n32CPCost.ToString();
                ItemDes.text = item.sDescribe;

                SetSelfActive(true);
            }
        }
        else
        {
            SetSelfActive(false);
        }
    }
}

