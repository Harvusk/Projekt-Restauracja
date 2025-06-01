using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_Restauracja.Models;

namespace Projekt_Restauracja.Models
{
    public static class Session
    {
        public static User CurrentUser { get; set; } = null;
        public static void Clear()
        {
            CurrentUser = null;
        }
        public static bool IsAuthenticated()
        {
            return CurrentUser != null;
        }
    }
}

