﻿using System;

namespace CosmosGameApp
{
    class Command
    {
        public ConsoleKey Key;
        public string Description;
        public Action Action;
    }
}
