﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectionScript : MonoBehaviour
{
    int item=1;
    public GameObject offchair, chandler, table, bed, bench, archair, archair2, stand, bcase, sink, sofa, couch, stove, fridge, couch2;
    public void onBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void onSelect()
    {
        PlayerPrefs.SetInt("item", item);
        SceneManager.LoadScene("ArScene");
    }
    public void Left()
    {  item--;
        switch(item)
        {
            case 0:
                item++;
                break ;
            case 1:
                offchair.SetActive(true);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 2:
                offchair.SetActive(false);
                chandler.SetActive(true);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 3:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(true);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 4:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(true);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 5:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(true);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 6:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(true);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 7:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(true);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 8:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(true);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 9:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(true);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 10:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(true);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 11:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(true);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 12:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(true);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 13:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(true);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 14:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(true);
                couch2.SetActive(false);
                break;
            case 15:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(true);
                break;

        }
    }
    public void Right()
    {
        item++;
        switch (item)
        {
            case 16:
                item--;
                break;
            case 1:
                offchair.SetActive(true);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 2:
                offchair.SetActive(false);
                chandler.SetActive(true);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 3:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(true);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 4:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(true);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 5:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(true);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 6:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(true);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 7:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(true);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 8:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(true);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 9:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(true);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 10:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(true);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 11:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(true);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 12:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(true);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 13:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(true);
                fridge.SetActive(false);
                couch2.SetActive(false);
                break;
            case 14:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(true);
                couch2.SetActive(false);
                break;
            case 15:
                offchair.SetActive(false);
                chandler.SetActive(false);
                table.SetActive(false);
                bed.SetActive(false);
                bench.SetActive(false);
                archair.SetActive(false);
                archair2.SetActive(false);
                stand.SetActive(false);
                bcase.SetActive(false);
                sink.SetActive(false);
                sofa.SetActive(false);
                couch.SetActive(false);
                stove.SetActive(false);
                fridge.SetActive(false);
                couch2.SetActive(true);
                break;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
