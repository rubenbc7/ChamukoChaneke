using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Changemaybe : MonoBehaviour
{


  private SpriteRenderer rend;
  private Sprite Chaneke, Candelabro, Posho, Craneo, Carta, Libro, Libro2, Libro3, Pan, Tarro, Vela;
  public BoxCollider player;

  private void Start(){
      rend = GetComponent<SpriteRenderer>();
      Chaneke = Resources.Load<Sprite>("Chaneke");
      Candelabro = Resources.Load<Sprite>("Candelabro");
      Posho = Resources.Load<Sprite>("Posho");
      Craneo = Resources.Load<Sprite>("Craneo");
        Carta = Resources.Load<Sprite>("Carta");
      Libro = Resources.Load<Sprite>("Libro");
      Libro2 = Resources.Load<Sprite>("Libro2");
      Libro3 = Resources.Load<Sprite>("Libro3");
      Pan = Resources.Load<Sprite>("Pan");
    Tarro = Resources.Load<Sprite>("Tarro");
    Vela = Resources.Load<Sprite>("Vela");
      rend.sprite = Chaneke;

      player = player.GetComponent<BoxCollider>();
  }

  private void Update(){
      if(Input.GetMouseButtonDown(0)){
            
            rend.sprite = Chaneke;
            player.size = new Vector3(7.52f,11.14f,0.2f);   
      }
  }

  void OnCollisionEnter (Collision collisionInfo)
  {
      Debug.Log(collisionInfo.collider.name);

      switch(collisionInfo.collider.name){
           case "Candelabro":
                 rend.sprite = Candelabro;
                 player.size = new Vector3(7.7f,9.11f,0.2f);    
                 break;
           case "Posho":
                 rend.sprite = Posho;
                 player.size = new Vector3(5.68f,3.9f,1.2f);    
                 break;
            case "Craneo":
                 rend.sprite = Craneo;
                 player.size = new Vector3(5.25f,7.28f,1.2f);    
                 break;
             case "Carta":
                 rend.sprite = Carta;
                 player.size = new Vector3(7.15f,4.32f, 1.2f);    
                 break;
            case "Libro":
                 rend.sprite = Libro;
                 player.size = new Vector3(6.21f,8.32f, 1.2f);    
                 break;
            case "Libro2":
                 rend.sprite = Libro2;
                 player.size = new Vector3(6.21f,8.32f, 1.2f);    
                 break;
            case "Libro3":
                 rend.sprite = Libro3;
                 player.size = new Vector3(6.21f,8.32f, 1.2f);    
                 break;
            case "Tarro":
                 rend.sprite = Tarro;
                 player.size = new Vector3(4.41f,4.32f, 1.2f);    
                 break;
            case "Vela":
                 rend.sprite = Vela;
                 player.size = new Vector3(1.06f,3.24f, 1.2f);    
                 break;

      }
      
     /* if(collisionInfo.collider.name == "Candelabro"){
          rend.sprite = Candelabro;
          player.size = new Vector3(7.7f,9.11f,0.2f);
      }
      if(collisionInfo.collider.name =="Posho"){
          rend.sprite = Posho;
          player.size = new Vector3(5.68f,3.9f,1.2f);
      }
        if(collisionInfo.collider.name =="Craneo"){
          rend.sprite = Craneo;
          player.size = new Vector3(5.26f,7.28f,1.2f);
      }*/
  }

}
