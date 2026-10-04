using System.Diagnostics;
using System.Text;
using System.Text.Json;

// dostępność stron www
using System.Diagnostics;
using System.Threading;

namespace ZippoDEV
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool czyUruchomiony = true;

            while (czyUruchomiony)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("┌------------------------------┐");
                Console.Write("|           ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("ZippoDEV");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("           |");
                Console.WriteLine("└------------------------------┘");

                Console.WriteLine("┌------------------------------┐");
                // pierwsza opcja - o mnie
                Console.Write("├ ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("1 ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("- ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("O mnie");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("                   |");
                // druga opcja - moje programy
                Console.Write("├ ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("2 ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("- ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Moje programy");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("            |");
                // trzecia opcja - linki
                Console.Write("├ ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("3 ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("- ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Linki");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("                    |");
                Console.WriteLine("└------------------------------┘");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\n Wybierz opcję: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                string wybor = Console.ReadLine();

                Console.Clear();

                switch (wybor)
                {
                    case "1":
                        oMnie();
                        break;

                    case "2":
                        MojeProgramy();
                        break;

                    case "3":
                        Linki();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("┌-------------------------------------------------┐");
                        Console.Write("|                    ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("ZippoDEV");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("                     |");
                        Console.WriteLine("└-------------------------------------------------┘");

                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("┌-------------------------------------------------┐");
                        Console.Write("| ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("OPCJA JEST OBECNIE NIEDOSTĘPNA!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("                 |");
                        Console.WriteLine("└-------------------------------------------------┘");

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
                        Console.ReadKey();

                        Console.Clear();
                        break;
                }
            }
        }

        static void oMnie()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("┌-------------------------------------------------┐");
            Console.Write("|                    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("ZippoDEV");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                     |");
            Console.Write("|                     ");
            Console.Write("O mnie");
            Console.WriteLine("                      |");
            Console.WriteLine("└-------------------------------------------------┘");

            Console.WriteLine("┌-------------------------------------------------┐");
            Console.Write("| ");
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.Write("Jestem Hubert Żupa. Uczeń II klasy Technikum");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("    |");
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("na profilu - Technik Programista. Obecnie uczę");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  |");
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("się języków HTML, CSS, JavaScript oraz C# :).");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("   |");
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Lubię grać w gry typu Brawl Stars, Minecraft,");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("   |");
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("itp. oraz wrzucać filmiki na TikTok :)");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("          |");
            Console.WriteLine("└-------------------------------------------------┘");

            Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
            Console.ReadKey();

            Console.Clear();
        }

        static void MojeProgramy()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("┌-------------------------------------------------┐");
            Console.Write("|                    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("ZippoDEV");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                     |");
            Console.Write("|                  ");
            Console.Write("Moje programy");
            Console.WriteLine("                  |");
            Console.WriteLine("└-------------------------------------------------┘");

            Console.WriteLine("┌-------------------------------------------------┐");
            Console.Write("├ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("1 ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Rangi Brawl Stars");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                           |");

            Console.Write("├ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("2 ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Sprawdzanie mocy haseł");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                      |");

            Console.Write("├ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("3 ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Temperatura z dokładnością");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  |");

            Console.Write("├ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("4 ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Kalkulator spalania paliwa");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  |");

            Console.Write("├ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("5 ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Discord webhook");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                             |");

            Console.Write("├ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("6 ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Monitor dostępności stron WWW");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("               |");

            Console.Write("├ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("7 ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Gra za dużo za mało");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                         |");
            Console.WriteLine("└-------------------------------------------------┘");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n Wybierz opcję: "); string wybor = Console.ReadLine();

            Console.Clear();

            switch (wybor)
            {
                case "1":
                    RangiBrawlStars();
                    break;

                case "2":
                    SprawdzanieMocyHasel();
                    break;

                case "3":
                    TemperaturaZDokladnoscia();
                    break;

                case "4":
                    TemperaturaSpalaniaPaliwa();
                    break;

                case "5":
                    DiscordWebhook();
                    break;

                case "6":
                    MonitorDostepnosciStronWWW();
                    break;

                case "7":
                    GraZaDuzoZaMalo();
                    break;
            }

            Console.Clear();
        }

        static void Linki()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("┌-------------------------------------------------┐");
            Console.Write("|                    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("ZippoDEV");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                     |");
            Console.Write("|                     ");
            Console.Write("Linki");
            Console.WriteLine("                       |");
            Console.WriteLine("└-------------------------------------------------┘");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("┌-------------------------------------------------┐");

            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("TikTok");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("https://tiktok.com/@zippobss");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("           |");

            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("GitHub");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("https://github.com/zippobss777");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("         |");

            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Discord");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("https://dc.gg/zippodev");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                |");

            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Strona WWW");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("http://zippodev.netlify.app");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("        |");

            Console.WriteLine("└-------------------------------------------------┘");

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
            Console.ReadKey();

            Console.Clear();
        }

        static void RangiBrawlStars()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=======================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  RANGA W BRAWL STARS  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=======================");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Podaj liczbę punktów na rankedach: "); string pkt = Console.ReadLine();
            int punkty = int.Parse(pkt);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=============================");

            if (punkty > 0 && punkty <= 249)
            {
                Console.WriteLine($" Twoja ranga to: Brąz I");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 250 && punkty <= 499)
            {
                Console.WriteLine($" Twoja ranga to: Brąz II");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 500 && punkty <= 749)
            {
                Console.WriteLine($" Twoja ranga to: Brąz III");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 750 && punkty <= 999)
            {
                Console.WriteLine($" Twoja ranga to: Srebro I");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 1000 && punkty <= 1249)
            {
                Console.WriteLine($" Twoja ranga to: Srebro II");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 1250 && punkty <= 1498)
            {
                Console.WriteLine($" Twoja ranga to: Srebro III");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 1499 && punkty <= 1999)
            {
                Console.WriteLine($" Twoja ranga to: Złoto I");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 2000 && punkty <= 2499)
            {
                Console.WriteLine($" Twoja ranga to: Złoto II");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 2500 && punkty <= 2999)
            {
                Console.WriteLine($" Twoja ranga to: Złoto III");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 3000 && punkty <= 3499)
            {
                Console.WriteLine($" Twoja ranga to: Diament I");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 3500 && punkty <= 3999)
            {
                Console.WriteLine($" Twoja ranga to: Diament II");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 4000 && punkty <= 4999)
            {
                Console.WriteLine($" Twoja ranga to: Diament III");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 4500 && punkty <= 4999)
            {
                Console.WriteLine($" Twoja ranga to: Mityk I");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 5000 && punkty <= 5500)
            {
                Console.WriteLine($" Twoja ranga to: Mityk II");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 5501 && punkty <= 5999)
            {
                Console.WriteLine($" Twoja ranga to: Mityk III");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 6000 && punkty <= 6749)
            {
                Console.WriteLine($" Twoja ranga to: Legenda I");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 6750 && punkty <= 7499)
            {
                Console.WriteLine($" Twoja ranga to: Legenda II");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 7500 && punkty <= 8249)
            {
                Console.WriteLine($" Twoja ranga to: Legenda III");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 8250 && punkty <= 9249)
            {
                Console.WriteLine($" Twoja ranga to: Master I");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 9250 && punkty <= 10249)
            {
                Console.WriteLine($" Twoja ranga to: Master II");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty > 10250 && punkty <= 11249)
            {
                Console.WriteLine($" Twoja ranga to: Master III");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            if (punkty >= 11250)
            {
                Console.WriteLine($" Twoja ranga to: PRO");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=============================");

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
            Console.ReadKey();

            Console.Clear();
        }

        static void SprawdzanieMocyHasel()
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("  Witaj użytkowniku w testowaniu mocy Twojego hasła przygotowanego przez ZippoDEV ;)!  ");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Wprowadź hasło: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string pass = Console.ReadLine();
            Console.WriteLine("");

            Console.Clear();

            int moc = 0;

            string porady = "";

            if (pass.Contains(" "))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("WYKRYTO SPACJĘ! NIE MOŻNA WYKONAĆ ŻĄDANIA!");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                return;
            }

            int ileDuzych = 0;
            int ileMalych = 0;
            int ileCyfr = 0;
            int ileSpecjalnych = 0;

            foreach (char c in pass)
            {
                if (char.IsUpper(c))
                {
                    ileDuzych++;
                }

                //

                if (char.IsLower(c))
                {
                    ileMalych++;
                }

                //

                if (char.IsDigit(c))
                {
                    ileCyfr++;
                }

                //

                if (!char.IsLetterOrDigit(c))
                {
                    ileSpecjalnych++;
                }
            }

            // długość hasła
            moc += Math.Min(pass.Length * 3, 30);
            if (pass.Length < 10)
            {
                porady += "Twoje hasło mogłoby być dłuższe (zalecane min. 10 znaków).\n";
            }

            // duże litery
            moc += Math.Min(ileDuzych * 10, 20);
            if (ileDuzych == 0)
            {
                porady += "Dodaj dużą literę.\n";
            }

            // małe litery
            moc += Math.Min(ileMalych * 10, 20);
            if (ileMalych == 0)
            {
                porady += "Dodaj małą literę.\n";
            }

            // cyfry
            moc += Math.Min(ileCyfr * 7, 15);
            if (ileCyfr == 0)
            {
                porady += "Dodaj przynajmniej jedną cyfrę.\n";
            }

            // znaki specjalne
            moc += Math.Min(ileSpecjalnych * 7, 15);
            if (ileSpecjalnych == 0)
            {
                porady += "Dodaj przynajmniej jeden znak specjalny.\n";
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Twoje hasło: {pass}");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            if (moc == 100)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }

            if (moc < 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            if (moc <= 80)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }

            if (moc <= 60)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            if (moc <= 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            if (moc <= 20)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }

            Console.WriteLine($"Moc hasła: {moc}%");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Black;

            if (porady != "")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Proponowane zmiany:");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"{porady}");

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
                Console.ReadKey();

                Console.Clear();
            }
        }

        static void TemperaturaZDokladnoscia()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Podaj temperaturę: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            int TemperaturaCalkowita = (int)temperatura;

            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("=========================================================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Wprowadzona temperatura (double): {temperatura}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Część całkowita (int): {TemperaturaCalkowita}");

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
            Console.ReadKey();

            Console.Clear();
        }

        static void TemperaturaSpalaniaPaliwa()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("Podaj dystans w km: ");
            string dystans = Console.ReadLine() ?? "";

            Console.Write("Podaj średnią spalania w l/100km: ");
            string sredniaSpalania = Console.ReadLine() ?? "";

            if (int.TryParse(dystans, out int trasa) && float.TryParse(sredniaSpalania, out float spalanie))
            {
                double zuzytePaliwo = (double)trasa * spalanie / 100;
                double koszt = zuzytePaliwo * 8;

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.WriteLine($"Koszt paliwa: {koszt}");

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
                Console.ReadKey();

                Console.Clear();
            }
        }

        static void DiscordWebhook()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("┌------------------------┐");
            Console.Write("|      ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ZippoWebhook");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      |");
            Console.WriteLine("└------------------------┘");
            Console.Write("\nWebhook link: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string webhook = Console.ReadLine();

            if (!webhook.StartsWith("https://discord.com/api/webhooks/"))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("┌------------------------┐");
                Console.Write("|      ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ZippoWebhook");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("      |");
                Console.WriteLine("└------------------------┘");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nBłąd: Podany link nie jest poprawnym linkiem do webhooka Discorda!");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                return;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nTreść wiadomości: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string wiadomosc = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nOpcjonalna nazwa webhooka (domyślnie: 'ZippoWebhook'): ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string nick = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nick))
            {
                nick = "ZippoWebhook";
            }

            WebhookMessage wiadomoscDiscord = new WebhookMessage();
            wiadomoscDiscord.content = wiadomosc;
            wiadomoscDiscord.username = nick;

            string jsonPayload = JsonSerializer.Serialize(wiadomoscDiscord);

            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync(webhook, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("┌------------------------┐");
                    Console.Write("|      ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("ZippoWebhook");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("      |");
                    Console.WriteLine("└------------------------┘");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nWiadomość została pomyślnie wysłana na serwer Discord!");

                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
                    Console.ReadKey();

                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("┌------------------------┐");
                    Console.Write("|      ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("ZippoWebhook");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("      |");
                    Console.WriteLine("└------------------------┘");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\nWystąpił błąd podczas wysyłania: {response.StatusCode}");

                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
                    Console.ReadKey();

                    Console.Clear();
                }
            }
        }

        static void MonitorDostepnosciStronWWW()
        {
            Stopwatch.StartNew();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Wprowadź adres url: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string url = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPodaj co ile sekund sprawdzać stronę: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            int sekundy = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n============================================");

            int czasMs = sekundy * 1000;

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            while (true)
            {
                using (HttpClient client = new HttpClient())
                {
                    Stopwatch stopwatch = Stopwatch.StartNew();

                    HttpResponseMessage response = client.GetAsync(url).Result;

                    stopwatch.Stop();

                    if (response.IsSuccessStatusCode)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n[ONLINE] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"Strona \u001b[4m{url}\u001b[0m działa! Czas odpowiedzi: {stopwatch.ElapsedMilliseconds} ms");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n[OFFLINE] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"Strona \u001b[4m{url}\u001b[0m zwróciła błąd. Kod statusu: {response.StatusCode}");
                    }
                }

                Thread.Sleep(czasMs);
            }
        }

        static void GraZaDuzoZaMalo()
        {
            Random random = new Random();
            int liczba = random.Next(1, 101);
            int proby = 0;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("===============================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  Zgadnij liczbę od 1 do 100!  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("===============================");

            int strzal = 0;

            while (strzal != liczba)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nPodaj swoją liczbę: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string wpisanyTekst = Console.ReadLine();

                if (!int.TryParse(wpisanyTekst, out strzal))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nTo nie jest prawidłowa liczba. Wpisz cyfry.");
                    continue;
                }

                proby++;

                if (strzal < liczba)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n====================================");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("  Za mało! Spróbuj wyższej liczby!  ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("====================================");
                }
                else if (strzal > liczba)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n====================================");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("  Za dużo! Spróbuj niższej liczby.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("====================================");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nGratulacje!");
                    Console.WriteLine($"Odgadłeś liczbę {liczba} za {proby} razem!");

                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.Write("\n Kliknij dowolny klawisz, by powrócić do menu.");
                    Console.ReadKey();

                    Console.Clear();
                }
            }
        }

        public class WebhookMessage
        {
            public string content { get; set; }
            public string username { get; set; }
            public string avatar_url { get; set; }
        }
    }
}