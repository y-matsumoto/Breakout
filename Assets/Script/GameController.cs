using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public UnityEngine.UI.Text scoreText;
    public GameObject winnerTextObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int count = GameObject.FindGameObjectsWithTag ("Item").Length;
        scoreText.text = count.ToString();

        if (count == 0)
        {
            winnerTextObject.SetActive(true);
        }
    }
}
