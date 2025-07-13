using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace White_Ch8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string UserGuess;
            UserGuess = UserInput.Text;
        }

        //exit button
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //method for counting words
        private void WordCount(string str)
        {
            //set variables up
            string UserGuess;
            UserGuess = UserInput.Text;
            //char space = ' ';
            int spaceCount = 0;
            //CharCount = 0;
            
            //for loop iterates through user input
            for (int i = 0; i < UserGuess.Length; i++)
            {
                //variable initates so that the code knows to count a new word at every space
                char space = ' ';
                if (UserGuess[i] == space)
                {
                    spaceCount++;
                    
                }
               //variable for final word count
                int WordAmount = spaceCount + 1;
                int AvgCount = 0;
                
                ResultLbl.Text = (WordAmount.ToString().Trim());

                //for loop that gets the character count
                for (int countVar = 0; countVar < UserGuess.Length; countVar++)
                {
                    int CharCount = UserGuess.Length;
                    
                    //how many characters are in the users input
                    CharLbl.Text = CharCount.ToString().Trim();

                    //character count is divided by word amount to get the average characters per word
                    int result = CharCount / WordAmount;
                    AvgLbl.Text = result.ToString().Trim();



                }



            }

          
        }

        //method for checking user input
        private void Validation(string str)
        {
            string UserGuess;
            UserGuess = UserInput.Text;
            string[] tokens = UserGuess.Split(' ');
            
            foreach (string token in tokens)
            {
                // Check if the token contains only letters
                if (!token.All(char.IsLetter))
                {
                    MessageBox.Show("Please enter only words alphabetic characters.");
                    return; // Exit the method if invalid input is found
                }
            }

            }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            //button calls all methods
            string UserGuess;
            UserGuess = UserInput.Text;
            UserGuess.ToLower();
            WordCount(UserGuess);
            Validation(UserGuess);
            
        }

        

        
    }
}
