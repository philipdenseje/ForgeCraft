﻿using System;
using System.Text;
using System.Collections.Generic;

//TODO: group players by rank

namespace SMP
{
    public class CmdList : Command
    {
        public override string Name { get { return "list"; } }
        public override List<string> Shortcuts { get { return new List<string> { "players", "who", "online" }; } }
        public override string Category { get { return "information"; } }
        public override string Description { get { return "Shows who is online."; } }
        public override bool ConsoleUseable { get { return true; } }
        public override string PermissionNode { get { return "core.info.list"; } }

        public override void Use(Player p, params string[] args)
        {
            if (args.Length > 0)
            {
                Help(p);
                return;
            }

            StringBuilder sb = new StringBuilder();
            /*lock (Player.GetPlayerLock())
            {
                if (Player.players.Count > 0)
                    for (int i = 0; i < Player.players.Count; i++)
                    {
                        sb.Append(Player.players[i].Username);

                        if (i != Player.players.Count - 1)
                            sb.Append(", ");
                    }
                else
                    p.SendMessage("No body is minecrafting right now.");
                
            }*/

            p.SendMessage("Currently Online: " + sb.ToString());
        }

        public override void Help(Player p)
        {
            p.SendMessage("/list - Displays a list of who is online");
        }
    }
}
