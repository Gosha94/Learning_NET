using HideAndSeek_HouseExplorer_v2.Classes;

namespace HideAndSeek_HouseExplorer_v2.Interfaces
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
