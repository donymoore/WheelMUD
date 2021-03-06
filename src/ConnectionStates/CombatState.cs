﻿//-----------------------------------------------------------------------------
// <copyright file="CombatState.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Permissive License. All other rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

using WheelMUD.Server;

namespace WheelMUD.ConnectionStates
{
    using WheelMUD.Core;

    /// <summary>The player state for handling combat.</summary>
    public class CombatState : SessionState
    {
        /// <summary>Initializes a new instance of the <see cref="CombatState"/> class.</summary>
        /// <param name="session">The session entering this state.</param>
        public CombatState(Session session) : base(session)
        {
        }

        /// <summary>Process the specified input.</summary>
        /// <param name="command">The input to process.</param>
        public override void ProcessInput(string command)
        {
            if (command != string.Empty)
            {
                var actionInput = new ActionInput(command, Session);
                Session.ExecuteAction(actionInput);
            }
            else
            {
                Session.WritePrompt();
            }
        }

        public override OutputBuilder BuildPrompt()
        {
            return new OutputBuilder(2).Append("> ");
        }
    }
}