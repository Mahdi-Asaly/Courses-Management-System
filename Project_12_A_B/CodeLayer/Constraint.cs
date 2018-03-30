using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_12_A_B;

namespace Project_Sce.CodeLayer
{
    public class Constraint
    {
        private int cid, fromHour, toHour;
        private string lid;
        private string day;

        public int CID
        {
            get { return this.cid; }
            set { this.cid = value; }
        }

        public string LID
        {
            get { return this.lid; }
            set { this.lid = value; }
        }

        public string Day
        {
            get { return this.day; }
            set { this.day = value; }
        }

        public int FromHour
        {
            get { return this.fromHour; }
            set { this.fromHour = value; }
        }

        public int ToHour
        {
            get { return this.toHour; }
            set { this.toHour = value; }
        }

        public Constraint()
        {

        }

        public Constraint(string lid_, string day_, int fromHour_, int toHour_)
        {
            this.lid = lid_;
            this.day = day_;
            this.fromHour = fromHour_;
            this.toHour = toHour_;
        }

        public Constraint(int cid_, string lid_, string day_, int fromHour_, int toHour_)
        {
            this.cid = cid_;
            this.lid = lid_;
            this.day = day_;
            this.fromHour = fromHour_;
            this.toHour = toHour_;
        }
    }
}
