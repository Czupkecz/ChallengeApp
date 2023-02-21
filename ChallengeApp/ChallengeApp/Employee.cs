namespace ChallengeApp
{
    public class Employee //Nazwa klasy 
    {
        private List<int> score = new List<int>(); //Nowa LISTA, która przechowuje wartości SCORE dzięki METODZIE AddPoints. Punktu są przechowywane jako pozycje na liście

        //Konstruktor
        public Employee(string name, string surname, int age) //nazwa klasy + zmienne, które są potrzebne przy dodawaniu nowego obiektu (użytkownika)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;


        } // kostruktor koniec

        //Propercja - określa dostęp prywatny lub publiczny poza klasą
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result //zmienna, w której będziemy przechowywali sumę punktów dodanych metodą AddPoints. Poniżej określamy co ma się zadziać w tej zmiennej
        {
            get //określamy, że publicznie jest GET
            {
                return this.score.Sum(); //Sumuje wartości SCORE zapisane w elementach LISTY SCORE przy pomocy metody AddPoints wywoływanej poza klasą na początku programu (np: worker1.AddPoints(2);)
                                         //dzięki poleceniu RETURN wpisanym w klamrach get zmienna RETURN "zwróci" to co jest w liście SCORE. Dzięki temu, że jest polecenie SUM () zwrócona zostanie suma.
            }
        }

        //Metoda - np. Dodawanie punktów. 
        public void AddPoints(int point) // point tutaj jest parametrem
        {
            this.score.Add(point);
        }


    }
}
