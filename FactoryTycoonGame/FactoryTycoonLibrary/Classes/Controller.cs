using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public class Controller
    {
        private Player _player;
        private readonly FactoryShop _factoryShop;

        public Controller()
        {
            InitializePlayer("Tien Hung");
            _factoryShop = new FactoryShop();
        }

        public Player Player
        { 
            get { return _player; } 
        }

        public FactoryShop FactoryShop
        {
            get { return _factoryShop; }
        }

        public void InitializePlayer(string name)
        {
            _player = new Player(name);
            _player.ReceiveGold(500);
        }
    }
}
