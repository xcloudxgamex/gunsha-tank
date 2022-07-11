using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public Tank_Types tankType;

    public Material color;

    public TankModel(float _movementSpeed, float _rotationSpeed, Tank_Types _tankType, Material _color)
    {
        movementSpeed = _movementSpeed;
        rotationSpeed = _rotationSpeed;

        tankType = _tankType;

        color = _color;
    }

    public void setTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

}
