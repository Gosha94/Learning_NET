﻿using HouseExplorer.Classes;

namespace HouseExplorer.Interfaces
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
