using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__2.Part_2
{
    public class Music_Instrument
    {
        public string InstName { get; set; }
        public string InstDescription { get; set; }
        public string InstSound { get; set; }
        public string InstHistory { get; set; }



        public void Sound() { Console.WriteLine(this.InstSound + "\n"); }
        public void Show() { Console.WriteLine($"Instrument name: {this.InstName} \n"); }
        public void Desc() { Console.WriteLine($"What is it: {this.InstDescription} \n"); }
        public void History() { Console.WriteLine($"What is this history: {this.InstHistory}  \n"); }
    }

    public class Violin : Music_Instrument
    {
        public Violin()
        {
            this.InstName = "Violin";
            this.InstSound = "*violin's sound*";
            this.InstDescription = "The violin, sometimes known as a fiddle, is a wooden chordophone (string instrument) in the violin family." +
                                                " Most violins have a hollow wooden body. It is the smallest and thus highest-pitched instrument (soprano) " +
                                                "in the family in regular use.";
            
            this.InstHistory = "The earliest stringed instruments were mostly plucked (for example, the Greek lyre)." +
                                         " Two-stringed, bowed instruments, played upright and strung and bowed with horsehair," +
                                         " may have originated in the nomadic equestrian cultures of Central Asia," +
                                         " in forms closely resembling the modern-day Mongolian Morin huur and the Kazakh Kobyz." +
                                         " Similar and variant types were probably disseminated along east–west trading routes from Asia into the Middle East," +
                                         " and the Byzantine Empire.\r\n\r\nAccording to Encyclopædia Britannica, the direct ancestor of all European bowed instruments" +
                                         " is the Arabic rebab (ربابة), which developed into the Byzantine lyra by the 9th century and later the European rebec." +
                                         " Several sources suggest alternative possibilities for the violin's origins, such as northern or western Europe." +
                                         " The first makers of violins probably borrowed from various developments of the Byzantine lyra. " +
                                         "These included the vielle (also known as the fidel or viuola) and the lira da braccio." +
                                         "The violin in its present form emerged in early 16th-century northern Italy. The earliest pictures of violins, albeit with three strings," +
                                         " are seen in northern Italy around 1530, at around the same time as the words \"violino\" and \"vyollon\" are seen in Italian and French documents. " +
                                         "One of the earliest explicit descriptions of the instrument, including its tuning, is from the Epitome musical by Jambe de Fer, published in Lyon in 1556." +
                                         " By this time, the violin had already begun to spread throughout Europe.\r\n\r\nThe violin proved very popular, both among street musicians and the nobility;" +
                                         " the French king Charles IX ordered Andrea Amati to construct 24 violins for him in 1560." +
                                         " One of these \"noble\" instruments, the Charles IX, is the oldest surviving violin." +
                                         " The finest Renaissance carved and decorated violin in the world is the Gasparo da Salò (c.1574) owned by Ferdinand II, " +
                                         "Archduke of Austria and later, from 1841, by the Norwegian virtuoso Ole Bull, who used it for forty years and thousands of concerts," +
                                         " for its very powerful and beautiful tone, similar to that of a Guarneri. \"The Messiah\" or \"Le Messie\" (also known as the \"Salabue\")" +
                                         " made by Antonio Stradivari in 1716 remains pristine. It is now located in the Ashmolean Museum of Oxford.";
        }
    }
    public class Trombone : Music_Instrument
    {
        public Trombone()
        {
            this.InstName = "Trombone";
            this.InstSound = "*trombone's sound*";
            this.InstDescription = "The trombone (German: Posaune, Italian, French: trombone) is a musical instrument in the brass family." +
                                               " As with all brass instruments, sound is produced when the player's vibrating lips cause the air column" +
                                               " inside the instrument to vibrate. Nearly all trombones use a telescoping slide mechanism" +
                                               " to alter the pitch instead of the valves used by other brass instruments. ";
            this.InstHistory = "Both towns and courts sponsored bands of shawms and trombone." +
                                         " The most famous and influential served the Duke of Burgundy. " +
                                         "The trombone's principal role was the contratenor part in a dance band." +
                                         " The sackbut was used extensively across Europe, from its appearance in the 15th" +
                                         " century to a decline in most places by the mid-late 17th century." +
                                         " It was used in outdoor events, in concert, and in liturgical settings. With trumpeters," +
                                         " trombonists in German city-states were employed as civil officials." +
                                         " As officials, these trombonists were often relegated to standing watch in the city towers but would also herald the arrival of important people to the city." +
                                         " This is similar to the role of a military bugler and was used as a sign of wealth and strength in 16th century German cities." +
                                         "\r\n\r\nHowever, these trombonists were often viewed separately from the more skilled" +
                                         " trombonists who played in groups such as the alta capella wind ensembles and the first orchestral ensembles. " +
                                         "These performed in religious settings, such as St Mark's Basilica in Venice in the early 17th century.";
        }
    }
    public class Ukulele : Music_Instrument
    {
        public Ukulele()
        {
            this.InstName = "Ukulele";
            this.InstSound = "*ukulele's sound*";
            this.InstDescription = "The ukulele, also called a uke, is a member of the lute family of instruments of Portuguese origin and popularized in Hawaii." +
                                               " It generally employs four nylon strings.\r\n\r\nThe tone and volume of the instrument vary with size and construction." +
                                               " Ukuleles commonly come in four sizes: soprano, concert, tenor, and baritone.";
            this.InstHistory = "Developed in the 1880s, the ukulele is based on several small, guitar-like instruments of Portuguese origin, the machete,cavaquinho, timple, and rajão," +
                                         " introduced to the Hawaiian Islands by Portuguese immigrants from Madeira, the Azores and Cape Verde." +
                                         " Three immigrants in particular, Madeiran cabinet makers Manuel Nunes, José do Espírito Santo, and Augusto Dias," +
                                         " are generally credited as the first ukulele makers.Two weeks after they disembarked from the SS Ravenscrag in late August 1879," +
                                         " the Hawaiian Gazette reported that \"Madeira Islanders recently arrived here," +
                                         " have been delighting the people with nightly street concerts.\"\r\n\r\nOne of the most important factors in establishing" +
                                         " the ukulele in Hawaiian music and culture was the ardent support and promotion of the instrument by King Kalākaua." +
                                         " A patron of the arts, he incorporated it into performances at royal gatherings.";
        }
    }
    public class Cello : Music_Instrument
    {
        public Cello()
        {
            this.InstName = "Cello";
            this.InstSound = "*cello's sound*";
            this.InstDescription = "The cello, or violoncello, is a bowed (sometimes plucked and occasionally hit) string instrument of the violin family." +
                                               " Its four strings are usually tuned in perfect fifths: from low to high, C2, G2, D3 and A3." +
                                               " The viola's four strings are each an octave higher. Music for the cello is generally written in the bass clef," +
                                               " with tenor clef, and treble clef used for higher-range passages.";
            this.InstHistory = "The violin family, including cello-sized instruments, emerged c. 1500 as a family of instruments distinct from the viola da gamba family." +
                                         " The earliest depictions of the violin family, from northern Italy c. 1530, show three sizes of instruments, roughly corresponding to what we now call violins," +
                                         " violas, and cellos. Contrary to a popular misconception, the cello did not evolve from the viola da gamba, but existed alongside it for about two and a half centuries. " +
                                         "The violin family is also known as the viola da braccio (meaning viola for the arm) family, " +
                                         "a reference to the primary way the members of the family are held. This is to distinguish it from the viola da gamba (meaning viola for the leg) family, " +
                                         "in which all the members are all held with the legs. The likely predecessors of the violin family include the lira da braccio and the rebec." +
                                         " The earliest surviving cellos are made by Andrea Amati, the first known member of the celebrated Amati family of luthiers." +
                                         "\r\n\r\nThe direct ancestor to the violoncello was the bass violin. Monteverdi referred to the instrument as \"basso de viola da braccio\" in Orfeo (1607)." +
                                         " Although the first bass violin, possibly invented as early as 1538, was most likely inspired by the viol, it was created to be used in consort with the violin." +
                                         " The bass violin was actually often referred to as a \"violone\", or \"large viola\", as were the viols of the same period." +
                                         " Instruments that share features with both the bass violin and the viola da gamba appear in Italian art of the early 16th century.";
        }
    }
}
