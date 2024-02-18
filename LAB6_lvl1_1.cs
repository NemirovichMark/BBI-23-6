using System;

public class Program
{
    class Participant
    {
        private int res1;
        private int res2;
        private string last_name;
        private string society;
        public Participant(int res1, int res2, string last_name, string society) 
        {
            this.res1 = res1;
            this.res2 = res2;
            this.last_name = last_name;
            this.society = society;
        }
        public int getFinalResult()
        {
            return this.res1 + this.res2;
        }
        public string Last_Name
        {
            get
            {
                return this.last_name;
            }
        }
        public string Society
        {
            get
            {
                return this.society;
            }
        }
         public int Res1
        {
            get
            {
                return this.res1;
            }
        }
         public int Res2
        {
            get
            {
                return this.res2;
            }
        }
    }
     class Protocol
    {
        List<Participant> a = new List<Participant>();
        public void addParticipant(Participant x)
        {
            this.a.Add(x);
            for (int i = 0; i < this.a.Count; i++)
            {
                for (int j = i + 1; j < this.a.Count; j++)
                {
                    if (this.a[i].getFinalResult() < this.a[j].getFinalResult())
                    {
                        Participant change = a[i];
                        a[i] = a[j];
                        a[j] = change;
                    }
                }
            }
        }
        public void output()
        {
            Console.WriteLine(String.Format("{0,10} {1,10} {2,10} {3,10}", "Фамилия", "Общество", "Рез_1", "Рез_2"));
            for (int i = 0; i < this.a.Count; i++)
            {
                Console.WriteLine(String.Format("{0,10} {1,10} {2,10} {3,10}", this.a[i].Last_Name, this.a[i].Society, this.a[i].Res1, this.a[i].Res2));
            }
        }
    }
    public static void Main()
    {
        Protocol jp = new Protocol();
        Participant p1 = new Participant(120, 200, "СиДжинПинь", "Китай");
        Participant p2 = new Participant(0, 0, "ВасяПупкин", "РФ");
        Participant p3 = new Participant(170, 120, "Ахмед", "Чечня");
        jp.addParticipant(p1);
        jp.addParticipant(p3);
        jp.addParticipant(p2);
        jp.output();
    }
}
