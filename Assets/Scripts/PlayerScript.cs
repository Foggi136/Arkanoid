using UnityEngine;

public class PlayerScript: MonoBehaviour
{

    // Use this for initialization
    public float playerVelocity;
    public float boundary;
    private Vector3 playerPosition;
    void Start () {
        playerPosition = gameObject.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        //горизонтальное двжение
        playerPosition.x += Input.GetAxis("Horizontal") * playerVelocity;
        // выход из игры
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        // обновим позицию платформы
        transform.position = playerPosition;
        // проверка выхода за границы
        if (playerPosition.x < -boundary)
        {
            transform.position = new Vector3(-boundary, playerPosition.y, playerPosition.z);
        }
        if (playerPosition.x > boundary)
        {
            transform.position = new Vector3(boundary, playerPosition.y, playerPosition.z);
        }
    }
}
