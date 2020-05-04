using HideAndSeek_HouseExplorer_v2.Interfaces;

namespace HideAndSeek_HouseExplorer_v2.Classes
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; private set; }

        public override string Description
        {
            get
            {
                return base.Description + " Спрятаться можно " + HidingPlaceName + ".";
            }
        }
    }
}