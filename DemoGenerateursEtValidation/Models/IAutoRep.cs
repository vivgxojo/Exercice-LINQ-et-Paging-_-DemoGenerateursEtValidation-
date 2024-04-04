namespace DemoGenerateursEtValidation.Models
{
    public interface IAutoRep
    {
        //Collection d'autos
        IEnumerable<Auto> MesAuto { get; }

        //Méthodes CURD
        Auto GetAuto(int? id);

        void AddAuto(Auto auto);

        void SupprimerAuto(int id);

        void ModifierAuto(Auto auto);
    }
}
