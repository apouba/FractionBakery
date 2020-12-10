using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 3f;
    public bool IsMoving { get; private set; }

    public Pin CurrentPin { get; private set; }
    private Pin _targetPin;
    private MapManager _mapManager;


    public void Initialise(MapManager mapManager, Pin startPin)
    {
        _mapManager = mapManager;
        SetCurrentPin(startPin);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if (_targetPin == null) return;

        // Get the characters current position and the targets position
        var currentPosition = transform.position;
        var targetPosition = _targetPin.transform.position;

        // if the character isn't that close to the target move closer
        if (Vector2.Distance(currentPosition, targetPosition) > 0.2f)
        {
            transform.position = Vector2.MoveTowards(
                currentPosition,
                targetPosition,
                Time.deltaTime * Speed);
        } else
        {
            if(_targetPin.IsAutomatic)
            {
                // get a direction to keep moving in
                var pin = _targetPin.GetNextPin(CurrentPin);
                MoveToPin(pin);
            } else
            {
                SetCurrentPin(_targetPin);
            }
        }
    }

    // Check if the current pin has a reference to another in a direction
    // if it does move there
    public void TrySetDirection(Direction direction)
    {
        // try to get the next pin
        var pin = CurrentPin.GetPinInDirection(direction);

        // if there is a pin then move to it
        if (pin == null) return;
        MoveToPin(pin);
    }

    //Move to a new pin
    private void MoveToPin(Pin pin)
    {
        _targetPin = pin;
        IsMoving = true;
    }

    // set the current pin
    public void SetCurrentPin(Pin pin)
    {
        CurrentPin = pin;
        _targetPin = null;
        transform.position = pin.transform.position;
        IsMoving = false;

        // Tell the map manager that
        // the current pin has changed
        //_mapManager.UpdateGui();
    }
}
