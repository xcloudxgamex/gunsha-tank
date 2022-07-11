using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_spawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;

        public Tank_Types tankType;

        public Material color;
    }

    public List<Tank> tankList;

    public TankView tankView;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        createTank();
    }

    private void createTank()
    {
        TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
