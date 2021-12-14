using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Engine.Models;
using Engine.Factories;

// ViewModels are similar to Controller (MVC = MVVM) The Viewmodel (or in this case, the GameSession) acts as a conduit between the Window (the View) and all of the Models and game logic. (Players, Locations, Monsters, etc.)
namespace Engine.ViewModels
{
    //The GameSession class also needs to implement the INotifyPropertyChanged interface in order to make the locations update. 
    public class GameSession : INotifyPropertyChanged
    {
        private Player _currentPlayer;
        private Location _currentLocation;
        private List<Item> _itemList;
        public Player CurrentPlayer 
        {
            get {return _currentPlayer; }
            //Instead of creating another class like the guide suggests, I think we could have the setter for CurrentPlayer also use the the OnPropertyChanged function to avoid having to implement it in the Player class.
            //Update: This doesn't work, because the currentPlayer doesn't get updated specifically. The Properties of currentPlayer do get updated, so the Player class still needs the INotify Property changed interface.
            set
            {
                _currentPlayer = value;
                OnPropertyChanged(nameof(CurrentPlayer));
            }
        }
        public Location CurrentLocation {
            get { return _currentLocation; } 
            set 
            { 
                _currentLocation = value;

                //Updated all of the parameters here to use the nameof keyword. This will automatically update the name if the property is updated using 'Rename'. 
                OnPropertyChanged(nameof(CurrentLocation));
                //Need to notify the window to 'get' all of the 'HasLocation' bools which will be updated upon arriving at a new location.
                OnPropertyChanged(nameof(HasLocationNorth));
                OnPropertyChanged(nameof(HasLocationEast));
                OnPropertyChanged(nameof(HasLocationSouth));
                OnPropertyChanged(nameof(HasLocationWest));
            } 
        }
        public List<Item> ItemList 
        {
            get { return _itemList; }
            set
            {
                _itemList = value;
                OnPropertyChanged(nameof(ItemList));
            }
        }

        public World CurrentWorld { get; set; }
        
        //These bool properties are used to hide the movement buttons if there is no valid location. Also used as a condition to prevent the user from going anywhere in the MoveDirection function.
        public bool HasLocationNorth 
        { 
            get 
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate +1) != null;
            } 
        }
        public bool HasLocationEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate-1) != null;
            }
        }
        public bool HasLocationWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate -1, CurrentLocation.YCoordinate) != null;
            }
        }

        public GameSession()
        {
            //This is another way to instantiate an object with a lot initial properties.
            CurrentPlayer = new Player
            {
                Name = "Estelar Moonsong",
                CharClass = "Bard",
                Level = 1,
                HitPoints = 10,
                ArmorClass = 16,
                Strength = 16,
                Dexterity = 16,
                Constitution = 16,
                Intelligence = 16,
                Wisdom = 16,
                Charisma = 16,
                Gold = 500,
                ExperiencePoints = 0
            };

            //This code was used to initally check the functionality of the location class and display the information.
            //Now that we have a WorldFactory to make all of the locations and add it to the World, this is no longer necessary.
            //See WorldFactory.CreateWorld in the WorldFactory class.

            //CurrentLocation = new Location();
            //CurrentLocation.Name = "Home";
            //CurrentLocation.Description = "This is your home.";
            //CurrentLocation.XCoordinate = 0;
            //CurrentLocation.YCoordinate = 0;
            //For the Image File Location, it seems that if you select the Build Action as resource, it will "build" the image into the home directory. So just using /FileName.Extension seems to work just fine.
            //CurrentLocation.ImageFile = "/Home.png";

            //See WorldFactory.CreateWorld in the WorldFactory class.

            
            CurrentWorld =  WorldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);
            ItemList = ItemFactory.CreateItemList();

        }

        //Property Changed Event. This lets the window know that a property has changed. The window is looking for this event in order for it to update the data bindings.
        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            //This seems to be alternate syntax for 'if PropertyChanged = null'
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void MoveDirection(string direction)
        {

                switch (direction)
                {
                    case "North":
                        if (HasLocationNorth)
                        {
                            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
                        }                        
                        break;
                    case "East":
                        if (HasLocationEast)
                        {
                            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
                        
                        }
                        break;
                    case "South":
                        if (HasLocationSouth)
                        {
                            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
                        }                        
                        break;
                    case "West":
                        if (HasLocationWest)
                        {
                            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
                        }    
                        break;
                    default:
                        break;
                }


        }
    }
}
