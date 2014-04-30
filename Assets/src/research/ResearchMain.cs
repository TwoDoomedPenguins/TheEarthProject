﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ResearchMain {

    public string researchTitle;  
    public int currentLevel;
    public int maxLevel;
    public List<int> costsMoney;
    public List<int> costsResearch;
    public List<int> valueStep;
    public List<float> researchTime;
    public enum rType { Speed, Amount, Drill, BuildCosts, DrillingPlattform, Scan };
    public rType researchType;


    public ResearchMain (string rTitle, int cLevel, int mLevel, List<int> moneyCosts, List<int> researchCosts, List<int> vStep, List<float>rTime, rType resType)
    {

        researchTitle = rTitle;
        currentLevel = cLevel;
        maxLevel = mLevel;
        costsMoney = moneyCosts;
        costsResearch = researchCosts;
        valueStep = vStep;
        researchTime = rTime;
        researchType = resType;


    }

    public static Dictionary<int, ResearchMain> GenerateResearch()
    {

        Dictionary<int, ResearchMain> researchDict = new Dictionary<int,ResearchMain>();


        researchDict.Add(0, new ResearchMain("Speed", 0, 5,new List<int>{250,500,750,1000,2500}, new List<int>{5,10,15,20,25}, new List<int>{5,10,15,20,25}, new List<float>{4.5f,4.0f,3.5f,3.0f,2.5f}, rType.Speed));
        researchDict.Add(1, new ResearchMain("Amount", 0, 5,new List<int>{250,500,750,1000,2500}, new List<int>{5,10,15,20,25}, new List<int>{5,10,15,20,25}, new List<float>{4.5f,4.0f,3.5f,3.0f,2.5f}, rType.Amount));
        researchDict.Add(2, new ResearchMain("Building Cost", 0, 3,new List<int>{250,500,750,1000,2500}, new List<int>{5,10,15,20,25}, new List<int>{3,5,7,10,15}, new List<float>{3.0f,5.0f,7.5f,10.0f,15.0f}, rType.BuildCosts));
        researchDict.Add(3, new ResearchMain("Drill", 0, 5,new List<int>{250,500,750,1000,2500}, new List<int>{5,10,15,20,25}, new List<int>{1,2,3,4,5}, new List<float>{5.0f,4.0f,3.5f,3.0f,2.5f}, rType.Drill));
        researchDict.Add(4, new ResearchMain("Drilling Plattform", 0, 1, new List<int> { 15000 }, new List<int> { 50 }, new List<int> { 1 }, new List<float> { 10.0f}, rType.DrillingPlattform));
        researchDict.Add(5, new ResearchMain("Scan", 0, 5, new List<int> { 250, 500, 750, 1000, 2500 }, new List<int> { 5, 10, 15, 20, 25 }, new List<int> { 1, 2, 3, 4, 5 }, new List<float> { 4.5f, 4.0f, 3.5f, 3.0f, 2.5f }, rType.Scan));

        return researchDict;

    }
    


}