using Microsoft.EntityFrameworkCore;
using bobbybots_backend.entity;
using System.Collections;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System;
using bobbybots_backend.database;

namespace bobbybots_backend
{
    class Program
    {
        private static void init() {

        }

        static void Main(string[] args)
        {
           InitiateDatabase.loadBots();
        }
    }
}
