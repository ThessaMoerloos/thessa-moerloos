using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee_teerling
{
    class teerlingController
    {
        TeerlingView _view;
        teerlingModel _model;


        public teerlingController() {
                                    //controller = this
            _view = new TeerlingView(this);
            _model = new teerlingModel();
        }

        public TeerlingView getView() { 

            TeerlingView teerling = new TeerlingView();

        return teerling;
        }

    }
}
