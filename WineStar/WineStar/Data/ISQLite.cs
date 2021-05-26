using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WineStar.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
