Лвл 1 using System.Collections.Generic;

using System;

public class Program
{
    class Participant
    {
        private int result;
        private string last_name;
        private string society;
        public Participant(int res1, int res2, string last_name, string society) 
        {
            this.result = res1 + res2;
            this.last_name = last_name;
            this.society = society;
        }
        public void consoleResult() {
            Console.WriteLine(String.Format("{0,10} {1,10} {2,10}", this.last_name, this.society, this.result));
        }
        public int Result 
        {
            get
            {
                return this.result;
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
                    if (this.a[i].Result < this.a[j].Result)
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
            Console.WriteLine(String.Format("{0,10} {1,10} {2,10}", "Фамилия", "Общество", "Результат"));
            for (int i = 0; i < this.a.Count; i++)
            {
                this.a[i].consoleResult();
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
——— 2 лвл  using System.Collections.Generic;
using System;

public class Person
{
    private string surname;
    private double score = 0;
    public Person(string surname) 
    {
        this.surname = surname;
    }
    public void consoleResult() {
        Console.WriteLine(String.Format("{0,10} {1,10}", this.surname, this.score));
    }
    public double Score 
    {
        get 
        {
            return this.score;
        }
    }
    public void winGame() 
    {
        this.score += 1;
    }
    public void drawGame() 
    {
        this.score += 0.5;   
    }
    public void loseGame() 
    {
        this.score += 0;
    }
    
}
public class Tournament
{
    private List<Person> participants = new List<Person>();
    
    public void addParticipant(string surname) 
    {
        Person p = new Person(surname);
        this.participants.Add(p);
    }
    public void simulateGames() 
    {
      Random rnd = new Random();
      for (int i = 0; i < this.participants.Count; i++) 
      {
          for (int j = i + 1; j < this.participants.Count; j++) 
          {
              int result = rnd.Next(0, 3);
              switch(result) {
                  case 0: // Победа участника с номером i
                    this.participants[i].winGame();
                    this.participants[j].loseGame();
                    break;
                  case 1: // Ничья
                    this.participants[i].drawGame();
                    this.participants[j].drawGame();
                    break;
                  case 2: // Победа участника с номером j
                    this.participants[i].loseGame();
                    this.participants[j].winGame();
                    break;

              }
          }
      }  
    } 
    public void getResults() 
    {
        for (int i = 0; i < this.participants.Count; i++)
        {
            for (int j = i + 1; j < this.participants.Count; j++)
            {
                if (this.participants[i].Score < this.participants[j].Score)
                {
                    Person change = this.participants[i];
                    this.participants[i] = this.participants[j];
                    this.participants[j] = change;
                }
            }
        }
        Console.WriteLine(String.Format("{0,10} {1,10}", "Фамилия", "Результат"));
        for (int i = 0 ; i < this.participants.Count; i++) 
        {
            this.participants[i].consoleResult();
        }
    }
    
}

public class Program
{
    public static void Main()
    {
        Tournament lupaPupaInternational = new Tournament();
        lupaPupaInternational.addParticipant("Lupa");
        lupaPupaInternational.addParticipant("Pupa");
        lupaPupaInternational.addParticipant("Kruglov");
        lupaPupaInternational.addParticipant("Zele");
        lupaPupaInternational.addParticipant("Byko");
        lupaPupaInternational.addParticipant("DogGdeBabk");
        lupaPupaInternational.simulateGames();
        lupaPupaInternational.getResults();
        
    }
}
——————
———————————
3 лвл

using System;



public class Program
{
    public class Participant 
    {
        private string lastName;
        private int result;
        
        public int Result 
        {
            get {
                return this.result;
            }
        }
        public Participant(string lastName, int result) 
        {
            this.lastName = lastName;
            this.result = result;
        }
        public void output() {
            Console.WriteLine(String.Format("{0,10} {1,10}",this.lastName, this.result));
        }
    }
    public class Protocol {
        private List<Participant> participants =  new List<Participant>();
        
        public List<Participant> Participants {
            get 
            {
                return this.participants;
            }
        }
        private void swap(int i, int j) {
            Participant buf = this.participants[i];
            this.participants[i] = this.participants[j];
            this.participants[j] = buf;
        }
        
        public void addParticipant(string lastName, int result) {
            Participant p = new Participant(lastName, result);
            this.participants.Add(p);
        }
        public void mergeWithProtocol(Protocol p) {
            for (int i = 0; i < p.Participants.Count; ++i) {
                this.participants.Add(p.Participants[i]);
            }
        }
        private void sortParticipants(int l, int r) {
            if (l >= r) return;
            
            
            int pivot = this.participants[l].Result;
            int count = 0;
            for (int k = l + 1; k <= r; k++) {
                if (this.participants[k].Result >= pivot) {
                    count++;
                }
            }
            
            int pivotIndex = l + count;

            this.swap(l,pivotIndex);
            
            
            int i = l;
            int j = r;
            
            while (i < pivotIndex && j > pivotIndex) {
                while (this.participants[i].Result >= this.participants[pivotIndex].Result) {
                    i++;
                }
    
                while (this.participants[j].Result < this.participants[pivotIndex].Result) {
                    j--;
                }
                if (i < pivotIndex && j > pivotIndex) {
                    this.swap(i,j);
                }
            }
            
            this.sortParticipants(l,pivotIndex - 1);
            this.sortParticipants(pivotIndex + 1,r);
                
        }
        public void output() {
            this.sortParticipants(0,this.participants.Count - 1);
            Console.WriteLine(String.Format("{0,10} {1,10}","Last name", "Result"));

            for (int i = 0; i < this.participants.Count; ++i) {
                this.participants[i].output();
            }
        }
     }
    public static void Main(string[] args)
    {
        Protocol p1 = new Protocol();
        Protocol p2 = new Protocol();
        p1.addParticipant("Mucha", 10);
        p1.addParticipant("Xanya", 20);
        p1.addParticipant("Vasya", 30);
        p1.addParticipant("Daze", 3);
        p1.addParticipant("Neko", 5);
        
        p2.addParticipant("Kirya",2);
        p2.addParticipant("Alexandr",5);
        p2.addParticipant("Sanya",7);
        p2.addParticipant("Ochko",12);
        p2.addParticipant("Olololo",1312);
        
        p1.output();

        p1.mergeWithProtocol(p2);
        
        p1.output();
        
    }
}
------

