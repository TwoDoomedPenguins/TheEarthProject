﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using bodenArten = CellControl.BODENARTEN;


public class StorageButtonClick : MonoBehaviour {

    public StorageWindow stoWindow;
    public PlayerAttributeControl pMaster;



	// Use this for initialization
	void Awake () {

        stoWindow = gameObject.transform.parent.gameObject.transform.parent.gameObject.GetComponent<StorageWindow>();
        pMaster = GameObject.Find("01_Player").GetComponent<PlayerAttributeControl>();

	} // END Start
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StorageButtonClicked()
    {

        Dictionary<string, StorageMain> rMasterDic = stoWindow.stoMaster.stoDictionary;

        if (rMasterDic["Storage"].currentLevel < rMasterDic["Storage"].maxLevel)
        {

            if (pMaster.playerMoney >= rMasterDic["Storage"].costsMoney[rMasterDic["Storage"].currentLevel])
            {

                pMaster.playerMoney -= rMasterDic["Storage"].costsMoney[rMasterDic["Storage"].currentLevel];
                stoWindow.maxStorageValue += rMasterDic["Storage"].valueStep[rMasterDic["Storage"].currentLevel];
                rMasterDic["Storage"].currentLevel++;



            }
        }


    } // END StorageButtonClick
     


}