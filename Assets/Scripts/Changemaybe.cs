using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changemaybe : MonoBehaviour
{
  
  private SpriteRenderer rend;
  private Sprite TEST, Lamp, Chiken;
  public BoxCollider player;

  private void Start(){
      rend = GetComponent<SpriteRenderer>();
      TEST = Resources.Load<Sprite>("TEST");
      Lamp = Resources.Load<Sprite>("Lamp");
      Chiken = Resources.Load<Sprite>("Chiken");
      rend.sprite = TEST;

      player = player.GetComponent<BoxCollider>();
  }

  private void Update(){
      if(Input.GetMouseButtonDown(0)){
            if (rend.sprite == Lamp || rend.sprite == Chiken)
                rend.sprite = TEST;
                player.size = new Vector3(11,12.67f,0.5f);   
      }
  }

  void OnCollisionEnter (Collision collisionInfo)
  {
      Debug.Log(collisionInfo.collider.name);
      if(collisionInfo.collider.name == "Lamp"){
          rend.sprite = Lamp;
          player.size = new Vector3(7.05f,18.4f,0.5f);
      }
      if(collisionInfo.collider.name =="Chiken"){
          rend.sprite = Chiken;
          player.size = new Vector3(8.82f,6.5f,1.2f);
      }
  }

}
