using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using DurakLibrary;

namespace Durak
{
    public partial class frmMain : Form
    {

        

        /// <summary>
        /// Used to generate PlayingCard objects from a Deck
        /// </summary>
        private CardDealer myDealer = new CardDealer(new Deck());


        public frmMain()
        {
            InitializeComponent();
        }


        private void myDealer_OutOfCards(object sender, EventArgs e)
        {
            pbDeckCard.Image = null;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set the deck image to a card back image
            pbDeckCard.Image = (new PlayingCard()).GetCardImage();
            // Wire the out of cards event handler 
            myDealer.OutOfCards += myDealer_OutOfCards;
            
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            

        }

        void ResetDealer()
        {
            // Clear the panels
            pnlOpponent.Controls.Clear();
            pnlPlayArea.Controls.Clear();
            pnlPlayerArea.Controls.Clear();
           
            // Load the card dealer 
            myDealer.LoadCardDealer();

            // Set the image to a card back
            pbDeckCard.Image = (new PlayingCard()).GetCardImage();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbDeck_Click(object sender, EventArgs e)
        {

        }
    }
}
