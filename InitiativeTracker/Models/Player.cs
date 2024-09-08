﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker.Models
{
    public class Player
    {
        private string _name;
        public string Name { get => this._name; set => this._name = value; }

        private int _roll;
        public int Roll { get => this._roll; set => this._roll = value; }

        public Player(string name, int roll)
        {
            this._name = name;
            this.Roll = roll;
        }
    }
}
