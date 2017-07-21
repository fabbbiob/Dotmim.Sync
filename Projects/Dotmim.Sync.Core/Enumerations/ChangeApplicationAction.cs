﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotmim.Sync.Enumerations
{

    public enum ChangeApplicationAction
    {
        // Normal action
        Continue,

        /// <summary>
        /// Rollback transaction
        /// </summary>
        Rollback,

    }
}
