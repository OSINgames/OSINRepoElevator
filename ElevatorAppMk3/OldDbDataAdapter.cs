using System;
using System.Data;

namespace ElevatorAppMk3
{
    internal class OldDbDataAdapter
    {
        private string v;
        private OleDbConnection con;

        public OldDbDataAdapter(string v, OleDbConnection con)
        {
            this.v = v;
            this.con = con;
        }

        internal void Fill(DataSet set, string v)
        {
            throw new NotImplementedException();
        }
    }
}