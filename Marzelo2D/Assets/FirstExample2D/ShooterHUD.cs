using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShooterHUD : MonoBehaviour {

    public TopDownShooterMovement player;
    Text debugText;
    public float spacing;
    Transform collection;
    public GameObject weaponPrefab;

	// Use this for initialization
	void Start () {
        debugText =  transform.Find("DeBugText").GetComponent<Text>();
        collection = transform.Find("WeaponCollection");
        for(int i = 0; i < player.colors.Count; i++){

        }
    }

    // Update is called once per frame
    void Update() {
        //debugText.text = "Weapon Index: " + player.ColorIndex;
        Transform targetObject = transform.Find("WeaponCollection").GetChild(0);
        targetObject.GetComponent<RectTransform>().position =  new Vector3(25,25,0);
        debugText.text = targetObject.name; //targetObject.GetComponent<RectTransform>().rect.x.ToString();
	}
}
