using HideAndSeek_HouseExplorer_v2.Interfaces;

namespace HideAndSeek_HouseExplorer_v2.Classes
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            HidingPlaceName = hidingPlaceName;
        }
        public string HidingPlaceName { get; private set; }
        public override string Description
        {
            get
            {
                return base.Description + " Можно спрятаться " + HidingPlaceName + ".";
            }
        }
    }
}
