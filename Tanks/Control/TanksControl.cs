using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Entities;
using System.Windows.Forms;


namespace Control
{
    public class TanksControl
    {
        public TanksModel tanksModel;

        public TanksControl(TanksModel tanksModel)
        {
            this.tanksModel = tanksModel;
        }

        public void ReadKey(Keys key)
        {
            switch (key)
            {
                case Keys.A:
                    tanksModel.ChangePlayerDirection(Direction.LEFT);
                    break;
                case Keys.W:
                    tanksModel.ChangePlayerDirection(Direction.UP);
                    break;
                case Keys.D:
                    tanksModel.ChangePlayerDirection(Direction.RIGHT);
                    break;
                case Keys.S:
                    tanksModel.ChangePlayerDirection(Direction.DOWN);
                    break;
                case Keys.Space:
                    tanksModel.PlayerShoot();
                    break;

            }

        }

        public void NewGame(StartInfo startInfo)
        {
            tanksModel.NewGame(startInfo);
        }

        public bool Update(ref int Score)
        {
            return tanksModel.Update(ref Score);
        }
    }
}
