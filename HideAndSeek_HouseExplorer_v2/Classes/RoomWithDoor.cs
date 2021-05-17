using HideAndSeek_HouseExplorer_v2.Interfaces;

namespace HideAndSeek_HouseExplorer_v2.Classes
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration,
        string hidingPlaceName, string doorDescription)
        : base(name, decoration, hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
    }
}
