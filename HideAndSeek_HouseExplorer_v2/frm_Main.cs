using System.Windows.Forms;
using HideAndSeek_HouseExplorer_v2.Interfaces;
using HideAndSeek_HouseExplorer_v2.Classes;

namespace HideAndSeek_HouseExplorer_v2
{
    public partial class frm_Main : Form
    {
        int Moves;
        Location currentLocation;
        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;
        Opponent opponent;

        public frm_Main()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            cmbBx_Exits.Items.Clear();
            
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                cmbBx_Exits.Items.Add(currentLocation.Exits[i].Name);
            cmbBx_Exits.SelectedIndex = 0;
            txtBx_Description.Text = currentLocation.Description + "\r\n(перемещение #" + Moves + ")";
                if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                btn_Check.Text = "Смотрим " +hidingPlace.HidingPlaceName;
                btn_Check.Visible = true;
            }            else
                btn_Check.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                btn_GoThroughTheDoor.Visible = true;
            else
                btn_GoThroughTheDoor.Visible = false;
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Гостиная", "старинный ковер",
            "в гардеробе", "дубовая дверь с латунной ручкой");
            diningRoom = new RoomWithHidingPlace("Столовая", "хрустальная люстра",
            "в высоком шкафу");
            kitchen = new RoomWithDoor("Кухня", "приборы из нержавеющей стали",
            "в сундуке", "сетчатая дверь");
            stairs = new Room("Лестница", "деревянные перила");
            hallway = new RoomWithHidingPlace("Верхний коридор", "картина с собакой",
            "в гардеробе");
            bathroom = new RoomWithHidingPlace("Ванная", "раковина и туалет",
            "в душе");
            masterBedroom = new RoomWithHidingPlace("Главная спальня", "большая кровать",
            "под кроватью");
            secondBedroom = new RoomWithHidingPlace("Вторая спальня", "маленькая кровать",
            "под кроватью");
            frontYard = new OutsideWithDoor("лужайка", false, "тяжелая дубовая дверь");
            backYard = new OutsideWithDoor("Задний двор", true, "сетчатая дверь");
            garden = new OutsideWithHidingPlace("Сад", false, "в сарае");
            driveway = new OutsideWithHidingPlace("Подъезд", true, "в гараже");
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Меня нашли за " + Moves + " ходов!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                txtBx_Description.Text = "Соперник найден за " + Moves
                + " ходов!Он прятался " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            btn_Hide.Visible = true;
            btn_goHere.Visible = false;
            btn_Check.Visible = false;
            btn_GoThroughTheDoor.Visible = false;
            cmbBx_Exits.Visible = false;
        }

        private void btn_Hide_Click(object sender, System.EventArgs e)
        {
            btn_Hide.Visible = false;
            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                txtBx_Description.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            txtBx_Description.Text = "Я иду искать!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            btn_goHere.Visible = true;
            cmbBx_Exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }

        private void btn_Check_Click(object sender, System.EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }
        
    }
}
