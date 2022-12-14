using System;
using UnityEngine;
using System.Xml;
using System.Collections.Generic;
using Game.GuideDate;
using GameDefine;
using Game.Resource;

public class ReadAdvancedGuideConfig
{

    XmlDocument xmlDoc = null;

    public ReadAdvancedGuideConfig(string xmlFilePath)
    {
        //TextAsset xmlfile = Resources.Load(xmlFilePath) as TextAsset;
        ResourceUnit xmlfileUnit = ResourcesManager.Instance.loadImmediate(xmlFilePath, ResourceType.ASSET);
        TextAsset xmlfile = xmlfileUnit.Asset as TextAsset;

        if (!xmlfile)
        {
            Debug.LogError(" error infos: 没有找到指定的xml文件：" + xmlFilePath);
        }

        xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xmlfile.text);

        XmlNodeList infoNodeList = xmlDoc.SelectSingleNode("LowerGuide").ChildNodes;

        for (int i = 0; i < infoNodeList.Count; i++)//(XmlNode xNode in infoNodeList)
        {
            if ((infoNodeList[i] as XmlElement).GetAttributeNode("Taskid") == null) continue;

            string typeName = (infoNodeList[i] as XmlElement).GetAttributeNode("Taskid").InnerText;

            AdvancedGuideInfo info = new AdvancedGuideInfo();
            info.Taskid = Convert.ToInt32(typeName);
            foreach (XmlElement xEle in infoNodeList[i].ChildNodes)
            {
                #region 搜索
                switch (xEle.Name)
                {
                    case "Title":
                        info.Title = xEle.InnerText;
                        break;
                    case "Event":
                        info.Event = (GuideEventType)Convert.ToInt32(xEle.InnerText);
                        break;
                    case "EventValue0":
                        info.EventValue0 = GameMethod.ResolveToVector3(xEle.InnerText);
                        break;
                    case "EventValue1":
                        info.EventValue1 = GameMethod.ResolveToIntList(xEle.InnerText);
                        break;
                    case "EventValue2":
                        info.EventValue2 = Convert.ToInt32(xEle.InnerText);
                        break;
                    case "Content":
                        info.Content = xEle.InnerText;
                        break;
                    case "CDTime":
                        info.CDTime = Convert.ToSingle(xEle.InnerText);
                        break;
                    case "LimitTime":
                        info.LimitTime = Convert.ToInt32(xEle.InnerText);
                        break;
                    case "SmallTitle":
                        info.SmallTitle = xEle.InnerText;
                        break;
                    case "PrefabID":
                        info.PrefabID = xEle.InnerText;
                        break;
                    case "PicID":
                        info.PicID = xEle.InnerText;
                        break;
                }
                #endregion
            }
            ConfigReader.advancedGuideInfoDict.Add(info.Taskid, info);
        }
    }
}

public class AdvancedGuideInfo
{
    public int Taskid;
    public string Title;
    public GuideEventType Event;
    public Vector3 EventValue0;
    public List<int> EventValue1;
    public int EventValue2;
    public string Content;
    public float CDTime;
    public int LimitTime;
    public string SmallTitle;
    public string PrefabID;
    public string PicID;
}

public enum GuideEventType
{
    mAwayToBornPoint = 1,
    mGetCpPoint = 2,
    mEnterBuild = 3,
    mFullAngry = 4,
    mAbsorbSuccess = 5,
    mPlayerReborn = 6,
    mEnterAltar = 7,
    mPlayerLevelTo = 8,
    mBuildBreak = 9,
}

