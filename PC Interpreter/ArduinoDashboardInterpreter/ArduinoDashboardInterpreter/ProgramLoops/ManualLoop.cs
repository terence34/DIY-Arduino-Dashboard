﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoDashboardInterpreter.ProgramLoops
{
    class ManualLoop : ProgramLoop
    {

        public ManualLoop(ComConnector serial, ArduinoController arduino, Settings settings) : base(serial, arduino, settings) { }
    }
}
