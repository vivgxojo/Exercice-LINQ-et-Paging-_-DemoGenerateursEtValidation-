namespace DemoGenerateursEtValidation.Models
{
    public class MemAutoRep : IAutoRep
    {
        private List<Auto> _MesAutos = new List<Auto>() {
            new Auto(1, "Toyota", "Corolla", 25000),
            new Auto(2, "Honda", "Civic", 45000),
            new Auto(3, "Ford", "Focus", 29000),
            new Auto(4, "Audi", "Q5", 75000)
        };

        public IEnumerable<Auto> MesAuto
        {
            get { return _MesAutos; }
        }

        public void AddAuto(Auto auto)
        {
            _MesAutos.Add(auto);
        }

        public Auto GetAuto(int? id)
        {
            return _MesAutos.Find(auto => auto.Id == id);
        }

        void IAutoRep.SupprimerAuto(int id)
        {
            _MesAutos.Remove(GetAuto(id));
        }

        void IAutoRep.ModifierAuto(Auto auto)
        {
            _MesAutos.Remove(GetAuto(auto.Id));
            _MesAutos.Add(auto);
        }

    }
}
