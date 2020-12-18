﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

public enum Direction
{
    Up,
    Down
}

public class Pin : MonoBehaviour
{
    [Header("Options")] //
    public bool IsAutomatic;
    public bool HideIcon;
    public string SceneToLoad = "Level 1";

    [Header("Pins")] //
    public Pin UpPin;
    public Pin DownPin;

    private Dictionary<Direction, Pin> _pinDirections;


    // Start is called before the first frame update
    // use this for initialisation
    private void Start()
    {
        _pinDirections = new Dictionary<Direction, Pin>
        {
            { Direction.Up, UpPin },
            { Direction.Down, DownPin }
        };

        // Hide the icon if needed
        if (HideIcon)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    // Get the pin in a selected direction
    // using a switch statement rather than linq so this can run in the editor
    public Pin GetPinInDirection(Direction direction)
    {
        switch(direction)
        {
            case Direction.Up:
                return UpPin;
            case Direction.Down:
                return DownPin;
            default:
                throw new ArgumentOutOfRangeException("direction", direction, null);
        }
    }

    // this gets the first pin that is not the one passed
    public Pin GetNextPin(Pin pin)
    {
        return _pinDirections.FirstOrDefault(x => x.Value != null && x.Value != pin).Value;
    }

    // Draw lines between connected pins
    private void OnDrawGizmos()
    {
        if (UpPin != null) DrawLine(UpPin);
        if (DownPin != null) DrawLine(DownPin);
    }

    // Draw one pin line
    protected void DrawLine(Pin pin)
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, pin.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
