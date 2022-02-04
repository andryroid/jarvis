using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Speech.Recognition.SrgsGrammar;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.IO;

namespace jarvis
{
    public partial class Form1 : Form
    {
        bool agir = true;
        int[] e_request = new int[] { 0, 0 };
        StreamReader reader;
        string chemin;
        Process p;
        string  monte = "{UP 1}", descend = "{DOWN 1}", gauche = "{LEFT 1}", droite = "{RIGHT 1}", entrer = "{ENTER 1}", retour = "{BACKSPACE 1}";
        static string encore = "";
        SpeechSynthesizer sp;
        SpeechRecognitionEngine ASREngine;
        string[] mot = new string[] { "je suis lah!","m'avez vous demander?","oui?","je suis toujours lah !","je vous écoute"};
        string[] reponse = new string[] { "de rien!", "je vous en prie!", "tout le plaisir est pour moi!" };
        public Form1()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Active la reconnaissance vocale lors de la pression sur la touche
        /// espace pour une séquence de commande
        /// </summary>
        
        public void Form1_Load(object sender, EventArgs e) {
         
            this.BackColor = Color.Black;
            StartEngine();
            ASREngine.RecognizeAsync(RecognizeMode.Multiple);
            sp = new SpeechSynthesizer();
            try {
                reader = new StreamReader("C:\\repertoire.txt");
                chemin = reader.ReadLine();
            }
            catch {
                MessageBox.Show("Chemin introuvable");
            }
            this.Hide();
        }

        private void StartEngine()
        {
            //Création d'un document de la norme SRGS à partir du fichier grxml
            SrgsDocument xmlGrammar = new SrgsDocument("Grammaire.grxml");
            //Création d'une grammaire depuis le fichier de grammaire
            Grammar grammar = new Grammar(xmlGrammar);
            //Création de l'objet traitant la reconnaissance vocale
            ASREngine = new SpeechRecognitionEngine();
            //Récupération du son du microphone
            ASREngine.SetInputToDefaultAudioDevice();
            //Chargement de la grammaire
            ASREngine.LoadGrammar(grammar);
            //Link des fonctions a appeler en cas de reconnaissance d'un texte
            ASREngine.SpeechRecognized += ASREngine_SpeechRecognized;
            ASREngine.SpeechRecognitionRejected += ASREngine_SpeechRecognitionRejected;
            ASREngine.SpeechHypothesized += ASREngine_SpeechHypothesized;
            //Spécification du nombre maximum d'alternatives
            //Par exemple : b ou p ou d ou t, t ou d, i ou j, etc.
            //Utile pour les sons qui se ressemblent
            ASREngine.MaxAlternates = 2;
            this.MouseClick += Form1_MouseClick;
        }

        void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ASREngine_SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        {
            
        }

        /// <summary>
        /// Méthode utilisée lorsque la reconnaissance vocale a échoué
        /// </summary>
        public void ASREngine_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            recoText.ForeColor = Color.Red;
            sp.Speak("veuillez contacter mon maitre car je ne sais pas ce que vous avez dit!merçi");
            
        }

        /// <summary>
        /// Méthode utilisée lorsque la reconnaissance vocale est réussi
        /// </summary>
        public void ASREngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        { 
            commandText.Text = e.Result.Text ;
            recoText.Text = e.Result.Text;
            if (Regex.IsMatch(recoText.Text, "mon repertoire")) {
                if (agir)
                {
                    p = new Process();
                    p.StartInfo.FileName = chemin;
                    p.Start();
                }
            }
            if (Regex.IsMatch(recoText.Text, "descend"))
            {
                if (agir)
                {
                    SendKeys.SendWait(descend);
                    encore = descend;
                }
  
            }
            if (Regex.IsMatch(recoText.Text, "monte"))
            {
                if (agir)
                {
                    SendKeys.SendWait(monte);
                    encore = monte;
                }
            }
            if (Regex.IsMatch(recoText.Text, "gauche"))
            {
                if (agir)
                {
                    SendKeys.SendWait(gauche);
                   
                }
            }
            if (Regex.IsMatch(recoText.Text, "droite"))
            {
                if (agir)
                {
                    SendKeys.SendWait(droite);
                    encore = droite;
                }
            }
            if (Regex.IsMatch(recoText.Text, "laisse moi seule"))
            {
                if (agir)
                {
                    init(e_request);
                    sp.Speak("es-tu sûre de vouloir rester seule ?");
                    e_request[0] = 1;
                }
            }
            if (Regex.IsMatch(recoText.Text, "retour"))
            {
                if (agir)
                {
                    SendKeys.SendWait(retour);
                    encore = retour;
                }
            }
            if (Regex.IsMatch(recoText.Text, "change de fenêtre"))
            {
                if (agir)
                {
                    SendKeys.SendWait("%" + "{TAB 2}");
                }
            }
            if (Regex.IsMatch(recoText.Text, "ouvre le fichier"))
            {
                if (agir)
                {
                    SendKeys.SendWait(entrer);
                    encore = "";
                }
            }
            if (Regex.IsMatch(recoText.Text, "encore"))
            {
                if (agir)
                {
                    SendKeys.SendWait(encore);
                }
            }
            if (Regex.IsMatch(recoText.Text, "mode plein écran"))
            {
                if (agir)
                {
                    SendKeys.SendWait("{F11}");
                }
            }
            if (Regex.IsMatch(recoText.Text, "séléctionner tout"))
            {
                if (agir)
                {
                    SendKeys.SendWait("^" + "{a}");
                }
            }
            if (Regex.IsMatch(recoText.Text, "fermer"))
            {
                if (agir)
                {
                    init(e_request);
                    sp.Speak("voulez vous vraiment fermer?");
                    e_request[1] = 1;
                }
            }
            if (Regex.IsMatch(recoText.Text, "jarvice"))
            {
                Random r = new Random();
                sp.Speak(""+mot[r.Next(mot.Length)]);
                agir = true;
            }
            if (Regex.IsMatch(recoText.Text, "présente toi"))
            {
                if (agir)
                {
                Process.Start(@"D:\IMAGES\IMG_0481.jpg");
                sp.Speak("donc, je me nomme jarvice........ et je suis un robot crée par le l'homme qui est sur cette image!!!!!!!!");
                }
            }
            if (Regex.IsMatch(recoText.Text, "joue ma musique"))
            {
                if (agir)
                {
                    sp.Speak("ohhhhh!j'aime aussi cette chanson..");
                    Process.Start(@"D:\MUSIC\Mr Sayda\Mr Sayda - Mody Virijiny.mp3");
                }
            }
            if (Regex.IsMatch(recoText.Text, "next"))
            {
                if (agir)
                {
                    try
                    {
                        SendKeys.SendWait("%");
                        SendKeys.SendWait("{l}");
                        SendKeys.SendWait("{DOWN 12}");
                        SendKeys.SendWait("{ENTER}");
                    }
                    catch { recoText.Text = "erreur"; }
                }
            }
            if (Regex.IsMatch(recoText.Text, "précédent"))
            {
                if (agir)
                {
                    try
                    {
                        SendKeys.SendWait("%");
                        SendKeys.SendWait("{l}");
                        SendKeys.SendWait("{DOWN 11}");
                        SendKeys.SendWait("{ENTER}");
                    }
                    catch { recoText.Text = "erreur"; }
                }
            }
            if (Regex.IsMatch(recoText.Text, "augmente le volume"))
            {
                if (agir)
                {
                    try
                    {
                        SendKeys.SendWait("%");
                        SendKeys.SendWait("{a}");
                        SendKeys.SendWait("{DOWN 4}");
                        SendKeys.SendWait("{ENTER}");
                    }
                    catch { recoText.Text = "erreur"; }
                }
            }
            if (Regex.IsMatch(recoText.Text, "diminue le volume"))
            {
                if (agir)
                {
                    try
                    {
                        SendKeys.SendWait("%");
                        SendKeys.SendWait("{a}");
                        SendKeys.SendWait("{DOWN 5}");
                        SendKeys.SendWait("{ENTER}");
                    }
                    catch { recoText.Text = "erreur"; }
                }
            }
            if (Regex.IsMatch(recoText.Text, "quelle heure est-il"))
            {
                if (agir)
                {
                    DateTime d = DateTime.Now;
                    sp.Speak("il est" + d.Hour + "heure et " + d.Minute + "minutes");
                }
            }
            if (Regex.IsMatch(recoText.Text, "merçi"))
            {
                if (agir)
                {
                    Random r = new Random();
                    sp.Speak("" + reponse[r.Next(reponse.Length)]);
                }
            }
            if (Regex.IsMatch(recoText.Text, "oui"))
            {
                if (agir)
                {
                    if (e_request[0] == 1) { sp.Speak("appelle juste mon nom si tu as besoin de moi"); agir = false; init(e_request); this.Hide(); }
                    if (e_request[1] == 1) { SendKeys.SendWait("%"+"{F4}"); init(e_request); }
                }
            }
            if (Regex.IsMatch(recoText.Text, "non"))
            {
                if (agir)
                {
                    sp.Speak("ok andry!");
                    init(e_request);
                }
            }
            if (Regex.IsMatch(recoText.Text, "tu peut disposer"))
            {
                if (agir)
                {
                    sp.Speak("êtes vous sûre?");
                }
            }
            if (Regex.IsMatch(recoText.Text, "pause") | Regex.IsMatch(recoText.Text, "play") )
            {
                if (agir) {
                    SendKeys.SendWait("%");
                    SendKeys.SendWait("l");
                    SendKeys.SendWait("{DOWN 9}");
                    SendKeys.SendWait("{ENTER}");
                }
            }
            if (Regex.IsMatch(recoText.Text, "copie"))
            {
                if (agir)
                {
                    try
                    {
                        SendKeys.SendWait("^"+"{c}");
                    }
                    catch { }
                }
            }
            if (Regex.IsMatch(recoText.Text, "coller"))
            {
                if (agir)
                {
                    try
                    {
                        SendKeys.SendWait("^" + "{v}");
                    }
                    catch { }
                }
            }
            if (Regex.IsMatch(recoText.Text, "internet"))
            {
                if (agir)
                {
                    try
                    {
                        Process.Start("https://m.facebook.com");
                    }
                    catch { }
                }
            }

        }
       
        private void init(int[] x) {
            for (int i = 0; i < x.Length; i++) {
                x[i] = 0;
            }
        }
        private void helpLabel_Click(object sender, EventArgs e)
        {

        }

        private void exemples_TextChanged(object sender, EventArgs e)
        {

        }

        private void affiche_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}