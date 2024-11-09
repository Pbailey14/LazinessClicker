using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chairthing : MonoBehaviour {

public int clickWorth;

public void Click() {
    GameManager.instance.addLazyPoints(clickWorth);
}

public void Upgrade(){
    GameManager.instance.changeCost();
}
}
