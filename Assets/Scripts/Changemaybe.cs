using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changemaybe : MonoBehaviour
{
  
  private SpriteRenderer rend;
  private Sprite TEST, Lamp, Chiken;

  private void Start(){
      rend = GetComponent<SpriteRenderer>();
      TEST = Resources.Load<Sprite>("TEST");
      Lamp = Resources.Load<Sprite>("Lamp");
      Chiken = Resources.Load<Sprite>("Chiken");
      rend.sprite = TEST;
  }

  private void Update(){
      if(Input.GetMouseButtonDown(0)){
            if (rend.sprite == Lamp || rend.sprite == Chiken)
                rend.sprite = TEST;
            
      }
  }

  void OnCollisionEnter (Collision collisionInfo)
  {
      Debug.Log(collisionInfo.collider.name);
      if(collisionInfo.collider.name == "Lamp"){
          rend.sprite = Lamp;
      }
      if(collisionInfo.collider.name =="Chiken"){
          rend.sprite = Chiken;
      }
  }

}
