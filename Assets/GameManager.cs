using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int selectedZombiePosition;
    public GameObject selectedZombie;
    public List<GameObject> zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;

    void Start()
    {
        SelectZombie(zombies[0], 0);
    }

    private void Update()
    {
        if (Input.GetKeyDown("left")) {
            shiftLeft();
        }

        if (Input.GetKeyDown("right")) {
            shiftRight();
        }
    }

    void shiftLeft()
    {
        if (selectedZombiePosition == 0) {
            SelectZombie(zombies[3], 3);
        }
        else {
            SelectZombie(zombies[selectedZombiePosition - 1],
                         selectedZombiePosition - 1);
        }
    }

    void shiftRight()
    {
        if (selectedZombiePosition == 3) {
            SelectZombie(zombies[0], 0);
        }
        else {
            SelectZombie(zombies[selectedZombiePosition + 1],
                         selectedZombiePosition + 1);
        }
    }

    void SelectZombie(GameObject newZombie, int newPosition)
    {
        selectedZombie.transform.localScale = defaultSize;
        selectedZombie = newZombie;
        selectedZombie.transform.localScale = selectedSize;
        selectedZombiePosition = newPosition;
    }
}


