using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace learning_siltums_1.HardcodedData
{
    internal class HardcodedData
    {
        static List<QuestionsNAnswers> GetQnAList()
        {
            var res = new List<QuestionsNAnswers>()
            {
                new QuestionsNAnswers(){ QuestionId = 1, Question = "Kas ir izolēta termodinamiska sistēma", Answer="Par izolētu sauc tādu termodinamisko sistēmu, kurai nav mijiedarbības ar apkārtējo vidi.", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 2, Question = "Kas ir neizolēta termodinamiska sistēma", Answer="Par neizolētu sauc tādu termodinamisko sistēmu, kas mijiedarbojas ar apkārtējo vidi.", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 3, Question = "Kas ir noslēgta termodinamiska sistēma", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 4, Question = "Kas ir vaļēja termodinamiska sistēma", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 5, Question = "Ko raksturo ķermeņa temperatūra", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 6, Question = "Uzrakstīt skaitlisko sakarību starp absolūto un Celsija skalas temperatūru", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 7, Question = "Definēt spiedienu", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 8, Question = "Kādas ir spiediena mērvienības SI un citās sistēmās", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 9, Question = "Kas ir īpatnējais tilpums, tā mērvienība", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 10, Question = "Kas ir darba ķermeņa normālie apstākļi", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 11, Question = "Kas ir entalpija, tās mērvienība", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 12, Question = "Kāda ir entropijas mērvienība", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 13, Question = "Kas ir termodinamiskais process", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 14, Question = "Kas ir ideāla gāze", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 15, Question = "Uzrakstīt gāzes stāvokļa vienādojumu ideālai gāzei", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 16, Question = "Kas ir gāzes individuālā konstante, mērvienība", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 17, Question = "Kas ir īpatnējā siltumietilpība, mērvienība", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 18, Question = "Kādi ir īpatnējās siltumietilpības veidi, mērvienības", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 19, Question = "Pirmais termodinamikas likums", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 20, Question = "Nosaukt termodinamikas pamatprocesus", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 21, Question = "Kas ir termodinamiskais cikls", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 22, Question = "Uzzīmēt Karno ciklu p-v koordinātu sistēmā. Paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 23, Question = "Kā izsaka Karno cikla lietderības koeficientu", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 24, Question = "Uzrakstīt kādu no otrā termodinamikas likuma formulējumiem", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 25, Question = "Kas ir ekserģija", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 26, Question = "Ar ko atšķiras reāla gāze no ideālas", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 27, Question = "Uzrakstīt Van der Vālsa vienādojumu reālai gāzei un paskaidrot tā locekļus", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 28, Question = "Kas ir ūdens trīskāršais punkts", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 29, Question = "Kas ir pārkarsēts tvaiks", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 30, Question = "Kas ir mitrs tvaiks", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 31, Question = "Kas ir sauss piesātināts tvaiks", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 32, Question = "Kādai vielas fāzei piemīt īpatnējie tilpumi, ko apzīmē ar: v’, v’’, v, vx", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 33, Question = "Kas ir ūdens iztvaikošanas siltums", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 34, Question = "Kas veido ūdens iztvaikošanas siltumu", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 35, Question = "Kāds ir un kam ir proporcionāls darbs un iekšējās enerģijas izmaiņa tvaikam izohoriskā procesā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 36, Question = "Kāds ir un kam ir proporcionāls darbs un iekšējās enerģijas izmaiņa tvaikam adiabātiskā procesā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 37, Question = "Kas ir rasas punkts mitram gaisam", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 38, Question = "Kas ir gaisa relatīvais mitrums, mērvienība", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 39, Question = "Kas ir gaisa absolūtais mitrums, mērvienība", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 40, Question = "Kas ir gaisa mitruma saturs, mērvienība", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 41, Question = "Ko sauc par gāzi tvaika-gāzes maisījumā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 42, Question = "Ko sauc par tvaiku tvaika-gāzes maisījumā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 43, Question = "Uzzīmēt kompresora ideālo ciklu, paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 44, Question = "Uzzīmēt iekšdedzes motora Otto ciklu p-v koordinātu sistēmā, paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 45, Question = "Uzzīmēt iekšdedzes motora Dīzeļa ciklu p-v koordinātu sistēmā, paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 46, Question = "Uzzīmēt gāzes turbīnas ciklu p-v koordinātu sistēmā un paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 47, Question = "Uzzīmēt pamatcikla tvaika iekārtas shēmu, nosaukt tās sastāvdaļas", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 48, Question = "Uzzīmēt tvaika iekārtas pamatciklu T-s koordinātu sistēmā, paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 49, Question = "Uzzīmēt tvaika iekārtas ciklu ar atkārtotu tvaika pārkarsēšanu T-s koordinātu sistēmā, paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 50, Question = "Uzzīmēt saldēšanas iekārtas ideālo ciklu T-s koordinātu sistēmā, paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 51, Question = "Uzzīmēt gāzes cikla saldēšanas iekārtas shēmu, nosaukt sastāvdaļas", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 52, Question = "Uzzīmēt saldēšanas iekārtas gāzes ciklu T-s koordinātu sistēmā, paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 53, Question = "Uzzīmēt tvaika cikla saldēšanas iekārtas shēmu, nosaukt sastāvdaļas", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 54, Question = "Uzzīmēt saldēšanas iekārtas tvaika ciklu T-s koordinātu sistēmā, paskaidrot līknes", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 55, Question = "Paskaidrot saldēšanas iekārtas termodinamiskos darbības principus", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 56, Question = "Uzzīmēt siltumsūkņa shēmu, nosaukt sastāvdaļas", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 57, Question = "Paskaidrot siltumsūkņa termodinamiskos darbības principus", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 58, Question = "Kas ir siltumapmaiņa", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 59, Question = "Kādos veidos notiek siltumapmaiņa", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 60, Question = "Kā tiek pārnesta siltuma enerģija vadīšanā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 61, Question = "Kā tiek pārnesta siltuma enerģija konvekcijā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 62, Question = "Kā tiek pārnesta siltuma enerģija starošanā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 63, Question = "Kas ir temperatūras lauks", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 64, Question = "Kas ir stacionārs un nestacionārs temperatūras lauks", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 65, Question = "Ko raksturo temperatūras gradients", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 66, Question = "Kas ir siltumvadītspējas koeficients", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 67, Question = "Uzskaitīt sistēmu viennozīmīguma nosacījumus", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 68, Question = "Uzrakstīt Ņūtona vienādojumu siltuma plūsmas aprēķinam", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 69, Question = "Kas ir siltumatdeves koeficients", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 70, Question = "Uzzīmēt temperatūras sadalījumu siltumam plūstot caur plāksni pie trešās kārtas robežnosacījumiem", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 71, Question = "Kā var aprēķināt siltumpārejas koeficientu daudzslāņu plāksnei", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 72, Question = "Uzzīmēt temperatūras sadalījumu siltumam plūstot caur cilindriskas caurules sienu pie trešās kārtas robežnosacījumiem", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 73, Question = "Kas ir cauruļvadu siltumizolācijas kritiskais biezums", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 74, Question = "Kas ir apribojuma koeficients", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 75, Question = "Uzzīmēt temperatūras sadalījuma līkni ķermenī virsmas tuvumā tam dziestot no vienas puses", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 76, Question = "Uzzīmēt temperatūras sadalījuma līkni plāksnē tai dziestot no abām pusēm", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 77, Question = "Kāda ir līdzības skaitļu būtība", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 78, Question = "Kas ir brīvā konvekcija", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 79, Question = "Kas ir piespiedu konvekcija", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 80, Question = "Izskaidrot, kā notiek siltumpārnese laminārā plūsmā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 81, Question = "Izskaidrot, kā notiek siltumpārnese turbulentā plūsmā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 82, Question = "Uzzīmēt siltumatdeves koeficienta izmaiņas grafiku atkarībā no augstuma brīvai konvekcijai gar vertikālu sienu", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 83, Question = "Kas ir kodolveida kondensācija", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 84, Question = "Kas ir plēves veida kondensācija", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 85, Question = "Kas ir kodolveida iztvaikošana", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 86, Question = "Kas ir plēves veida iztvaikošana", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 87, Question = "Cik ir A, R, D absolūti melnam ķermenim", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 88, Question = "Cik ir A, R, D absolūti caurspīdīgam ķermenim", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 89, Question = "Cik ir A, R, D absolūti baltam ķermenim", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 90, Question = "Kas ir integrālais starojums", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 91, Question = "Kas ir monohromatiskais starojums", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 92, Question = "Kas ir starojuma plūsmas blīvums (intensitāte)", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 93, Question = "Paskaidrot Planka likuma būtību siltumstarošanā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 94, Question = "Paskaidrot Vjēna likuma būtību siltumstarošanā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 95, Question = "Paskaidrot Stefana-Bolcmaņa likuma būtību siltumstarošanā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 96, Question = "Paskaidrot otrā Kirhofa likuma būtību siltumstarošanā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 97, Question = "Paskaidrot Lamberta likuma būtību siltumstarošanā", Answer="", AnswerImage="" },
                new QuestionsNAnswers(){ QuestionId = 98, Question = "Uzzīmēt skici, kas paskaidro ķermeņu savstarpējo apstarošanos", Answer="", AnswerImage="" },
            };

            return res;
        }
    }

    internal class QuestionsNAnswers
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string AnswerImage { get; set; }
    }
}