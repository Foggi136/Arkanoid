using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    private bool ballActive;
    private Vector3 ballPosition;
  static  private Vector2 ballInitialForce;
    public GameObject playerObject;
    // Use this for initialization
    void Start () {
        //создать силу
        ballInitialForce = new Vector2(100.0f, 300.0f);
        //переход в неактивное состояние
        ballActive = false;
        //заполнить положение
        ballPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        //проверим нажатие на кнопку
        if (Input.GetButtonDown("Jump") == true)
        {
            //проверка состояния, задаем силу только в том случае, если шар в неактивном состоянии
            if(!ballActive)
            {
                //применяем саму силу
              //  Rigidbody2D.
                //и задаем активное состояние
                ballActive = !ballActive;
            }
            if (!ballActive && playerObject != null)
            {
                // задаем новую позицию шарика
                ballPosition.x = playerObject.transform.position.x;

                // устанавливаем позицию шара
                transform.position = ballPosition;
            }
        }
	}
}
