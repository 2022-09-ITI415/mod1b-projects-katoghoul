using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{[Header("Set Dynamically")]
public text scoreGT;

void Start() {
    GameObject scoreGO = GameObject.Find("ScoreCounter");
    scoreGT = scoreGO.GetComponent<Text>();
    scoreGT.text = "0";
}
    // Start is called before the first frame update
 
    // Update is called once per frame
    void Update()
    { Vector3 mousePos2D = Input.mousePosition;

    mousePos2D.z = -Camera.main.transform.position.z;

    Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);

    Vector3 pos = this.transform.position;
    pos.x = mousePos3D.x;
    this.transform.position = pos;}

        
    void OnCollisionEnter(Collision coll) {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple"){
            Destroy( collidedWith );

            int score = int.Parse(scoreGT.test);
            score += 100;
            score.GT.text = score.ToString();
        }
    }
    }
