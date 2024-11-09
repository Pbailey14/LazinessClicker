using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {
    public int lazyPoints;

    public int cost;

    public int leveling = 0;
    public TextMeshProUGUI LPText;

    public TextMeshProUGUI costing;

    public TextMeshProUGUI Level;

    public static GameManager instance;

    void Awake() {
        instance = this;
    }

    public void addLazyPoints(int amount) {
        lazyPoints += amount;
        LPText.text = "Laziness: " + lazyPoints.ToString();
    }

    public void takeLazyPoints(int amount) {
        lazyPoints -= amount;
        LPText.text = "Laziness: " + lazyPoints.ToString();
    }

    public void changeCost() {
        if (lazyPoints >= cost){
            takeLazyPoints(cost);
            cost = cost *2;
            leveling ++;
        } 
    }

    public void level(int amount) {
        Level.text = "Level: " + amount.ToString();
    }
}