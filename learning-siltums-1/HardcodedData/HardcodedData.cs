using Android.App;
using System.Collections.Generic;

namespace learning_siltums_1.HardcodedData
{
    public class HardcodedData
    {
        static int zBlank = Resource.Mipmap.blank;

        static string microChar = $"\u00b5"; // can't be subscript at the moment :/ // small mu char
        static string subscriptX = $"\u2093";
        static string smallNu_specificVolumeChar = $"\U0001D6CE";
        static string smallEtaChar = $"\u03B7"; // lietderības koeficients
        static string smallPsiChar = $"\u03C8"; // ārējās iztvaikošanas siltums
        static string smallRhoChar = $"\u03C1"; // iekšējās iztvaikošanas siltums
        static string primeChar = $"\u2032"; // prim
        static string doublePrimeChar = $"\u2033"; // 2prim
        static string triplePrimeChar = $"\u2034"; // 3prim
        static string reversePrimeChar = $"\u2035";
        static string supscript2 = $"\u00B2";
        static string supscript3 = $"\u00B3";
        static string subscript1 = $"\u2081";
        static string subscript2 = $"\u2082";
        static string subscript3 = $"\u2083";
        static string subscript4 = $"\u2084";
        static string degreeChar = $"\u00B0";
        static string subscript_t = $"\u209C";
        static string supscript_k = $"\u1D4F";
        static string supscript_leftParenthesis = $"\u207D";
        static string supscript_rightParenthesis = $"\u207E";
        static string subscript_leftParenthesis = $"\u208D";
        static string subscript_rightParenthesis = $"\u208E";

        static string q1 = $"Kas ir izolēta termodinamiska sistēma?";
        static string a1 = $"Par izolētu sauc tādu termodinamisko sistēmu, kurai nav mijiedarbības ar apkārtējo vidi.\n (9.lpp.)";
        static string q2 = $"Kas ir neizolēta termodinamiska sistēma?";
        static string a2 = $"Par neizolētu sauc tādu termodinamisko sistēmu, kas mijiedarbojas ar apkārtējo vidi.\n (9.lpp.)";
        static string q3 = $"Kas ir noslēgta termodinamiska sistēma?";
        static string a3 = $"Ja mijiedarbības rezultātā ar apkārtējo vidi termodinamiskās sistēmas ķermeņu skaits, t.i., sistēmas lielums (masa), nemainās, sistēmu sauc par noslēgtu.\n (10.lpp.)";
        static string q4 = $"Kas ir vaļēja termodinamiska sistēma?";
        static string a4 = $"Ja mijiedarbības rezultātā ar apkārtējo vidi termodinamiskās sistēmas ķermeņu skaits, t.i., sistēmas lielums (masa), mainās, sistēmu sauc par nenoslēgtu jeb vaļēju.\n (10.lpp.)";
        static string q5 = $"Ko raksturo ķermeņa temperatūra?";
        static string a5 = $"Temperatūra raksturo termodinamiskās sistēmas un tās sastāvdaļu siltuma pakāpi.\n (11.lpp.)";
        static string q6 = $"Uzrakstīt skaitlisko sakarību starp absolūto un Celsija skalas temperatūru";
        static string a6 = $"1K = 1{degreeChar}C; T=t+273.15{degreeChar}C\n (11.lpp.)";
        static string q7 = $"Definēt spiedienu";
        static string a7 = $"Spiediens ir spēks, ar kādu darba ķermenis iedarbojas uz virsmas laukuma vienību\n (12.lpp.)";
        static string q8 = $"Kādas ir spiediena mērvienības SI un citās sistēmās?";
        static string a8 = $"N/m{supscript2} jeb Pa (paskāls). Normālā fiziskā atmosfēra (bar?), tehniskā atmosfēra (at), mm H{subscript2}O staba, mm Hg staba\n (12.lpp.)";
        static string q9 = $"Kas ir īpatnējais tilpums, tā mērvienība?";
        static string a9 = $"Īpatnējais tilpums ir darba vielas viena masas kilograma ieņemtais tilpums, ko pieņemts apzīmēt ar {smallNu_specificVolumeChar}. {smallNu_specificVolumeChar}=V/M, kur V - darba vielas kopējais tilpums (m{supscript3}), M - darba vielas masa (kg).\n (14.-15.lpp.)";
        static string q10 = $"Kas ir darba ķermeņa normālie apstākļi?";
        static string a10 = $"T=273.15K jeb t=0{degreeChar}C; spiediens p=101325 Pa jeb 1 fizikālā atmosfēra (bar).\n (15.lpp.)";
        static string q11 = $"Kas ir entalpija, tās mērvienība?";
        static string a11 = $"Termodinamiskās sistēmas iekšējās enerģijas un tilpuma enerģijas summa. Entalpiju apzīmē ar h, mērvienība J/kg vai kJ/kg.\n (16.lpp.)";
        static string q12 = $"Kāda ir entropijas mērvienība?";
        static string a12 = $"J/K vai kJ/K\n (17.lpp.)";
        static string q13 = $"Kas ir termodinamiskais process?";
        static string a13 = $"Termodinamiskās sistēmas stāvokļa (parametru) secīga maiņa laikā.\n (17.lpp.)";
        static string q14 = $"Kas ir ideāla gāze?";
        static string a14 = $"Par ideālu gāzi sauc tādu gāzes modeli, kas sastāv no absolūti elestīgām daļiņām (molekulām), kuru tilpumu var neievērot un starp kurām nedarbojas savstarpējie pievilkšanās spēki.\n (19.lpp.)";
        static string q15 = $"Uzrakstīt gāzes stāvokļa vienādojumu ideālai gāzei";
        static string a15 = $"F(T, p, {smallNu_specificVolumeChar}) = 0. T - temperatūra K (kelvins); p - spiediens Pa (paskāls), {smallNu_specificVolumeChar} - īpatnējais tilpums m{supscript3}/kg.\n (19.lpp.)";
        static string q16 = $"Kas ir gāzes individuālā konstante, mērvienība?";
        static string a16 = $"Gāzes individuālā konstante ir darba daudzums, ko padara viens kilograms gāzes izplešoties, ja tās temperatūra paaugstinās par vienu grādu. Apzīmē ar R, mērvienība - J/Kg*K.\n (21.lpp.)";
        static string q17 = $"Kas ir īpatnējā siltumietilpība, mērvienība?";
        static string a17 = $"Par vielas īpatnējo siltumietilpību (siltumkapacitāti) sauc siltuma daudzumu, kas jāpievada vielas masas vienībai, lai tās temperatūru paagustinātu par vienu kelvinu (grādu).\n (26.lpp.)";
        static string q18 = $"Kādi ir īpatnējās siltumietilpības veidi, mērvienības?";
        static string a18 = $"1) masas īpatnējā siltumietilpība, apzīmē ar c, mērvienība(dimensija) - J/(kg*K);\n2) tilpuma īpatnējā siltumietilpība, apzīmē ar c', mērvienība (dimensija) - J/(m{supscript3}*K);\n3) molārā īpatnējā siltumietilpība, apzīmē ar c{microChar}, mērvienība (dimensija) - J/(mol*K).\n (26.lpp.)";
        static string q19 = $"Pirmais termodinamikas likums";
        static string a19 = $"Pirmais termodinamikas likums ir enerģjas nezūdamības likuma atsevišķs gadījums, kas iegūts, piemērojot to enerģijas pārejas siltuma un darba formām. Siltums un darbs jāuzskata par enerģijas pārejas un pastāvēšanas veidiem termodinamiskā procesa gaidā. Šie enerģijas veidi noteiktos apstākļos var pārveidoties cits citā. Saskaņā ar enerģijas nezūdamības likumu visu enerģijas veidu summa izolētā sistēmā paliek bez izmaiņām.\n (28.lpp.)";
        static string q20 = $"Nosaukt termodinamikas pamatprocesus";
        static string a20 = $"1) izohorais (izohoriskais) process, kur {smallNu_specificVolumeChar}=const ({smallNu_specificVolumeChar} - īpatnējais tilpums);\n 2) izobārais (izbāriskais) process, kur p=const (p - spiediens);\n 3) izotermais (izotermiskais) process, kur T=const (T - temperatūra kelvinos);\n4)adiabātais (adiabātiskais) process, kur q=const (q - īpatnējā siltumietilpība);\n 5) politropais (politropiskais) rocess, kas ir vispārināts termodinamiskais process.\n (34.lpp.)";
        static string q21 = $"Kas ir termodinamiskais cikls?";
        static string a21 = $"Par termodinamisko ciklu sauc secīgi notiekošu termodinamisko procesu kopu, kuru gaitā darba ķermenis, maintot savu stāvokli, atkal atgriežas sākotnējā stāvokolī, t.i., iegūst sākotnējā stāvokļa parametrus. Dažreiz termodinamisko ciklu sauc arī par noslēgtu vai ciklisku procesu.\n (45.lpp.)";
        static string q22 = $"Uzzīmēt Karno ciklu p-{smallNu_specificVolumeChar} koordinātu sistēmā. Paskaidrot līknes?";
        static string a22 = $"Skatīt zīmējumu (uzzīmēt protams savu).\n Procesā 1-2 gāzei siltumu izotermi pievada\n procesā 2-3 darba ķermenis turpina adiabāti izplesties\n procesā 3-4 siltumu izotermi novada, saspiežot darba ķermeni\n procesā 4-1 turpina adiabātu darba ķermeņa saspiešanu.\n (47.lpp.)";
        static int z22 = Resource.Mipmap.Karno_cikls;
        static string q23 = $"Kā izsaka Karno cikla lietderības koeficientu?";
        static string a23 = $"{smallEtaChar}{subscript_t}{supscript_leftParenthesis}{supscript_k}{supscript_rightParenthesis}=(q{subscript1}-q{subscript2})/q{subscript2}=(RT{primeChar}ln({smallNu_specificVolumeChar}{subscript2}/{smallNu_specificVolumeChar}{subscript1})-RT{doublePrimeChar}ln({smallNu_specificVolumeChar}{subscript3}/{smallNu_specificVolumeChar}{subscript4}))/(RT{primeChar}ln({smallNu_specificVolumeChar}{subscript2}/{smallNu_specificVolumeChar}{subscript1})); saīsinot {smallEtaChar}{subscript_t}{supscript_leftParenthesis}{supscript_k}{supscript_rightParenthesis}=(T{primeChar}-T{doublePrimeChar})/T{primeChar}=1-(T{doublePrimeChar}/T{primeChar})\n (48.lpp.)";// 
        static string q24 = $"Uzrakstīt kādu no otrā termodinamikas likuma formulējumiem";
        static string a24 = $"1. Siltuma pārveidošanai darbā nepieciešama temperatūru diference starp siltuma avotu un dzesētāju (S. Karno, 1824. gads).\n 2. Siltums pats no sevis bez papildu enerģijas patēriņa nevar pāriet no aukstāka ķermeņa uz siltāku ķermeni (R. Klauziuss, 1850. gads).\n 3. Nav iespējams izveidot tādu periodiski darbojošos dzinēju, ura darbības rezultāts būtu vienīgi sistēmas zemākās temperatūras siltuma pārvēršana darbā (V. Tomsons, 1851. gads).\n 4. Cikliskā procesā visu pievadīto siltumu nevar pārvērst mehāniskajā enerģijā (M. Planks, 1892. gads).\n 5. Visi procesi dabā patvaļīgi noris virzienā no stāvokļa ar mazāku varbūtību uz stāvokli ar lielāku varbūtību (L. Bolcmanis).\n (50.-51.lpp.)";
        static string q25 = $"Kas ir ekserģija?";
        static string a25 = $"Par ekserģiju E sauc to termodinamiskās sistēmas enerģijas daļu, ko var pārvērst mehāniskajā vai elektriskajā enerģijā, ja sistēma atgriezenisku procesu veidā nonāk līdzsvarā ar apkārtējo vidi. Šādi atgriezeniskie procesi ir adiabāta un izoterma.\n Tātad ekserģija ir maksimālais darbs, ko var paveikt termodinamiskā sistēma.\n (57.lpp.)";
        static string q26 = $"Ar ko atšķiras reāla gāze no ideālas?";
        static string a26 = $"Reālās gāzes no ideālajām gāzēm atšķiras galvenokārt ar to, ka molekulām ir masa un tilpums un starp tām pastāv mijiedarbības spēki.\n (65.lpp.)";
        static string q27 = $"Uzrakstīt Van der Vālsa vienādojumu reālai gāzei un paskaidrot tā locekļus";
        static string a27 = $"Van der Vālsa vienādojums -> (p+(a/{smallNu_specificVolumeChar}{supscript2}))({smallNu_specificVolumeChar}-b)=RT.\n Tā kā reālo gāu molekulām ir tilums, tas it kā samazina gāzes aizņemto brīvo tilpumu {smallNu_specificVolumeChar} par kādu lielumu b.\n Starp gāzes molekulām darbojās savstarpējie pievilkšanās spēki, kas it kā palielina ārējo spiedienu. Van der Vālss pierādija, ka šo papildu spiedienu var izteikt kā a/{smallNu_specificVolumeChar}{supscript2}, kur a - koeficients.\n Tātad p+a/{smallNu_specificVolumeChar}{supscript2} ir gāzes spiediens + papildus spiediens, kas rodās no pievilkšanās spēkiem un {smallNu_specificVolumeChar}-b ir gāzes īpatnējais 'brīvais' tilpums no kura atņem gāzu molekulu tilpumu. R - gāzes individuālā konstante, T - gāzes temperatūra. (65.-66.lpp.)";
        static string q28 = $"Kas ir ūdens trīskāršais punkts?";
        static string a28 = $"Noteiktā spiedienā un temperatūrā iestājas līdzsvars starp ūdens cieto fāzi (ledu), šķidrumu un tvaiku. (69.lpp.)";
        static string q29 = $"Kas ir pārkarsēts tvaiks?";
        static string a29 = $"Pārkarsēts tvaiks ir tvaiks, kura temperatūra sāk paaugstināties virs iztvaikošanas (piesātināšanas) temperatūras. (70.lpp.)";
        static string q30 = $"Kas ir mitrs tvaiks?";
        static string a30 = $"Mitrs tvaiks ir tvaiks kas satur gan sausu tvaiku, gan tvaikā nepārvērsa šķidruma daļiņas, t. i., visa šķidrā fāze nav pilnīgi iztvaikojusi un tvaika temperatūra atbilst vārīšanās temperatūrai dotajā spiedienā. (70.lpp.)";
        static string q31 = $"Kas ir sauss piesātināts tvaiks?";
        static string a31 = $"Sauss piesātināts tvaiks ir tvaiks kas nesatur tvaikā nepārvērsta šķitruma daļiņas, t. i., visa šķidrā fāze ir pilnībā iztvaikojusi un tvaika temperatūra atbilst vārīšanās temperatūrai dotajā spiedienā. (70.lpp.)";
        static string q32 = $"Kādai vielas fāzei piemīt īpatnējie tilpumi, ko apzīmē ar: {smallNu_specificVolumeChar}{primeChar}, {smallNu_specificVolumeChar}{doublePrimeChar}, {smallNu_specificVolumeChar}, {smallNu_specificVolumeChar}{subscriptX}?";
        static string a32 = $"{smallNu_specificVolumeChar}{primeChar} - verdošam šķidrumam;\n {smallNu_specificVolumeChar}{doublePrimeChar} - sausam piesātinātam tvaikam;\n {smallNu_specificVolumeChar} - pārkarsētam tvaikam;\n {smallNu_specificVolumeChar}{subscriptX} - mitram tvaikam.\n (71.lpp.)";
        static string q33 = $"Kas ir ūdens iztvaikošanas siltums?";
        static string a33 = $"Iztvaikošanas siltums ir siltuma daudzumsr, kas jāpievada 1kg šķidruma (ūdens) piesātināšanas stāvoklī, lai to pilnīgi pārvērstu sausā piesātinātā tvaikā. r - J/kg. (73.lpp.)";
        static string q34 = $"Kas veido ūdens iztvaikošanas siltumu?";
        static string a34 = $"Ūdens iztvaikošanas siltumu (r) veido iekšējās iztvaikošanas siltuma ({smallRhoChar}) un ārējā iztvaikošanas siltuma ({smallPsiChar}) summa.\n r=u{doublePrimeChar}-u{primeChar}+p({smallNu_specificVolumeChar}{doublePrimeChar}-{smallNu_specificVolumeChar}{primeChar} jeb r={smallRhoChar}+{smallPsiChar}). (73.lpp.)";
        static string q35 = $"Kāds ir un kam ir proporcionāls darbs un iekšējās enerģijas izmaiņa tvaikam izohoriskā procesā?";
        static string a35 = $"";
        static string q36 = $"Kāds ir un kam ir proporcionāls darbs un iekšējās enerģijas izmaiņa tvaikam adiabātiskā procesā";
        static string a36 = $"";
        static string q37 = $"Kas ir rasas punkts mitram gaisam?";
        static string a37 = $"";
        static string q38 = $"Kas ir gaisa relatīvais mitrums, mērvienība?";
        static string a38 = $"";
        static string q39 = $"Kas ir gaisa absolūtais mitrums, mērvienība?";
        static string a39 = $"";
        static string q40 = $"Kas ir gaisa mitruma saturs, mērvienība?";
        static string a40 = $"";
        static string q41 = $"Ko sauc par gāzi tvaika-gāzes maisījumā?";
        static string a41 = $"";
        static string q42 = $"Ko sauc par tvaiku tvaika-gāzes maisījumā?";
        static string a42 = $"";
        static string q43 = $"Uzzīmēt kompresora ideālo ciklu, paskaidrot līknes";
        static string a43 = $"";
        static string q44 = $"Uzzīmēt iekšdedzes motora Otto ciklu p-{smallNu_specificVolumeChar} koordinātu sistēmā, paskaidrot līknes";
        static string a44 = $"";
        static string q45 = $"Uzzīmēt iekšdedzes motora Dīzeļa ciklu p-{smallNu_specificVolumeChar} koordinātu sistēmā, paskaidrot līknes";
        static string a45 = $"";
        static string q46 = $"Uzzīmēt gāzes turbīnas ciklu p-{smallNu_specificVolumeChar} koordinātu sistēmā un paskaidrot līknes";
        static string a46 = $"";
        static string q47 = $"Uzzīmēt pamatcikla tvaika iekārtas shēmu, nosaukt tās sastāvdaļas";
        static string a47 = $"";
        static string q48 = $"Uzzīmēt tvaika iekārtas pamatciklu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a48 = $"";
        static string q49 = $"Uzzīmēt tvaika iekārtas ciklu ar atkārtotu tvaika pārkarsēšanu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a49 = $"";
        static string q50 = $"Uzzīmēt saldēšanas iekārtas ideālo ciklu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a50 = $"";
        static string q51 = $"Uzzīmēt gāzes cikla saldēšanas iekārtas shēmu, nosaukt sastāvdaļas";
        static string a51 = $"";
        static string q52 = $"Uzzīmēt saldēšanas iekārtas gāzes ciklu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a52 = $"";
        static string q53 = $"Uzzīmēt tvaika cikla saldēšanas iekārtas shēmu, nosaukt sastāvdaļas";
        static string a53 = $"";
        static string q54 = $"Uzzīmēt saldēšanas iekārtas tvaika ciklu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a54 = $"";
        static string q55 = $"Paskaidrot saldēšanas iekārtas termodinamiskos darbības principus";
        static string a55 = $"";
        static string q56 = $"Uzzīmēt siltumsūkņa shēmu, nosaukt sastāvdaļas";
        static string a56 = $"";
        static string q57 = $"Paskaidrot siltumsūkņa termodinamiskos darbības principus";
        static string a57 = $"";
        static string q58 = $"Kas ir siltumapmaiņa?";
        static string a58 = $"";
        static string q59 = $"Kādos veidos notiek siltumapmaiņa?";
        static string a59 = $"";
        static string q60 = $"Kā tiek pārnesta siltuma enerģija vadīšanā?";
        static string a60 = $"";
        static string q61 = $"Kā tiek pārnesta siltuma enerģija konvekcijā?";
        static string a61 = $"";
        static string q62 = $"Kā tiek pārnesta siltuma enerģija starošanā?";
        static string a62 = $"";
        static string q63 = $"Kas ir temperatūras lauks?";
        static string a63 = $"";
        static string q64 = $"Kas ir stacionārs un nestacionārs temperatūras lauks?";
        static string a64 = $"";
        static string q65 = $"Ko raksturo temperatūras gradients?";
        static string a65 = $"";
        static string q66 = $"Kas ir siltumvadītspējas koeficients?";
        static string a66 = $"";
        static string q67 = $"Uzskaitīt sistēmu viennozīmīguma nosacījumus";
        static string a67 = $"";
        static string q68 = $"Uzrakstīt Ņūtona vienādojumu siltuma plūsmas aprēķinam";
        static string a68 = $"";
        static string q69 = $"Kas ir siltumatdeves koeficients?";
        static string a69 = $"";
        static string q70 = $"Uzzīmēt temperatūras sadalījumu siltumam plūstot caur plāksni pie trešās kārtas robežnosacījumiem";
        static string a70 = $"";
        static string q71 = $"Kā var aprēķināt siltumpārejas koeficientu daudzslāņu plāksnei?";
        static string a71 = $"";
        static string q72 = $"Uzzīmēt temperatūras sadalījumu siltumam plūstot caur cilindriskas caurules sienu pie trešās kārtas robežnosacījumiem";
        static string a72 = $"";
        static string q73 = $"Kas ir cauruļvadu siltumizolācijas kritiskais biezums?";
        static string a73 = $"";
        static string q74 = $"Kas ir apribojuma koeficients?";
        static string a74 = $"";
        static string q75 = $"Uzzīmēt temperatūras sadalījuma līkni ķermenī virsmas tuvumā tam dziestot no vienas puses";
        static string a75 = $"";
        static string q76 = $"Uzzīmēt temperatūras sadalījuma līkni plāksnē tai dziestot no abām pusēm";
        static string a76 = $"";
        static string q77 = $"Kāda ir līdzības skaitļu būtība?";
        static string a77 = $"";
        static string q78 = $"Kas ir brīvā konvekcija?";
        static string a78 = $"";
        static string q79 = $"Kas ir piespiedu konvekcija?";
        static string a79 = $"";
        static string q80 = $"Izskaidrot, kā notiek siltumpārnese laminārā plūsmā";
        static string a80 = $"";
        static string q81 = $"Izskaidrot, kā notiek siltumpārnese turbulentā plūsmā";
        static string a81 = $"";
        static string q82 = $"Uzzīmēt siltumatdeves koeficienta izmaiņas grafiku atkarībā no augstuma brīvai konvekcijai gar vertikālu sienu";
        static string a82 = $"";
        static string q83 = $"Kas ir kodolveida kondensācija?";
        static string a83 = $"";
        static string q84 = $"Kas ir plēves veida kondensācija?";
        static string a84 = $"";
        static string q85 = $"Kas ir kodolveida iztvaikošana?";
        static string a85 = $"";
        static string q86 = $"Kas ir plēves veida iztvaikošana?";
        static string a86 = $"";
        static string q87 = $"Cik ir A, R, D absolūti melnam ķermenim?";
        static string a87 = $"";
        static string q88 = $"Cik ir A, R, D absolūti caurspīdīgam ķermenim?";
        static string a88 = $"";
        static string q89 = $"Cik ir A, R, D absolūti baltam ķermenim?";
        static string a89 = $"";
        static string q90 = $"Kas ir integrālais starojums?";
        static string a90 = $"";
        static string q91 = $"Kas ir monohromatiskais starojums?";
        static string a91 = $"";
        static string q92 = $"Kas ir starojuma plūsmas blīvums (intensitāte)?";
        static string a92 = $"";
        static string q93 = $"Paskaidrot Planka likuma būtību siltumstarošanā";
        static string a93 = $"";
        static string q94 = $"Paskaidrot Vjēna likuma būtību siltumstarošanā";
        static string a94 = $"";
        static string q95 = $"Paskaidrot Stefana-Bolcmaņa likuma būtību siltumstarošanā";
        static string a95 = $"";
        static string q96 = $"Paskaidrot otrā Kirhofa likuma būtību siltumstarošanā";
        static string a96 = $"";
        static string q97 = $"Paskaidrot Lamberta likuma būtību siltumstarošanā";
        static string a97 = $"";
        static string q98 = $"Uzzīmēt skici, kas paskaidro ķermeņu savstarpējo apstarošanos";
        static string a98 = $"";

        public static List<QuestionAndAnswers> GetQnAList()
        {
            var res = new List<QuestionAndAnswers>()
            {
                new QuestionAndAnswers(){ QuestionId = 1, Question = q1, Answer = a1, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 2, Question = q2, Answer = a2, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 3, Question = q3, Answer = a3, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 4, Question = q4, Answer = a4, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 5, Question = q5, Answer = a5, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 6, Question = q6, Answer = a6, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 7, Question = q7, Answer = a7, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 8, Question = q8, Answer = a8, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 9, Question = q9, Answer = a9, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 10, Question = q10, Answer = a10, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 11, Question = q11, Answer = a11, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 12, Question = q12, Answer = a12, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 13, Question = q13, Answer = a13, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 14, Question = q14, Answer = a14, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 15, Question = q15, Answer = a15, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 16, Question = q16, Answer = a16, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 17, Question = q17, Answer = a17, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 18, Question = q18, Answer = a18, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 19, Question = q19, Answer = a19, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 20, Question = q20, Answer = a20, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 21, Question = q21, Answer = a21, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 22, Question = q22, Answer = a22, AnswerImage = z22, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 23, Question = q23, Answer = a23, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 24, Question = q24, Answer = a24, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 25, Question = q25, Answer = a25, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 26, Question = q26, Answer = a26, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 27, Question = q27, Answer = a27, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 28, Question = q28, Answer = a28, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 29, Question = q29, Answer = a29, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 30, Question = q30, Answer = a30, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 31, Question = q31, Answer = a31, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 32, Question = q32, Answer = a32, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 33, Question = q33, Answer = a33, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 34, Question = q34, Answer = a34, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 35, Question = q35, Answer = a35, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 36, Question = q36, Answer = a36, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 37, Question = q37, Answer = a37, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 38, Question = q38, Answer = a38, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 39, Question = q39, Answer = a39, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 40, Question = q40, Answer = a40, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 41, Question = q41, Answer = a41, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 42, Question = q42, Answer = a42, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 43, Question = q43, Answer = a43, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 44, Question = q44, Answer = a44, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 45, Question = q45, Answer = a45, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 46, Question = q46, Answer = a46, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 47, Question = q47, Answer = a47, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 48, Question = q48, Answer = a48, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 49, Question = q49, Answer = a49, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 50, Question = q50, Answer = a50, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 51, Question = q51, Answer = a51, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 52, Question = q52, Answer = a52, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 53, Question = q53, Answer = a53, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 54, Question = q54, Answer = a54, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 55, Question = q55, Answer = a55, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 56, Question = q56, Answer = a56, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 57, Question = q57, Answer = a57, AnswerImage = zBlank, Points = 2 },
                new QuestionAndAnswers(){ QuestionId = 58, Question = q58, Answer = a58, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 59, Question = q59, Answer = a59, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 60, Question = q60, Answer = a60, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 61, Question = q61, Answer = a61, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 62, Question = q62, Answer = a62, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 63, Question = q63, Answer = a63, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 64, Question = q64, Answer = a64, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 65, Question = q65, Answer = a65, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 66, Question = q66, Answer = a66, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 67, Question = q67, Answer = a67, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 68, Question = q68, Answer = a68, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 69, Question = q69, Answer = a69, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 70, Question = q70, Answer = a70, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 71, Question = q71, Answer = a71, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 72, Question = q72, Answer = a72, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 73, Question = q73, Answer = a73, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 74, Question = q74, Answer = a74, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 75, Question = q75, Answer = a75, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 76, Question = q76, Answer = a76, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 77, Question = q77, Answer = a77, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 78, Question = q78, Answer = a78, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 79, Question = q79, Answer = a79, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 80, Question = q80, Answer = a80, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 81, Question = q81, Answer = a81, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 82, Question = q82, Answer = a82, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 83, Question = q83, Answer = a83, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 84, Question = q84, Answer = a84, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 85, Question = q85, Answer = a85, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 86, Question = q86, Answer = a86, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 87, Question = q87, Answer = a87, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 88, Question = q88, Answer = a88, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 89, Question = q89, Answer = a89, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 90, Question = q90, Answer = a90, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 91, Question = q91, Answer = a91, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 92, Question = q92, Answer = a92, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 93, Question = q93, Answer = a93, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 94, Question = q94, Answer = a94, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 95, Question = q95, Answer = a95, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 96, Question = q96, Answer = a96, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 97, Question = q97, Answer = a97, AnswerImage = zBlank, Points = 1 },
                new QuestionAndAnswers(){ QuestionId = 98, Question = q98, Answer = a98, AnswerImage = zBlank, Points = 1 },
            };

            return res;
        }
    }
}