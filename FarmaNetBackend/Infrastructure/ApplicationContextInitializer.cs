/*using FarmaNetBackend.Models;
using System.Data.Entity;
using System.Security.AccessControl;

namespace FarmaNetBackend.Infrastructure
{
    public class ApplicationContextInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext db)
        {
            MedicationType hormonesSystemicUse = new MedicationType { Name = "Гормоны для системного применения"};
            MedicationType dermatologicalAgents = new MedicationType { Name = "Дерматологиечские средства" };
            MedicationType preparationsHematopoiesisAndBlood = new MedicationType { Name = "Препараты для кроветворения и крови" };
            MedicationType drugsTreatmentDiseasesSenses = new MedicationType { Name = "Перапараты для лечения заболеваний органов чувств" };
            MedicationType preparationsTreatmentMusculoskeletalSystem = new MedicationType { Name = "Препараты для лечения костно-мышечной системы" };
            MedicationType preparationsTreatmentRespiratoryOrgans = new MedicationType { Name = "Препараты для лечения органов дыхания" };
            MedicationType drugsGenitourinarySystem = new MedicationType { Name = "Препараты для мочеполовой системы и половые гормоны" };
            MedicationType preparationsNervousSystem = new MedicationType { Name = "Препараты для нервной системы" };
            MedicationType preparationsDigestiveTract = new MedicationType { Name = "Препараты для пищеварительного тракта и обмена веществ" };
            MedicationType preparationsCardiovascularSystem = new MedicationType { Name = "Препараты для сердечно-сосудистой системы" };
            MedicationType antimicrobialDrugs = new MedicationType { Name = "Противомикробные препараты для системного применения" };
            MedicationType antitumorDrugs = new MedicationType { Name = "Противоопухолевые препараты и иммуномодуляторы" };
            MedicationType antiparasiticDrugs = new MedicationType { Name = "Противопаразитные препараты" };
            MedicationType otherDrugs = new MedicationType { Name = "Прочие препараты" };

            db.TypeMedications.Add(hormonesSystemicUse);
            db.TypeMedications.Add(dermatologicalAgents);
            db.TypeMedications.Add(preparationsHematopoiesisAndBlood);
            db.TypeMedications.Add(preparationsTreatmentMusculoskeletalSystem);
            db.TypeMedications.Add(preparationsTreatmentRespiratoryOrgans);
            db.TypeMedications.Add(drugsGenitourinarySystem);
            db.TypeMedications.Add(preparationsNervousSystem);
            db.TypeMedications.Add(preparationsDigestiveTract);
            db.TypeMedications.Add(preparationsDigestiveTract);
            db.TypeMedications.Add(preparationsCardiovascularSystem);
            db.TypeMedications.Add(antimicrobialDrugs);
            db.TypeMedications.Add(antitumorDrugs);
            db.TypeMedications.Add(antiparasiticDrugs);
            db.TypeMedications.Add(otherDrugs);
            db.SaveChanges();
        }
    }
}
*/