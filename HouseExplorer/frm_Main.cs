using System;
using System.Windows.Forms;
using HouseExplorer.Classes;
using HouseExplorer.Interfaces;

namespace HouseExplorer
{
    public partial class frm_Main : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public frm_Main()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }        
    
    private void CreateObjects()
    {
        livingRoom = new RoomWithDoor("Гостиная", "старинный ковер", "дубовая дверь с латунной ручкой");
        diningRoom = new Room("Столовая", "хрустальная люстра");
        kitchen = new RoomWithDoor("Кухня", "плита из нержавеющей стали", "сетчатая дверь");
        frontYard = new OutsideWithDoor("лужайка", false, "дубовая дверь с латунной ручкой");
        backYard = new OutsideWithDoor("Задний двор", true, "сетчатая дверь");
        garden = new Outside("Сад", false);
        diningRoom.Exits = new Location[] { livingRoom, kitchen };
        livingRoom.Exits = new Location[] { diningRoom };
        kitchen.Exits = new Location[] { diningRoom };
        frontYard.Exits = new Location[] { backYard, garden };
        backYard.Exits = new Location[] { frontYard, garden };
        garden.Exits = new Location[] { backYard, frontYard };
        livingRoom.DoorLocation = frontYard;
        frontYard.DoorLocation = livingRoom;
        kitchen.DoorLocation = backYard;
        backYard.DoorLocation = kitchen;
    }

    private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            cmbBx_Exits.Items.Clear();

            for (int i = 0; i < currentLocation.Exits.Length; i++)
                cmbBx_Exits.Items.Add(currentLocation.Exits[i].Name);
            cmbBx_Exits.SelectedIndex = 0;
            txtBx_Description.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                btn_GoThroughTheDoor.Visible = true;
            else
                btn_GoThroughTheDoor.Visible = false;
        }

    private void btn_goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[cmbBx_Exits.SelectedIndex]);
        }

    private void btn_GoThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
